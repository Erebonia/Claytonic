using System;
using System.Drawing;
using System.Windows.Forms;

public class CategoryNavigator
{
    private Panel pnlNav;
    private Color selectedColor;
    private Color defaultColor;
    private Control masterPanel;

    public CategoryNavigator(Panel pnlNav, Color selectedColor, Color defaultColor, Control masterPanel)
    {
        this.pnlNav = pnlNav;
        this.selectedColor = selectedColor;
        this.defaultColor = defaultColor;
        this.masterPanel = masterPanel;
    }

    public void HandleCategoryClick(object sender, EventArgs e)
    {
        Button clickedButton = (Button)sender;
        string category = clickedButton.Text.Replace(" ", "");

        ResetButtonUI();

        // Hide all category panels initially
        foreach (Control control in masterPanel.Controls)
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
        foreach (Control control in masterPanel.Controls)
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
        UpdateNavigationPanel(clickedButton);
    }

    public void HandleMinimizeClick(object sender, EventArgs e)
    {
        Form form = ((Control)sender).FindForm();
        if (form != null)
        {
            form.WindowState = FormWindowState.Minimized;
        }
    }

    public void HandleCloseClick(object sender, EventArgs e)
    {
        Form form = ((Control)sender).FindForm();
        if (form != null)
        {
            form.Close();
        }
    }

    private void ResetButtonUI()
    {
        foreach (Control control in masterPanel.Controls)
        {
            if (control is Button button)
            {
                button.BackColor = defaultColor;
            }
        }
    }

    private void UpdateNavigationPanel(Button clickedButton)
    {
        pnlNav.Height = clickedButton.Height;
        pnlNav.Top = clickedButton.Top;
        pnlNav.Left = clickedButton.Left;
        clickedButton.BackColor = selectedColor;
    }
}
