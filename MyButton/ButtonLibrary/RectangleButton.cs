using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ButtonLibrary
{
    public class RectangleButton : Button
    {
        #region 变量
        internal Color _bottomColor = Color.Red, _topColor = Color.Green, _textColor = Color.Black, _outlineColor = Color.Black;
        internal Color _mouseOverBottomColor = Color.Gray, _mouseOverTopColor = Color.Green, _mouseDownBottomColor = Color.Gray, _mouseDownTopColor = Color.Green;
        internal bool _MouseOver = false, _MouseDown = false;
        bool isOnPaint = false;
        internal LinearGradientMode _GradientMode = LinearGradientMode.Vertical;
        internal LinearGradientMode _MouseOverGradientMode = LinearGradientMode.Vertical;
        internal LinearGradientMode _MouseDownGradientMode = LinearGradientMode.Vertical;
        #endregion
        #region 属性
        public LinearGradientMode GradientMode
        {
            get { return _GradientMode; }
            set
            {
                this._GradientMode = value;
                this.Invalidate();
            }
        }
        public LinearGradientMode MouseOverGradientMode
        {
            get { return _MouseOverGradientMode; }
            set
            {
                this._MouseOverGradientMode = value;
                this.Invalidate();
            }
        }
        public LinearGradientMode MouseDownGradientMode
        {
            get { return _MouseDownGradientMode; }
            set
            {
                this._MouseDownGradientMode = value;
                this.Invalidate();
            }
        }
        public Color MouseOverTopColor
        {
            get { return _mouseOverTopColor; }
            set
            {
                this._mouseOverTopColor = value;
                this.Invalidate();
            }
        }
        public Color MouseOverBottomColor
        {
            get { return _mouseOverBottomColor; }
            set
            {
                this._mouseOverBottomColor = value;
                this.Invalidate();
            }
        }
        public Color MouseDownTopColor
        {
            get { return _mouseDownTopColor; }
            set
            {
                this._mouseDownTopColor = value;
                this.Invalidate();
            }
        }
        public Color MouseDownBottomColor
        {
            get { return _mouseDownBottomColor; }
            set
            {
                this._mouseDownBottomColor = value;
                this.Invalidate();
            }
        }
        public Color OutLineColor
        {
            get { return _outlineColor; }
            set
            {
                this._outlineColor = value;
                this.Invalidate();
            }
        }

        public Color BottomColor
        {
            get { return _bottomColor; }
            set
            {
                this._bottomColor = value;
                this.Invalidate();
            }
        }
        public Color TopColor
        {
            get { return _topColor; }
            set
            {
                this._topColor = value;
                this.Invalidate();
            }
        }
        public Color TextColor
        {
            get { return _textColor; }
            set
            {
                this._textColor = value;
                this.Invalidate();
            }
        }
        #endregion
        #region 方法
        protected override void OnMouseLeave(EventArgs e)
        {
            _MouseOver = false;
            base.OnMouseLeave(e);
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            _MouseDown = false;
            base.OnMouseUp(mevent);
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            _MouseDown = true;
            base.OnMouseDown(mevent);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            _MouseOver = true;
            base.OnMouseEnter(e);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
            if (isOnPaint)
            {
                return;
            }
            isOnPaint = true;
            try
            {
                Graphics g = pevent.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                LinearGradientBrush linear = new LinearGradientBrush(rect, BottomColor, TopColor, GradientMode);
                Pen mypen = new Pen(OutLineColor, -1);
                GraphicsPath gp = new GraphicsPath();
                float wid = this.Height / 3f;
                wid = 1;

                int width = this.Width - 1;
                int height = this.Height - 1;

                // tl
                gp.AddArc(0, 0, wid, wid, 180, 90);
                // top line
                gp.AddLine(wid, 0, width - wid, 0);
                // tr
                gp.AddArc(width - wid, 0, wid, wid, 270, 90);
                // br
                gp.AddArc(width - wid, height - wid, wid, wid, 0, 90);
                // bottom line
                gp.AddLine(wid, height, width - wid, height);
                // bl
                gp.AddArc(0, height - wid, wid, wid, 90, 90);
                // left line
                gp.AddLine(0, height - wid, 0, wid - wid / 2);

                g.FillPath(linear, gp);
                g.DrawPath(mypen, gp);
                // Brush brush = new SolidBrush(Color.Red);

                if (_MouseOver)
                {
                    linear = new LinearGradientBrush(rect, MouseOverBottomColor, MouseOverTopColor, MouseOverGradientMode);
                    g.FillPath(linear, gp);
                    g.DrawPath(mypen, gp);
                }

                if (_MouseDown)
                {
                    linear = new LinearGradientBrush(rect, MouseDownBottomColor, MouseDownTopColor, MouseDownGradientMode);
                    g.FillPath(linear, gp);
                    g.DrawPath(mypen, gp);
                }

                SolidBrush mybrush = new SolidBrush(TextColor);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                string display = this.Text;
                int amppos = display.IndexOf('&');
                if (amppos != -1)
                    display = display.Remove(amppos, 1);

                g.DrawString(display, this.Font, mybrush, rect, stringFormat);
            }
            catch { }
            isOnPaint = false;
        }
        #endregion
    }
}
