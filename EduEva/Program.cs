using System;
using System.IO;
using System.Windows.Forms;
using EduEva.MainUI;
using EduEva.Properties;
using Ninject;

namespace EduEva
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
            FirstRunCheck();

            var form = CreateForm();
            Application.Run(form);
        }

        private static void FirstRunCheck()
        {
            if (File.Exists(Resources.SaveFile)) return;
            var sw = File.CreateText(Resources.SaveFile);
            sw.Close();
        }

        private static Form CreateForm()
        {
            IKernel kernel = new StandardKernel(new EduModule());
            return kernel.Get<MainWindow>();
        }
    }

}
