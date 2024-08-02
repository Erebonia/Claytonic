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

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

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

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

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

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
