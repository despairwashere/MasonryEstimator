using System;
using System.Windows.Forms;

namespace MasonryEstimator.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Configure the application (high DPI, default fonts, etc.)
            ApplicationConfiguration.Initialize();

            // Start the WinForms application and open MainForm
            Application.Run(new MainForm());
        }
    }
}
