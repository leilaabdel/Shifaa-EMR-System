using System;
using System.Windows.Forms;

namespace Shifaa_EMR_System
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
            //Application.Run(new WelcomeHomePage());
            Application.Run(new ProviderMain("leila Ab", "0"));
        }
    }
}
