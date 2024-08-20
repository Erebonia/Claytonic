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

            // Define the paths for the remote and local executables
            string remoteExePath = @"\\ditfp1\helpdesk\BN\Technician_Tools\Claytonic.exe";
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
