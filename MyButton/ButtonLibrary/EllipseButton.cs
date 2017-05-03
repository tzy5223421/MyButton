using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;

namespace ButtonLibrary
{
    public class EllipseButton : Button
    {
        internal int _Radious = 60;
        bool _mouseover = false;
        bool _mousedown = false;
        internal Color _topbuttonback = Color.Gray, _bottombuttonback = Color.Red, _textColor = Color.Black, _outline = Color.White, _mouseovercolor = Color.FromArgb(73, 0x2b, 0x3a, 0x03), _mosuedowncolor = Color.LawnGreen;
        bool isOnPaint = false;
        public EllipseButton()
        {
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            _mousedown = true;
            base.OnMouseDown(mevent);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            _mouseover = false;
            base.OnMouseLeave(e);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            _mouseover = true;
            base.OnMouseEnter(e);
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            _mousedown = false;
            base.OnMouseUp(mevent);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
            //   this.Size = new Size(_Radious - 1, _Radious - 1);
            if (isOnPaint)
            {
                return;
            }
            isOnPaint = true;
            try
            {
                Graphics g = pevent.Graphics;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                Rectangle outside = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                LinearGradientBrush linear = new LinearGradientBrush(outside, TopButtonBackColor, BottomButtonBackColor, LinearGradientMode.Vertical);
                Pen pen = new Pen(OutLine, -1);
                //GraphicsPath outline = new GraphicsPath();
                //float wid = this.Height / 3f;

                //wid = 1;

                //int width = this.Width - 1;
                //int height = this.Height - 1;

                // tl
                //outline.AddArc(0, 0, wid, wid, 180, 90);
                //// top line
                //outline.AddLine(wid, 0, width - wid, 0);
                //// tr
                //outline.AddArc(width - wid, 0, wid, wid, 270, 90);
                //// br
                //outline.AddArc(width - wid, height - wid, wid, wid, 0, 90);
                //// bottom line
                //outline.AddLine(wid, height, width - wid, height);
                //// bl
                //outline.AddArc(0, height - wid, wid, wid, 90, 90);
                //// left line
                //outline.AddLine(0, height - wid, 0, wid - wid / 2);

                //g.FillPath(linear, outline);

                // g.DrawPath(pen, outline);
                g.DrawEllipse(pen, outside);
                //  Brush brush = new SolidBrush(Color.Red);
                g.FillEllipse(linear, outside);

                SolidBrush mybrush = new SolidBrush(TextColor);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                if (_mouseover)
                {
                    LinearGradientBrush linear_over = new LinearGradientBrush(outside, _mouseovercolor, _mouseovercolor, LinearGradientMode.Vertical);
                    g.FillEllipse(linear_over, outside);
                }
                if (_mousedown)
                {
                    LinearGradientBrush linear_over = new LinearGradientBrush(outside, _mosuedowncolor, _mosuedowncolor, LinearGradientMode.Vertical);
                    g.FillEllipse(linear_over, outside);
                }

                string display = this.Text;
                int amppos = display.IndexOf('&');
                if (amppos != -1)
                    display = display.Remove(amppos, 1);

                g.DrawString(display, this.Font, mybrush, outside, stringFormat);
            }
            catch (Exception)
            {

                throw;
            }
            isOnPaint = false;
            //  base.OnPaint(pevent);
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
        public Color MouseOverColor
        {
            get { return _mouseovercolor; }
            set
            {
                this._mouseovercolor = value;
                this.Invalidate();
            }
        }
        public Color MouseDownColor
        {
            get { return _mosuedowncolor; }
            set
            {
                this._mosuedowncolor = value;
                this.Invalidate();
            }
        }
        public int Radious
        {
            get { return _Radious; }
            set
            {
                this._Radious = value;
                this.Size = new Size(_Radious - 1, _Radious - 1);
                this.Invalidate();
            }
        }
        public Color OutLine
        {
            get { return _outline; }
            set
            {
                _outline = value;
                this.Invalidate();
            }
        }
        public Color TopButtonBackColor
        {
            get { return _topbuttonback; }
            set
            {
                _topbuttonback = value;
                this.Invalidate();
            }
        }
        public Color BottomButtonBackColor
        {
            get { return _bottombuttonback; }
            set
            {
                _bottombuttonback = value;
                this.Invalidate();
            }
        }
        public Color TextColor
        {
            get { return _textColor; }
            set
            {
                _textColor = value;
                this.Invalidate();
            }
        }
    }
}
