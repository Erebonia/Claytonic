using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;
using System.Reflection;

namespace DIT_AIO
{
    public partial class Runetonic : Form
    {
        //This is used for the dark background when hovering over something.
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        //Audio Player
        private AudioPlayer audioPlayer; 
        private Image playImage;
        private Image pauseImage;

        //UI Handler
        private ButtonNavigator navigator;
        private CategoryNavigator categoryNavigator;

        public Runetonic()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(28, 28, 18);

            // Initialize images in the constructor
            playImage = Image.FromStream(ResourceHelper.GetResourceStream("DIT_AIO.Resources.playing.png"));
            pauseImage = Image.FromStream(ResourceHelper.GetResourceStream("DIT_AIO.Resources.paused.png"));

            // Initialize navigator
            navigator = new ButtonNavigator(pnlNav, Color.FromArgb(46, 51, 73), Color.FromArgb(30, 31, 34));

            // Initialize CategoryNavigator
            categoryNavigator = new CategoryNavigator(pnlNav, Color.FromArgb(46, 51, 73), Color.FromArgb(30, 31, 34), this.Master);

            // Initialize AudioPlayer
            audioPlayer = new AudioPlayer();
            audioPlayer.LoadAudio("DIT_AIO.Resources.EzraFortuneLoop.wav");

            // Attach event handlers
            btnDashboard.Click += categoryNavigator.HandleCategoryClick;
            btnDataRecovery.Click += categoryNavigator.HandleCategoryClick;
            btnDiagnostics.Click += categoryNavigator.HandleCategoryClick;
            btnSystemSetup.Click += categoryNavigator.HandleCategoryClick;
            btnMainframe.Click += categoryNavigator.HandleCategoryClick;
            btnSettings.Click += categoryNavigator.HandleCategoryClick;
            btnMinimize.Click += categoryNavigator.HandleMinimizeClick;
            btnClose.Click += categoryNavigator.HandleCloseClick;

            // Ensure Home tab is selected when starting the program
            categoryNavigator.HandleCategoryClick(btnDashboard, EventArgs.Empty);

            // Attach FormDragger to THIS entire form and its controls
            FormDragger dragger = new FormDragger();
            dragger.Attach(this);
            AttachDragEventHandlers(this, dragger); // Pass the dragger instance here
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
            runCustomScript(@"\\ditfp1\helpdesk\BN\Data Migration Script\00Backup - User Profile.bat");
        }

        private void Restore_Data(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Data Migration Script\00Restore - User Profile.bat");
        }

        private void Backup_Printers(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Data Migration Script\22backup_printers.bat");
        }

        private void Restore_Printers(object sender, EventArgs e)
        {
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
            runCustomScript(@"\\ditfp1\helpdesk\BN\Technician_Tools\SFC_Scannow.bat");
        }

        private void DISM(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Technician_Tools\DISM.bat");
        }

        private void Scanner_Setup(object sender, EventArgs e)
        {
            runCustomScript(@"\\Ditfp1\helpdesk\PaperPort\CCHSCAN1\ImageRetrieverFix5.cmd");
        }

        private void Electronic_Signature(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\!SHORTCUTS!\checkCert.bat");
        }

        private void Blank_Login(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\!SHORTCUTS!\BlankLogin.cmd");
        }

        private void DisableFirewall(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Firewall\firewall-notifications-off.reg");
            runCustomScript(@"\\ditfp1\helpdesk\BN\Firewall\firewall-off.bat");
        }

        private void Outlook_Cache_Removal(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\Microsoft_Office\Outlook Fixes\Outlook Cache Corrupt Fix\OutlookAllVersionsFix\formsCache.bat");
            runCustomScript(@"\\ditfp1\helpdesk\Microsoft_Office\Outlook Fixes\Outlook Form Issue\Archive Manager Bulletin 15_Sep_2017 - Registry Keys\Outlook 2016\Outlook 2016 - 64 Bit.reg");
        }

        private void CCH_Deploy(object sender, EventArgs e)
        {
            runCustomScript(@"\\cchdeploy1\dep$\AppInstallOnly.bat");
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
            runCustomScript(@"\\ditfp1\helpdesk\Mainframe attachmate (Extra!)\MainframeEDPModify.cmd");
        }

        private void Mainframe_Guides(object sender, EventArgs e)
        {
            runCustomScript(@"\\Ditfp1\helpdesk\BN\Mainframe");
        }

        private void runCustomScript(string scriptPath)
        {
            // Create a new process to run the script
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = scriptPath,
                // UseShellExecute needs to be set to true if the script requires using the system shell
                UseShellExecute = true
            };

            try
            {
                // Start the process
                Process process = Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                // Show error message if the script fails to start
                MessageBox.Show($"Failed to run script: {ex.Message}");
            }
        }

        private void Music_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Get the button that was clicked

            if (audioPlayer.IsPlaying())
            {
                // Stop the sound if it's playing
                audioPlayer.Stop();
                clickedButton.Image = pauseImage;
            }
            else
            {
                // Play the sound if it's not playing
                audioPlayer.PlayLooping();
                clickedButton.Image = playImage;
            }
        }
    }
}

