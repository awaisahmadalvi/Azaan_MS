using System;
using System.IO;
using System.Media;
using System.ServiceModel;
using System.ServiceProcess;
using System.Collections.Generic;
using SimpleJSON;

namespace Azaan
{
    public partial class AzaanService : ServiceBase, IIPCService
    {
        public static System.Timers.Timer namazTimer;

        private ServiceHost _sHost = null;

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "azaan_status.json");

        //string azaanPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Coindrop.wav");
        string azaanPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Adhan.wav");
        string azaanFajarPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Adhan_fajar.wav");

        bool isAlarmSet = false;
        attributes attrib = new attributes();
    
        public AzaanService()
        {
            InitializeComponent();
            initLog();
            checkStatusFile();
        }

        /*
         * Getting all active namaz array from json status file
         * according to the current day (Friday managed)
         * 
         **/
        private NamazName getActiveNamaz()
        {
            List<string> list = new List<string>();

            // Replace zohar with jumma if todays is Friday
            NamazName tempName = new NamazName(DateTime.Now.DayOfWeek.ToString().Equals("Friday"));

            for (int i = 0; i < tempName.Length; i++)
            {
                if (getJson(new String[] { tempName[i], attrib.active }).ToString().Replace("\"", "").Equals("1"))      // If namaz status is active ?
                {
                    // Add to List/array if namaz status is active
                    list.Add(tempName[i]);
                }
            }
            return new NamazName(list.ToArray());
        }

        /*
         * Setting Json parameters *WAITING* in status file
         * 
         **/
        private void setWaitingStatus(String namaz2activ)
        {
            NamazName name = new NamazName();
            // Setting Waiting: false to all Namaz
            foreach (string nam in name.array)
            {
                setJson(new String[] { nam, attrib.waiting }, "false");
            }
            if (namaz2activ != null)
                setJson(new String[] { namaz2activ, attrib.waiting }, "true");
        }

        /*
         * Checking if Status file is available,
         * if not, then create with Null values.
         * 
         **/
        private void checkStatusFile()
        {
            //if the file doesn't exist, create it and populate it with embedded resource NULL string
            if (!File.Exists(filePath))
            {
                FileStream f = File.Create(filePath);
                f.Close();
                using (System.IO.StreamWriter fw = new System.IO.StreamWriter(filePath))
                {
                    string text = Properties.Resources.azaan_status;
                    fw.Write(text.ToString());
                    eventLogger.WriteEntry(DateTime.Now.ToString() + ": " + filePath.ToString() + " Created successfully with NULL values.");
                }
            }
        }

        /*
         * Getting Json parameters from status file
         * 
         **/
        private String getJson(String[] keys)
        {
            string text = "";

            using (System.IO.StreamReader fr = new StreamReader(filePath))
            {
                text = fr.ReadToEnd();
            }

            JSONNode N = JSON.Parse(text);
            string val = N[keys[0]][keys[1]];

            return val;
        }

        /*
         * Setting Json parameters in status file
         * 
         **/
        private void setJson(String[] keys, String value)
        {
            string text = "";
            using (System.IO.StreamReader fr = new StreamReader(filePath))
            {
                text = fr.ReadToEnd();
            }
            JSONNode N = JSON.Parse(text);
            N[keys[0]][keys[1]] = value;
            //eventLogger.WriteEntry(DateTime.Now.ToString() + ": Value for {" + keys[0] + "{" + keys[1] + "}} is changed to " + value);
            text = N.ToString();
            using (System.IO.StreamWriter fw = new System.IO.StreamWriter(filePath))
            {
                fw.WriteLine(text.ToString());
            }
        }

        /*
         * Initilizing logging parameters
         * 
         **/
        protected void initLog()
        {
            if (!System.Diagnostics.EventLog.SourceExists("AzaanService Log"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "AzaanService Log", "AzaanService Log");
            }
            eventLogger.Source = "AzaanService Log";
            eventLogger.Log = "AzaanService Log";
        }

        /*
         * Task todo when Service is resumed/paused on suspend events
         * 
         **/
        protected override bool OnPowerEvent(PowerBroadcastStatus powerStatus)
        {
            if (powerStatus.HasFlag(PowerBroadcastStatus.Suspend))
            {
                // TODO on suspend event
                namazTimer.Stop();
                eventLogger.WriteEntry("Azaan Service suspended on PowerStatus: " + powerStatus);
            }
            else if (powerStatus.HasFlag(PowerBroadcastStatus.ResumeAutomatic) ||
                powerStatus.HasFlag(PowerBroadcastStatus.ResumeSuspend) ||
                powerStatus.HasFlag(PowerBroadcastStatus.ResumeCritical))
            {
                // TODO on resume events
                eventLogger.WriteEntry("Azaan Service resumed on PowerStatus: " + powerStatus);
                checkStatusFile();
                checkTime();
            }
            return base.OnPowerEvent(powerStatus);
        }

        protected override void OnStart(string[] args)
        {
            eventLogger.WriteEntry("Azaan Service started successfully");
            StartIPCService();
            eventLogger.WriteEntry("IPC Module started successfully");
            checkTime();
            eventLogger.WriteEntry("Checktime Completed");
        }

        /*
         * Task todo when Service is stopped
         * Memory clearance, Alarm disabling etc.
         * 
         **/
        protected override void OnStop()
        {
            namazTimer.Stop();
            StopIPCService();

            eventLogger.WriteEntry("Azaan Service stoped successfully");
        }

        /*
         * Play Azaan
         * 
         **/
        protected void playAzaan()
        {
            //unmute();
            SoundPlayer player = new SoundPlayer(azaanPath);
            player.Play();
            //mute();
        }

        /*
         * Play Fajar Azaan
         * 
         **/
        protected void playFajarAzaan()
        {
            //playAzaan();
            //unmute();
            SoundPlayer player = new SoundPlayer(azaanFajarPath);
            player.Play();
            //mute();
        }

        /*
         * Checking the next valid namaz time
         * and setting alarm for that
         * 
         **/
        private void checkTime()
        {
            DateTime now = DateTime.Now;

            NamazName tempName = getActiveNamaz();

            isAlarmSet = false;

            for (int i = 0; i < tempName.Length; i++)
            {
                String d = getJson(new String[] { tempName[i], attrib.time }).ToString().Replace("\"", "");
                DateTime namazTime = DateTime.ParseExact(d, "HH:mm:ss", null);
                if (DateTime.Compare(namazTime, now) >= 0)
                {
                    bool isMidnight = false;
                    schedule_Timer(namazTime, isMidnight);
                    eventLogger.WriteEntry(DateTime.Now.ToString() + ": Alarm is set for " + tempName[i] + " : " + i + " on " + namazTime.ToString());
                    // set Waiting to true, prev to false
                    setWaitingStatus(tempName[i]);
                    break;
                }
            }
            if (!isAlarmSet)
            {
                // No Alarm for Today, Set Alarm for 12:00AM tomorrow to check next Alarm
                DateTime namazTime = DateTime.Today.AddDays(1);
                bool isMidnight = true;
                schedule_Timer(namazTime, isMidnight);
                eventLogger.WriteEntry(DateTime.Now.ToString() + ": Alarm is set for * " + namazTime.ToString());
                // set Waiting to true, prev to false
                setWaitingStatus(null);
            }
        }

        /*
         *  Schedule an Alarm, Timer
         *  
         **/
        protected void schedule_Timer(DateTime scheduledTime, bool isMidnight)
        {
            DateTime nowTime = DateTime.Now;
            if (nowTime > scheduledTime)
            {
                scheduledTime = scheduledTime.AddDays(1);
            }

            double tickTime = (double)(scheduledTime - DateTime.Now).TotalMilliseconds;

            if (namazTimer != null)
            {   
                namazTimer.Enabled = false;
                namazTimer.Stop();
                namazTimer.Close();
                namazTimer.Dispose();
            }

            namazTimer = new System.Timers.Timer(tickTime);
            if (isMidnight)                                 // Idle timer for 00:00
                namazTimer.Elapsed += new System.Timers.ElapsedEventHandler(timerMidnightElapsed);
            else
                namazTimer.Elapsed += new System.Timers.ElapsedEventHandler(timerNamazElapsed);
            namazTimer.Start();
            isAlarmSet = true;
        }

        /*
         * Call back of Alarm event
         * 
         **/
        protected void timerNamazElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            namazTimer.Stop();
            String nextNamaz = "";
            srvcGetWaiting(out nextNamaz);
            if (nextNamaz.Equals("fajar"))
                playFajarAzaan();
            else
                playAzaan();

            eventLogger.WriteEntry(DateTime.Now.ToString() + ": " + nextNamaz + " Azaan Played @ " + DateTime.Now);
            checkTime();
        }

        /*
         * Call back of Midnight Alarm event
         * 
         **/
        protected void timerMidnightElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            namazTimer.Stop();
            isAlarmSet = false;
            checkTime();
        }


        /*
         * Related to IPC
         * Start listening to endpoint
         * 
         **/
        public void StartIPCService()
        {
            BasicHttpBinding httpBinding;

            _sHost = new ServiceHost(typeof(AzaanService));
            httpBinding = new BasicHttpBinding(BasicHttpSecurityMode.TransportCredentialOnly);
            httpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;

            _sHost.AddServiceEndpoint(typeof(IIPCService), httpBinding, "http://localhost:5000/AzaanServiceIPC");

            _sHost.Open();
        }

        public void StopIPCService()
        {
            if (_sHost != null)
                _sHost.Close();
        }

        /*
         * Call to Service from GUI
         * 
         **/
        public bool srvcSetTime(string namaz, DateTime t)
        {
            setJson(new String[] { namaz, attrib.time }, t.ToString("HH:mm:00"));
            eventLogger.WriteEntry(DateTime.Now.ToString() + ": Value for {" + namaz + "{" + attrib.time + "}} is changed to " + t.ToString("HH:mm:00"));
            checkTime();
            return true;
        }

        public bool srvcGetTime(string namaz, out DateTime t)
        {
            t = DateTime.Parse(getJson(new String[] { namaz, attrib.time }));
            return true;
        }

        public bool srvcSetActive(string namaz, bool activ)
        {
            setJson(new String[] { namaz, attrib.active }, activ ? "1" : "0");
            eventLogger.WriteEntry(DateTime.Now.ToString() + ": Value for {" + namaz + "{" + attrib.active + "}} is changed to " + (activ ? "1" : "0"));
            checkTime();
            return true;
        }

        public bool srvcGetActive(out bool[] activ)
        {
            NamazName name = new NamazName();
            activ = new bool[name.Length];

            for (int i = 0; i < name.Length; i++)
            {
                activ[i] = getJson(new String[] { name[i], attrib.active }).ToString().Replace("\"", "").Equals("1");
            }
            return true;
        }

        public bool srvcGetWaiting(out string namaz)
        {
            NamazName name = new NamazName();
            foreach (String nam in name.array)
            {
                if (getJson(new String[] { nam, attrib.waiting }).ToString().Replace("\"", "").Equals("true"))
                {
                    namaz = nam;
                    return true;
                }
            }
            namaz = "";
            return false;
        }
    }
}
