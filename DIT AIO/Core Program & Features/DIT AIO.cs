using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;

namespace DIT_AIO
{
    public partial class Runetonic : Form
    {

        //UI Handler
        private CategoryNavigator categoryNavigator;

        private NPCDialogue npcDialogue;

        public Runetonic()
        {
            // For designer.cs to instantiate
            InitializeComponent();

            using (var stream = ResourceHelper.GetResourceStream("DIT_AIO.Resources.patchnotes.html"))
            using (var reader = new StreamReader(stream))
            {
                patchNotesBrowser.DocumentText = reader.ReadToEnd();
            }

            // Initialize colors for navigation buttons
            categoryNavigator = new CategoryNavigator(pnlNav, Color.FromArgb(46, 51, 73), Color.FromArgb(30, 31, 34), this.Master);

            // Attach event handlers
            btnDashboard.Click += categoryNavigator.HandleCategoryClick;
            btnDataRecovery.Click += categoryNavigator.HandleCategoryClick;
            btnDiagnostics.Click += categoryNavigator.HandleCategoryClick;
            btnSystemSetup.Click += categoryNavigator.HandleCategoryClick;
            btnMainframe.Click += categoryNavigator.HandleCategoryClick;
            btnSettings.Click += categoryNavigator.HandleCategoryClick;

            // Ensure Home tab is selected when starting the program
            categoryNavigator.HandleCategoryClick(btnDashboard, EventArgs.Empty);

            // Attach FormDragger to THIS entire form and its controls
            // This allows us to drag the program
            FormDragger dragger = new FormDragger();
            dragger.Attach(this);
            AttachDragEventHandlers(this, dragger);

            // Initialize NPCDialogue and start it when the program loads
            npcDialogue = new NPCDialogue(npcdialogue);
            // 35 is characters displaying every 35ms to simulate talking and 10k ms (10 seconds) delay for each phrase
            this.Load += async (s, e) => await npcDialogue.StartDialogue(35, 10000);

            //Maximize mode will not cover the taskbar
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void AttachDragEventHandlers(Control control, FormDragger dragger)
        {
            dragger.Attach(control); // Attach drag handler to each control
            foreach (Control child in control.Controls)
            {
                AttachDragEventHandlers(child, dragger); // Recursively attach to all child controls
            }
        }

        private void Backup_Data(object sender, EventArgs e)
        {
            if (!requireAdminOrDifferentUser()) return;
            runCustomScript(@"\\ditfp1\helpdesk\BN\Data Migration Script\00Backup - User Profile.bat");
        }

        private void Restore_Data(object sender, EventArgs e)
        {
            if (!requireAdminOrDifferentUser()) return;
            runCustomScript(@"\\ditfp1\helpdesk\BN\Data Migration Script\00Restore - User Profile.bat");
        }

        private void Backup_Printers(object sender, EventArgs e)
        {
            if (!requireAdminOrDifferentUser()) return;
            runCustomScript(@"\\ditfp1\helpdesk\BN\Data Migration Script\22backup_printers.bat");
        }

        private void Restore_Printers(object sender, EventArgs e)
        {
            if (!requireAdminOrDifferentUser()) return;
            runCustomScript(@"\\ditfp1\helpdesk\BN\Data Migration Script\22restore_printers.bat");
        }

        private void Net_User(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Technician_Tools\netuser.bat");
        }

        private void ping_ipaddress(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Technician_Tools\ping_ipaddress.bat");
        }

        private void SFC_Scan(object sender, EventArgs e)
        {
            if (!requireAdminOrDifferentUser()) return;
            runCustomScript(@"\\ditfp1\helpdesk\BN\Technician_Tools\SFC_Scannow.bat");
        }

        private void DISM(object sender, EventArgs e)
        {
            if (!requireAdminOrDifferentUser()) return;
            runCustomScript(@"\\ditfp1\helpdesk\BN\Technician_Tools\DISM.bat");
        }

        private void Scanner_Setup(object sender, EventArgs e)
        {
            if (!stopDifferentUser()) return;
            runCustomScript(@"\\Ditfp1\helpdesk\PaperPort\CCHSCAN1\ImageRetrieverFix5.cmd");
        }

        private void Electronic_Signature(object sender, EventArgs e)
        {
            if (!stopDifferentUser()) return;
            runCustomScript(@"\\ditfp1\helpdesk\Digital Signatures\New Files\checkCert2.bat");
        }


        private void Blank_Login(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\!SHORTCUTS!\BlankLogin.cmd");
        }

        private void DisableFirewall(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Technician_Tools\Common_Fixes\Firewall\firewall-notifications-off.reg");
            runCustomScript(@"\\ditfp1\helpdesk\BN\Technician_Tools\Common_Fixes\Firewall\firewall-off.bat");
        }

        private void Outlook_Cache_Removal(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\Microsoft_Office\Outlook Fixes\Outlook Cache Corrupt Fix\OutlookAllVersionsFix\formsCache.bat");
            runCustomScript(@"\\ditfp1\helpdesk\Microsoft_Office\Outlook Fixes\Outlook Form Issue\Archive Manager Bulletin 15_Sep_2017 - Registry Keys\Outlook 2016\Outlook 2016 - 64 Bit.reg");
        }

        private void CCH_Deploy(object sender, EventArgs e)
        {
            #if local
            MessageBox.Show($"You need network connection for this feature.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            #else
            runCustomScript(@"\\cchdeploy1\dep$\AppInstallOnly.bat");
            #endif

        }

        private void Install_ACID_Unsuspend(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Mainframe\Install_ACID_Unsuspend.bat");
        }

        private void Install_ACID_Reset(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Mainframe\Install_ACID_PW_Reset.bat");
        }

        private void Clear_PS_PrinterData(object sender, EventArgs e)
        {
            if (!requireAdminOrDifferentUser()) return;
            runCustomScript(@"\\ditfp1\helpdesk\Mainframe attachmate (Extra!)\MainframeEDPModify.cmd");
        }

        private void Mainframe_Guides(object sender, EventArgs e)
        {
            #if local
            MessageBox.Show($"You need network connection for this feature.", "Warning", MessageBoxButtons.OK,  MessageBoxIcon.Warning);
            #else
            runCustomScript(@"\\Ditfp1\helpdesk\BN\Mainframe");
            #endif
        }

        private void install_VistaTN3270(object sender, EventArgs e)
        {
            #if local
            MessageBox.Show($"You need network connection for this feature.");

            #else
            runCustomScript(@"\\ditfp1\helpdesk\VistaTN3270\mfinstall.bat");
            #endif

        }

        private void runCustomScript(string scriptPath)
        {
            #if local
            // LOCAL build: always use embedded resources
            string fileName = Path.GetFileName(scriptPath);
            ResourceHelper.RunEmbeddedBat(fileName);
            #else
            try
            {
                // Attempt to run from network path
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = scriptPath,
                    UseShellExecute = true
                };
                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                // Fallback to embedded resource if network fails
                MessageBox.Show(
                    $"Network shared drive connection to script failed ({ex.Message}). Falling back to local version.",
                    "Fallback",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                try
                {
                    string fileName = Path.GetFileName(scriptPath);
                    ResourceHelper.RunEmbeddedBat(fileName);
                }
                catch (Exception embeddedEx)
                {
                    MessageBox.Show($"Embedded script also failed: {embeddedEx.Message}");
                }
            }
            #endif
        }


        //Logic to retrieve current user logged on vs who ran the console "run as different user".
        [DllImport("wtsapi32.dll", SetLastError = true)]
        private static extern bool WTSQuerySessionInformation(
        IntPtr hServer, int sessionId, WTS_INFO_CLASS wtsInfoClass,
        out IntPtr ppBuffer, out int pBytesReturned);

        [DllImport("wtsapi32.dll")]
        private static extern void WTSFreeMemory(IntPtr pointer);

        private enum WTS_INFO_CLASS
        {
            WTSUserName = 5,
            WTSDomainName = 7
        }

        // Check who is utilizing the program.
        private string GetConsoleUsername()
        {
            IntPtr buffer;
            int strLen;
            string username = null;

            int sessionId = Process.GetCurrentProcess().SessionId;
            if (WTSQuerySessionInformation(IntPtr.Zero, sessionId, WTS_INFO_CLASS.WTSUserName, out buffer, out strLen) && strLen > 1)
            {
                username = Marshal.PtrToStringAnsi(buffer);
                WTSFreeMemory(buffer);
            }

            return username;
        }

        //Compare who is using against the logged on domain user
        private bool stopDifferentUser()
        {
            string processUser = WindowsIdentity.GetCurrent().Name;
            string consoleUser = GetConsoleUsername();

            if (!processUser.EndsWith("\\" + consoleUser, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Please do not use 'Run as different user' for this feature. Log in as the intended user instead.",
                    "Unauthorized Execution",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false; 
            }

            return true; 
        }

        private bool requireAdminOrDifferentUser()
        {
            string processUser = WindowsIdentity.GetCurrent().Name;
            string consoleUser = GetConsoleUsername();

            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                bool isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);

                if (isAdmin)
                {
                    return true; 
                }
            }

            if (processUser.EndsWith("\\" + consoleUser, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "This function requires admin rights. Please run as a different user with elevated permissions.",
                    "Insufficient Permissions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            return true;
        }
    }
}


