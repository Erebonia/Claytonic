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
        //Audio Player
        private AudioPlayer audioPlayer; 
        private Image playImage;
        private Image pauseImage;

        //UI Handler
        private CategoryNavigator categoryNavigator;

        public Runetonic()
        {
            //For designer.cs to instantiate
            InitializeComponent();

            // Initialize the images for our music buttons.
            playImage = Image.FromStream(ResourceHelper.GetResourceStream("DIT_AIO.Resources.playing.png"));
            pauseImage = Image.FromStream(ResourceHelper.GetResourceStream("DIT_AIO.Resources.paused.png"));

            // Initialize colors for navigation buttons
            categoryNavigator = new CategoryNavigator(pnlNav, Color.FromArgb(46, 51, 73), Color.FromArgb(30, 31, 34), this.Master);

            // Initialize AudioPlayer
            audioPlayer = new AudioPlayer();
            audioPlayer.LoadAudio("DIT_AIO.Resources.claytonic_music.wav");

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
            //This allows us to drag the program
            FormDragger dragger = new FormDragger();
            dragger.Attach(this);
            AttachDragEventHandlers(this, dragger); 

            // Start the NPC dialogue automatically when the program starts
            this.Load += (s, e) => NPC_Dialogue(s, e);
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


        private string[] phrases = { "Hover over buttons to view their description!", "For any issues with the tool please contact Bao Nguyen from DIT Helpdesk!", "Welcome to Claytonic. A program dedicated to helpdesk technicians :)" };
        private int currentPhraseIndex = -1; // Initialize to -1 to indicate no previous phrase

        private async void NPC_Dialogue(object sender, EventArgs e)
        {
            await ShowPhrasesOneByOne(35, 10000); // 25 ms delay per character (talking), 3000 ms delay between phrases
        }

        private async Task ShowPhrasesOneByOne(int charDelay, int phraseDelay)
        {
            for (int i = 0; i < phrases.Length; i++)
            {
                string phrase = GetRandomPhrase();
                await ShowTextOneCharacterAtATime(phrase, charDelay); // Show each phrase with typewriter effect
                await Task.Delay(phraseDelay); // Wait for 3 seconds (3000 ms) before showing the next phrase
            }
        }

        private string GetRandomPhrase()
        {
            Random random = new Random();
            int newPhraseIndex;

            do
            {
                newPhraseIndex = random.Next(phrases.Length);
            } while (newPhraseIndex == currentPhraseIndex); // Ensure the new phrase is not the same as the previous one

            currentPhraseIndex = newPhraseIndex; // Update the current phrase index
            return phrases[currentPhraseIndex];
        }

        private async Task ShowTextOneCharacterAtATime(string text, int delay)
        {
            npcdialogue.Text = ""; // Clear the Label to start the typewriter effect

            foreach (char c in text)
            {
                npcdialogue.Text += c.ToString(); // Append text to the Label
                await Task.Delay(delay); // Pause for the delay time without blocking the UI
            }
        }


    }
}


