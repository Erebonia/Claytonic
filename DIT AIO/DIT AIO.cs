using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DIT_AIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

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
            //Most recent cache corrupt fix I saw. Verified it works up to 2021 outlook
            runCustomScript(@"\\ditfp1\helpdesk\Microsoft_Office\Outlook Fixes\Outlook Cache Corrupt Fix\OutlookAllVersionsFix\formsCache.bat");
            //From Sid's guide
            runCustomScript(@"\\ditfp1\helpdesk\Microsoft_Office\Outlook Fixes\Outlook Form Issue\Archive Manager Bulletin 15_Sep_2017 - Registry Keys\Outlook 2016\Outlook 2016 - 64 Bit.reg");
        }

        private void Install_ACID_Unsuspend(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Mainframe\Install_ACID_Unsuspend.bat");
        }

        private void Install_ACID_Reset(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Mainframe\Install_ACID_PW_Reset.bat");
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

        private void DIT_Icon(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
