using System;
using System.Windows.Forms;
using DIT_AIO.Helpers;

namespace DIT_AIO
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #if local
                // LOCAL build update path
                string remoteExePath = @"\\ditfp1\helpdesk\BN\Technician_Tools\DO_NOT_TOUCH\Claytonic_LOCAL.exe";
            #else
                // Debug/Release build update path
                string remoteExePath = @"\\ditfp1\helpdesk\BN\Technician_Tools\DO_NOT_TOUCH\Claytonic.exe";
            #endif
                string localExePath = Application.ExecutablePath;

                // Attempt update
                bool updating = UpdateHelper.CheckForUpdates(remoteExePath, localExePath);

            // Only run program if not updating
            if (!updating)
            {
                Application.Run(new Runetonic());
            }
        }
    }
}
