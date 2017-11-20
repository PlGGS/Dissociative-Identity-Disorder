using System;
using System.Windows.Forms;
using Dissociative_Identity_Disorder.Resources;

namespace Dissociative_Identity_Disorder
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
            frmMain main = new frmMain();
            main.Show();
            Taskbar.Hide();
            Application.Run();
        }
    }
}
