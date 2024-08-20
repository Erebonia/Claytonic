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
        ResetButtonUI(clickedButton.Parent);

        pnlNav.Height = clickedButton.Height;
        pnlNav.Top = clickedButton.Top;
        pnlNav.Left = clickedButton.Left;
        clickedButton.BackColor = activeColor;
    }

    private void ResetButtonUI(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            if (control is Button button)
            {
                button.BackColor = inactiveColor;
            }
        }
    }
}
