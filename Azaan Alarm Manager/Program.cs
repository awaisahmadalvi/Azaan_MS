using System;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Threading;


namespace Azaan.Core.UI
{

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Form f = new mainForm();
            Application.Run(f);
        }
    }
}