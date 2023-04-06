using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSLTT
{
   
        public class RoundedPanel : Panel
        {
            private float _thickness = 5;
            public float Thickness
            {
                get
                {
                    return _thickness;
                }
                set
                {
                    _thickness = value;
                    _pen = new Pen(_borderColor, Thickness);
                    Invalidate();
                }
            }

            private Color _borderColor = Color.White;
            public Color BorderColor
            {
                get
                {
                    return _borderColor;
                }
                set
                {
                    _borderColor = value;
                    _pen = new Pen(_borderColor, Thickness);
                    Invalidate();
                }
            }

            private int _radius = 20;
            public int Radius
            {
                get
                {
                    return _radius;
                }
                set
                {
                    _radius = value;
                    Invalidate();
                }
            }

            private Pen _pen;

            public RoundedPanel() : base()
            {
                _pen = new Pen(BorderColor, Thickness);
                DoubleBuffered = true;
            }
            private Rectangle GetLeftUpper(int e)
            {
                return new Rectangle(0, 0, e, e);
            }
            private Rectangle GetRightUpper(int e)
            {
                return new Rectangle(Width - e, 0, e, e);
            }
            private Rectangle GetRightLower(int e)
            {
                return new Rectangle(Width - e, Height - e, e, e);
            }
            private Rectangle GetLeftLower(int e)
            {
                return new Rectangle(0, Height - e, e, e);
            }

            private void ExtendedDraw(PaintEventArgs e)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath path = new GraphicsPath();
                path.StartFigure();
                path.AddArc(GetLeftUpper(Radius), 180, 90);
                path.AddLine(Radius, 0, Width - Radius, 0);
                path.AddArc(GetRightUpper(Radius), 270, 90);
                path.AddLine(Width, Radius, Width, Height - Radius);
                path.AddArc(GetRightLower(Radius), 0, 90);
                path.AddLine(Width - Radius, Height, Radius, Height);
                path.AddArc(GetLeftLower(Radius), 90, 90);
                path.AddLine(0, Height - Radius, 0, Radius);
                path.CloseFigure();
                Region = new Region(path);
            }
            private void DrawSingleBorder(Graphics graphics)
            {
                graphics.DrawArc(_pen, new Rectangle(0, 0, Radius, Radius), 180, 90);
                graphics.DrawArc(_pen, new Rectangle(Width - Radius - 1, -1, Radius, Radius), 270, 90);
                graphics.DrawArc(_pen, new Rectangle(Width - Radius - 1, Height - Radius - 1, Radius, Radius), 0, 90);
                graphics.DrawArc(_pen, new Rectangle(0, Height - Radius - 1, Radius, Radius), 90, 90);
                graphics.DrawRectangle(_pen, 0.0f, 0.0f, (float)Width - 1.0f, (float)Height - 1.0f);
            }
            private void Draw3DBorder(Graphics graphics)
            {
                DrawSingleBorder(graphics);
            }
            private void DrawBorder(Graphics graphics)
            {
                DrawSingleBorder(graphics);
            }
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                ExtendedDraw(e);
                DrawBorder(e.Graphics);
            }
        
    }
}