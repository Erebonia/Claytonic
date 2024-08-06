using System;
using System.Windows.Forms;

namespace DIT_AIO
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check for updates before displaying the form
            bool updating = Runetonic.CheckForUpdates();
            if (!updating)
            {
                Application.Run(new Runetonic());
            }
        }
    }
}
