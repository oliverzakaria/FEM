using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static ServiceStack.Diagnostics.Events;

namespace GradientPanel
{
    public partial class GradientPanel : System.Windows.Forms.Panel
    {

        //// member variables
        System.Drawing.Color mStartColor;
        System.Drawing.Color mEndColor;
        private System.Windows.Forms.Panel panel;

        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusColor = Color.HotPink;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private bool isFocused = false;

        private int borderRadius = 0;

        public GradientPanel()
        {
            InitializeComponent();
            //PaintGradient();
        }




        //public System.Drawing.Color PageStartColor
        //{
        //    get
        //    {
        //        return mStartColor;
        //    }
        //    set
        //    {
        //        mStartColor = value;
        //        PaintGradient();
        //    }
        //}


        //public System.Drawing.Color PageEndColor
        //{
        //    get
        //    {
        //        return mEndColor;
        //    }
        //    set
        //    {
        //        mEndColor = value;
        //        PaintGradient();
        //    }
        //}


        //private void PaintGradient()
        //{
        //    //using (LinearGradientBrush brush = new LinearGradientBrush(
        //    //   this.ClientRectangle,
        //    //   startColor,
        //    //   endColor,
        //    //   LinearGradientMode.Vertical))
        //    //{
        //    //    // Fill the background of the form with the gradient brush
        //    //    e.Graphics.FillRectangle(brush, this.ClientRectangle);
        //    //}

        //    System.Drawing.Drawing2D.LinearGradientBrush gradBrush;
        //    gradBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(0, 0),
        //    new Point(this.Width, this.Height), PageStartColor, PageEndColor;

        //    Bitmap bmp = new Bitmap(this.Width, this.Height);

        //    Graphics g = Graphics.FromImage(bmp);
        //    g.FillRectangle(gradBrush, new Rectangle(0, 0, this.Width, this.Height));
        //    this.BackgroundImage = bmp;
        //    this.BackgroundImageLayout = ImageLayout.Stretch;


        //}

       

            public Color BorderColor
            {
                get { return borderColor; }
                set
                {
                    borderColor = value;
                    this.Invalidate();
                }
            }

            public Color BorderFocusColor
            {
                get { return borderFocusColor; }
                set { borderFocusColor = value; }
            }

            public int BorderSize
            {
                get { return borderSize; }
                set
                {
                    if (value >= 1)
                    {
                        borderSize = value;
                        this.Invalidate();
                    }
                }
            }

            public bool UnderlinedStyle
            {
                get { return underlinedStyle; }
                set
                {
                    underlinedStyle = value;
                    this.Invalidate();
                }
            }

            public override Color ForeColor
            {
                get { return base.ForeColor; }
                set
                {
                    base.ForeColor = value;
                    panel.ForeColor = value;
                }
            }


            public int BorderRadius
            {
                get { return borderRadius; }
                set
                {
                    if (value >= 0)
                    {
                        borderRadius = value;
                        this.Invalidate();//Redraw control
                    }
                }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                Graphics graph = e.Graphics;

                if (borderRadius > 1)//Rounded TextBox
                {
                    //-Fields
                    var rectBorderSmooth = this.ClientRectangle;
                    var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                    int smoothSize = borderSize > 0 ? borderSize : 1;

                    using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                    using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                    using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        //-Drawing
                        this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                        if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                        graph.SmoothingMode = SmoothingMode.AntiAlias;
                        penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                        if (isFocused) penBorder.Color = borderFocusColor;

                        if (underlinedStyle) //Line Style
                        {
                            //Draw border smoothing
                            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                            //Draw border
                            graph.SmoothingMode = SmoothingMode.None;
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else //Normal Style
                        {
                            //Draw border smoothing
                            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                            //Draw border
                            graph.DrawPath(penBorder, pathBorder);
                        }
                    }
                }
            }
            private void SetTextBoxRoundedRegion()
            {
                GraphicsPath pathTxt;


                pathTxt = GetFigurePath(panel.ClientRectangle, borderSize * 2);
                panel.Region = new Region(pathTxt);

                pathTxt.Dispose();
            }
            private GraphicsPath GetFigurePath(Rectangle rect, int radius)
            {
                GraphicsPath path = new GraphicsPath();
                float curveSize = radius * 2F;

                path.StartFigure();
                path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
                path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
                path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
                path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
                path.CloseFigure();
                return path;
            }
        }
    
}