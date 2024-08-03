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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Data Migration Script\00Restore - User Profile.bat");
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Net user
            runCustomScript(@"\\ditfp1\helpdesk\BN\Technician_Tools\netuser.bat");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Copy unsuspend macro to PC
            runCustomScript(@"\\ditfp1\helpdesk\BN\Mainframe\Install_ACID_Unsuspend.bat");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Install PW Reset macro to PC
            runCustomScript(@"\\ditfp1\helpdesk\BN\Mainframe\Install_ACID_PW_Reset.bat");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Data Migration Script\00Backup - User Profile.bat");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Ping IP 
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            // SFC Scan
            string sfcCommand = "sfc /scannow";

            // Initialize a new Process to run the command
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/C {sfcCommand}";
            process.StartInfo.Verb = "runas"; // This runs the command as an administrator
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal; // Show the command prompt window

            // Start the process and wait for it to exit
            process.Start();
            process.WaitForExit();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Data Migration Script\22backup_printers.bat");
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

        private void button8_Click(object sender, EventArgs e)
        {
            runCustomScript(@"\\ditfp1\helpdesk\BN\Data Migration Script\22restore_printers.bat");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Disables all firewall states + notification
            runCustomScript(@"\\ditfp1\helpdesk\BN\Firewall\firewall-notifications-off.reg");
            runCustomScript(@"\\ditfp1\helpdesk\BN\Firewall\firewall-off.bat");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Scanning
            runCustomScript(@"\\Ditfp1\helpdesk\PaperPort\CCHSCAN1\ImageRetrieverFix5.cmd");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //E Signature
            runCustomScript(@"\\ditfp1\helpdesk\!SHORTCUTS!\checkCert.bat");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Blank Login cmd
            runCustomScript(@"\\ditfp1\helpdesk\!SHORTCUTS!\BlankLogin.cmd");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Open all the folder with guides about mainframe
            runCustomScript(@"\\Ditfp1\helpdesk\BN\Mainframe");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //DISM
        }
    }
}
