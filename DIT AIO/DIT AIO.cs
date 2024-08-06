using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DIT_AIO
{
    public partial class Runetonic : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Runetonic()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(28, 28, 18);

            // Attach event handlers
            btnDashboard.Click += HandleCategoryClick;
            btnDataRecovery.Click += HandleCategoryClick;
            btnDiagnostics.Click += HandleCategoryClick;
            btnSystemSetup.Click += HandleCategoryClick;
            btnMainframe.Click += HandleCategoryClick;
            btnSettings.Click += HandleCategoryClick;

            // Ensure Home tab is selected when starting the program
            HandleCategoryClick(btnDashboard, EventArgs.Empty);

            // Attach mouse event handlers for dragging the form
            AttachDragEventHandlers(this);
            AttachDragEventHandlers(pnlNav);

            // Attach mouse event handlers to other controls if necessary
            // AttachDragEventHandlers(someOtherControl);
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void AttachDragEventHandlers(Control control)
        {
            control.MouseDown += new MouseEventHandler(Form_MouseDown);
            control.MouseMove += new MouseEventHandler(Form_MouseMove);
            control.MouseUp += new MouseEventHandler(Form_MouseUp);

            foreach (Control child in control.Controls)
            {
                AttachDragEventHandlers(child);
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
            // Most recent cache corrupt fix I saw. Verified it works up to 2021 outlook
            runCustomScript(@"\\ditfp1\helpdesk\Microsoft_Office\Outlook Fixes\Outlook Cache Corrupt Fix\OutlookAllVersionsFix\formsCache.bat");
            // From Sid's guide
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

        private void reset_button_ui()
        {
            btnDashboard.BackColor = Color.FromArgb(30,31,34);
            btnDataRecovery.BackColor = Color.FromArgb(30, 31, 34);
            btnDiagnostics.BackColor = Color.FromArgb(30, 31, 34);
            btnSystemSetup.BackColor = Color.FromArgb(30, 31, 34);
            btnMainframe.BackColor = Color.FromArgb(30, 31, 34);
            btnSettings.BackColor = Color.FromArgb(30, 31, 34);
        }

        private void HandleButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            reset_button_ui();

            pnlNav.Height = clickedButton.Height;
            pnlNav.Top = clickedButton.Top;
            pnlNav.Left = clickedButton.Left;
            clickedButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void HandleCategoryClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string category = clickedButton.Text.Replace(" ", "");

            // Hide all category panels initially
            foreach (Control control in Master.Controls)
            {
                if (control is Panel panel)
                {
                    panel.Visible = false;
                    // Hide all buttons within each panel
                    foreach (Control child in panel.Controls)
                    {
                        if (child is Button)
                        {
                            child.Visible = false;
                        }
                    }
                }
            }

            // Show the panel based on the selected category
            foreach (Control control in Master.Controls)
            {
                if (control is Panel panel && panel.Tag != null && panel.Tag.ToString() == category)
                {
                    panel.Visible = true;
                    // Show all buttons within the selected panel
                    foreach (Control child in panel.Controls)
                    {
                        if (child is Button)
                        {
                            child.Visible = true;
                        }
                    }
                }
            }

            // Update navigation panel position and color
            HandleButtonClick(sender, e);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
