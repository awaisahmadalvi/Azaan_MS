using System;
using System.Windows.Forms;
using Azaan.Core.UI;
using System.ServiceProcess;
using System.ServiceModel;
using System.Threading;

namespace Azaan
{
    public partial class mainForm : Form
    {
        System.Timers.Timer SyncTimer;
        bool isSrvcRunning = false;
        ChannelFactory<Azaan.IIPCService> cfClient;
        BasicHttpBinding httpBinding;
        Azaan.IIPCService service;

        short CROSS = 0, OK = 1, WAIT = 2;

        NamazName name;
        PictureBox[] tempPB;

        public mainForm()
        {
            InitializeComponent();

            updateStatusBar();

            InitLocalComponents();
        }

        /*
         * Set Listeners and time according to service
         * 
         */
        public void InitLocalComponents()
        {
            name = new NamazName();

            while (!isSrvcRunning)
                Thread.Sleep(100);
            /*
             * Set Time according to Service JSON
             * 
             */
            DateTime t = DateTime.Now;
            this.timePickerFajar.setTime(service.srvcGetTime(name.Fajar, out t) ? t : t);
            this.timePickerZohar.setTime(service.srvcGetTime(name.Zohar, out t) ? t : t);
            this.timePickerAsar.setTime(service.srvcGetTime(name.Asar, out t) ? t : t);
            this.timePickerMaghrib.setTime(service.srvcGetTime(name.Maghrib, out t) ? t : t);
            this.timePickerIsha.setTime(service.srvcGetTime(name.Isha, out t) ? t : t);
            this.timePickerJumma.setTime(service.srvcGetTime(name.Jumma, out t) ? t : t);

            tempPB = new PictureBox[] { this.pbFajar, this.pbZohar, this.pbAsar, this.pbMaghrib, this.pbIsha, this.pbJumma };

            setActiveIcon();
            setWaitIcon();

            /*
             * Setting Listeners to timepicker
             * 
             */
            this.timePickerFajar.setTimeChangeListener(fajarTimeChanged);
            this.timePickerZohar.setTimeChangeListener(zoharTimeChanged);
            this.timePickerAsar.setTimeChangeListener(asarTimeChanged);
            this.timePickerMaghrib.setTimeChangeListener(maghribTimeChanged);
            this.timePickerIsha.setTimeChangeListener(ishaTimeChanged);
            this.timePickerJumma.setTimeChangeListener(jummaTimeChanged);
        }

        /*
         * Setting Active icons
         * 
         */
        public void setActiveIcon()
        {
            bool[] activ = null;
            service.srvcGetActive(out activ);
            for (int i = 0; i < tempPB.Length; i++)
            {
                if (activ[i])
                {
                    tempPB[i].Image = global::Azaan.Properties.Resources.Ok;
                    tempPB[i].Tag = OK;
                }
                else
                {
                    tempPB[i].Image = global::Azaan.Properties.Resources.Cross;
                    tempPB[i].Tag = CROSS;
                }
            }
        }

        /*
         * Setting Waiting namaz icon
         * 
         */
        public void setWaitIcon()
        {
            String waitNamaz = "";
            if (service.srvcGetWaiting(out waitNamaz))
            {
                int i = Array.IndexOf(name.array, waitNamaz);
                tempPB[i].Image = global::Azaan.Properties.Resources.Wait;
                tempPB[i].Tag = WAIT;
            }
        }

        public void fajarTimeChanged(object sender, ValueChangedEventArgs<DateTime> e)
        {
            if (service.srvcSetTime(name.Fajar, (DateTime)e.NewValue) == true)
            {
                updateTimeSuccess(name.Fajar);
            }
        }

        public void zoharTimeChanged(object sender, ValueChangedEventArgs<DateTime> e)
        {
            if (service.srvcSetTime(name.Zohar, (DateTime)e.NewValue) == true)
            {
                updateTimeSuccess(name.Zohar);
            }
        }

        public void asarTimeChanged(object sender, ValueChangedEventArgs<DateTime> e)
        {
            if (service.srvcSetTime(name.Asar, (DateTime)e.NewValue) == true)
            {
                updateTimeSuccess(name.Asar);
            }
        }

        public void maghribTimeChanged(object sender, ValueChangedEventArgs<DateTime> e)
        {
            if (service.srvcSetTime(name.Maghrib, (DateTime)e.NewValue) == true)
            {
                updateTimeSuccess(name.Maghrib);
            }
        }

        public void ishaTimeChanged(object sender, ValueChangedEventArgs<DateTime> e)
        {
            if (service.srvcSetTime(name.Isha, (DateTime)e.NewValue) == true)
            {
                updateTimeSuccess(name.Isha);
            }
        }

        public void jummaTimeChanged(object sender, ValueChangedEventArgs<DateTime> e)
        {
            if (service.srvcSetTime(name.Jumma, (DateTime)e.NewValue) == true)
            {
                updateTimeSuccess(name.Jumma);
            }
        }

        public void updateTimeSuccess(String namazName)
        {
            this.toolStripStatusLabel1.Image = global::Azaan.Properties.Resources.Green;
            this.toolStripStatusLabel1.Text = namazName + " time in sync";
            setActiveIcon();
            setWaitIcon();
        }

        public bool checkService()
        {
            ServiceController[] scServices;
            scServices = ServiceController.GetServices();

            foreach (ServiceController scTemp in scServices)
            {

                if (scTemp.ServiceName == "AzaanService")
                {
                    ServiceController sc = new ServiceController("AzaanService");
                    if (sc.Status == ServiceControllerStatus.Stopped)
                    {
                        sc.Start();
                    }
                    return (sc.Status == ServiceControllerStatus.Running); //return the service new status 
                }
            }
            return false;
        }

        private void updateStatusBar()
        {
            if (checkService())
            {
                this.toolStripStatusLabel1.Image = global::Azaan.Properties.Resources.Green;
                this.toolStripStatusLabel1.Text = "Service running perfectly...";

                schedule_Timer(10 * 1000);      //If Service is up, check every minute
                setServiceIPCChannel();

                isSrvcRunning = true;
            }
            else
            {
                this.toolStripStatusLabel1.Image = global::Azaan.Properties.Resources.Wait;
                this.toolStripStatusLabel1.Text = "Starting Service. Please Wait...";
                schedule_Timer(1 * 1000);      //If Service is Down, check every Second
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (cfClient != null)
                cfClient.Close();
            this.Close();
        }

        public void setServiceIPCChannel()
        {
            httpBinding = new BasicHttpBinding(BasicHttpSecurityMode.TransportCredentialOnly);
            httpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;

            cfClient = new ChannelFactory<Azaan.IIPCService>(httpBinding, "http://localhost:5000/AzaanServiceIPC");

            cfClient.Credentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
            cfClient.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials;

            service = cfClient.CreateChannel();

            //cfClient.Close();
        }

        /*
         *  Schedule a Timer
         *  
         **/
        protected void schedule_Timer(double tickTime)
        {
            if (SyncTimer != null)
                SyncTimer.Stop();
            SyncTimer = new System.Timers.Timer(tickTime);
            SyncTimer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            SyncTimer.Start();
        }

        /*
         * Call back of Alarm event
         * 
         **/
        protected void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            updateStatusBar();
            setActiveIcon();
            setWaitIcon();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            /*
             * if Active then Disable
             * or otherwise/waiting
             * 
             * */
            service.srvcSetActive(name[Array.IndexOf(tempPB, sender)], ((PictureBox)sender).Tag.Equals(CROSS));
            setActiveIcon();
            setWaitIcon();
        }
    }
}
