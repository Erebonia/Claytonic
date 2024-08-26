using System.Drawing;
using System.Windows.Forms;

public class ButtonNavigator
{
    private Panel pnlNav;
    private Color activeColor;
    private Color inactiveColor;

    public ButtonNavigator(Panel navPanel, Color activeColor, Color inactiveColor)
    {
        pnlNav = navPanel;
        this.activeColor = activeColor;
        this.inactiveColor = inactiveColor;
    }

    public void HandleButtonClick(Button clickedButton)
    {
        // Reset all buttons to inactive color
        ResetButtonUI(clickedButton.Parent);

        // Set the navigation panel to highlight the clicked button
        pnlNav.Height = clickedButton.Height;
        pnlNav.Top = clickedButton.Top;
        pnlNav.Left = clickedButton.Left;

        // Set the clicked button's background color to active color
        clickedButton.BackColor = activeColor;
    }

    private void ResetButtonUI(Control parent)
    {
        // Reset the background color of all buttons to inactive color
        foreach (Control control in parent.Controls)
        {
            if (control is Button button)
            {
                button.BackColor = inactiveColor;
            }
        }
    }
}
