using System;
using System.Windows.Forms;
using DIT_AIO.Helpers; // Ensure this namespace is correctly referenced

namespace DIT_AIO
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // This is where the program will find the "updated" program.
            // Build the latest version of this program, slap it in here, and it will force other claytonics to update to it.
            string remoteExePath = @"\\ditfp1\helpdesk\BN\Technician_Tools\DO_NOT_TOUCH\Claytonic.exe";
            string localExePath = Application.ExecutablePath;

            // Check for updates before displaying the form
            bool updating = UpdateHelper.CheckForUpdates(remoteExePath, localExePath);
            if (!updating)
            {
                Application.Run(new Runetonic());
            }
        }
    }
}
