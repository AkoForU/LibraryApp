using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ShadowPanel : Panel
{
    public int ShadowSize { get; set; } = 10;
    public Color ShadowColor { get; set; } = Color.Gray;
    public int ShadowOpacity { get; set; } = 100; // 0 (fully transparent) to 255 (fully opaque)

    public ShadowPanel()
    {
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        this.BackColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Draw shadow
        DrawShadow(e.Graphics);
    }

    private void DrawShadow(Graphics graphics)
    {
        Rectangle shadowBounds = new Rectangle(ShadowSize, ShadowSize, this.Width - ShadowSize, this.Height - ShadowSize);

        using (GraphicsPath path = CreateShadowPath(shadowBounds))
        {
            using (PathGradientBrush brush = new PathGradientBrush(path))
            {
                brush.CenterColor = Color.FromArgb(ShadowOpacity, ShadowColor);
                brush.SurroundColors = new[] { Color.Transparent };
                brush.CenterPoint = new PointF(this.Width / 2f, this.Height / 2f);

                graphics.FillPath(brush, path);
            }
        }
    }

    private GraphicsPath CreateShadowPath(Rectangle bounds)
    {
        GraphicsPath path = new GraphicsPath();

        path.AddRectangle(bounds);

        return path;
    }
}
