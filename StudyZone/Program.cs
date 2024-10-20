using StudyZone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyZone
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        //In Program.cs
        //static void Main(string[] args)
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    MainForm mainForm = new MainForm();

        //    if (args.Contains("/minimized"))
        //    {
        //        mainForm.WindowState = FormWindowState.Minimized;
        //    }

        //    Application.Run(mainForm);
        //}

    }
}

