using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPRO_QMS_SendSMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            Process[] processe;
            processe = Process.GetProcessesByName("GPRO_QMS_SendSMS");
            foreach (Process dovi in processe)
                dovi.Kill();
        }
    }
}
