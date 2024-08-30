using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace DIT_AIO
{
    public partial class Runetonic : Form
    {

        //UI Handler
        private CategoryNavigator categoryNavigator;

        private NPCDialogue npcDialogue;

        private AudioPlayer audioPlayer;
        private Image playImage;
        private Image pauseImage;

        public Runetonic()
        {
            // For designer.cs to instantiate
            InitializeComponent();

            // Initialize the images for our music buttons.
            playImage = Image.FromStream(ResourceHelper.GetResourceStream("DIT_AIO.Resources.playing.png"));
            pauseImage = Image.FromStream(ResourceHelper.GetResourceStream("DIT_AIO.Resources.paused.png"));

            // Initialize AudioPlayer
            audioPlayer = new AudioPlayer(playImage, pauseImage, musicVolume);

            // Update the event handler to use the AudioPlayer's method
            btnMusic.Click += (s, e) => audioPlayer.HandleMusicButtonClick(btnMusic);

            // Initialize colors for navigation buttons
            categoryNavigator = new CategoryNavigator(pnlNav, Color.FromArgb(46, 51, 73), Color.FromArgb(30, 31, 34), this.Master);

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
            // This allows us to drag the program
            FormDragger dragger = new FormDragger();
            dragger.Attach(this);
            AttachDragEventHandlers(this, dragger);

            // Initialize NPCDialogue and start it when the program loads
            npcDialogue = new NPCDialogue(npcdialogue);
            // 35 is characters displaying every 35ms to simulate talking and 10k ms (10 seconds) delay for each phrase
            this.Load += async (s, e) => await npcDialogue.StartDialogue(35, 10000);
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

        private void UpdateNotes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


