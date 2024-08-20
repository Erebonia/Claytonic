using System.Drawing;
using System.Windows.Forms;

public class FormDragger
{
    private bool dragging = false;
    private Point dragCursorPoint;
    private Point dragFormPoint;

    public void Attach(Control control)
    {
        control.MouseDown += Control_MouseDown;
        control.MouseMove += Control_MouseMove;
        control.MouseUp += Control_MouseUp;
    }

    private void Control_MouseDown(object sender, MouseEventArgs e)
    {
        dragging = true;
        dragCursorPoint = Cursor.Position;
        dragFormPoint = ((Control)sender).FindForm().Location;
    }

    private void Control_MouseMove(object sender, MouseEventArgs e)
    {
        if (dragging)
        {
            Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
            ((Control)sender).FindForm().Location = Point.Add(dragFormPoint, new Size(diff));
        }
    }

    private void Control_MouseUp(object sender, MouseEventArgs e)
    {
        dragging = false;
    }
}
