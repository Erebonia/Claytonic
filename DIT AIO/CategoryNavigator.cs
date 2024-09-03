using System;
using System.Drawing;
using System.Windows.Forms;

public class CategoryNavigator
{
    private ButtonNavigator buttonNavigator;
    private Control masterPanel;

    public CategoryNavigator(Panel pnlNav, Color selectedColor, Color defaultColor, Control masterPanel)
    {
        this.buttonNavigator = new ButtonNavigator(pnlNav, selectedColor, defaultColor);
        this.masterPanel = masterPanel;
    }

    public void HandleCategoryClick(object sender, EventArgs e)
    {
        if (sender is Button clickedButton)
        {
            string category = clickedButton.Text.Replace(" ", "");

            // Reset and highlight the clicked button
            buttonNavigator.HandleButtonClick(clickedButton);

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
        }
    }

    public void HandleMinimizeClick(object sender, EventArgs e)
    {
        var form = ((Control)sender).FindForm();
        form.WindowState = FormWindowState.Minimized;
    }

    public void HandleCloseClick(object sender, EventArgs e)
    {
        var form = ((Control)sender).FindForm();
        form.Close();
    }

    public void HandleMaximizeClick(object sender, EventArgs e)
    {
        var form = ((Control)sender).FindForm();

        if (form.WindowState == FormWindowState.Maximized)
        {
            form.WindowState = FormWindowState.Normal;
        }
        else
        {
            form.WindowState = FormWindowState.Maximized;
        }

    }





}
