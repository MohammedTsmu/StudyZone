using System.Drawing;
using System.Windows.Forms;

public class CircularProgressBar : Control
{
    public int Progress { get; set; } // Progress percentage (0 to 100)

    public CircularProgressBar()
    {
        this.DoubleBuffered = true; // Reduce flickering

        // Enable support for transparent backgrounds
        this.SetStyle(ControlStyles.UserPaint |
                      ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.OptimizedDoubleBuffer |
                      ControlStyles.ResizeRedraw |
                      ControlStyles.SupportsTransparentBackColor,
                      true);
        this.UpdateStyles();

        // Set the background color to transparent
        this.BackColor = Color.Transparent;
    }


    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        // Define the rectangle for the circle
        Rectangle rect = new Rectangle(10, 10, this.Width - 20, this.Height - 20);

        // Draw the background circle
        using (Pen pen = new Pen(Color.Gray, 10))
        {
            e.Graphics.DrawEllipse(pen, rect);
        }

        // Draw the progress arc
        using (Pen pen = new Pen(Color.Cyan, 10))
        {
            e.Graphics.DrawArc(pen, rect, -90, (float)(360 * Progress / 100));
        }
    }
}
