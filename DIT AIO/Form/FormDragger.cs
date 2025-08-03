using System;
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
        control.MouseCaptureChanged += Control_MouseCaptureChanged; // Safety for ghost drag
    }

    private void Control_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = ((Control)sender).FindForm().Location;
            ((Control)sender).Capture = true; // Prevent ghost drag
        }
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
        if (e.Button == MouseButtons.Left)
        {
            dragging = false;
            ((Control)sender).Capture = false;
        }
    }

    private void Control_MouseCaptureChanged(object sender, EventArgs e)
    {
        dragging = false; // Reset if Windows releases capture unexpectedly
    }
}
