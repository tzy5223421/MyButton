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
    public class RectangleRoundButton : Button
    {
        #region 变量
        internal Color _BottomColor = Color.Blue, _TopColor = Color.Gray, _TextColor = Color.Black, _OutLineColor = Color.Black, _MouseOverBottomColor = Color.Gray, _MouseOverTopColor = Color.Blue;
        internal Color _MouseDownBottomColor = Color.Green, _MouseDownTopColor = Color.Gray;
        internal int _TextSize = 12;
        internal bool isOnPaint = false;
        internal bool MouseDown = false;
        internal bool MouseOver = false;
        #endregion
        #region 属性
        public Color BottomColor
        {
            get { return _BottomColor; }
            set
            {
                this._BottomColor = value;
                this.Invalidate();
            }
        }
        public Color TopColor
        {
            get { return _TopColor; }
            set
            {
                this._TopColor = value;
                this.Invalidate();
            }
        }
        public Color OutLineColor
        {
            get { return _OutLineColor; }
            set
            {
                this._OutLineColor = value;
                this.Invalidate();
            }
        }
        public Color TextColor
        {
            get { return _TextColor; }
            set
            {
                this._TextColor = value;
                this.Invalidate();
            }
        }
        public Color MouseOverBottomColor
        {
            get { return _MouseOverBottomColor; }
            set
            {
                this._MouseOverBottomColor = value;
                this.Invalidate();
            }
        }
        public Color MouseOverTopColor
        {
            get { return _MouseOverTopColor; }
            set
            {
                this._MouseOverTopColor = value;
                this.Invalidate();
            }
        }
        public Color MouseDownBottomColor
        {
            get { return _MouseDownBottomColor; }
            set
            {
                this._MouseDownBottomColor = value;
                this.Invalidate();
            }
        }
        public Color MouseDownTopColor
        {
            get { return _MouseDownTopColor; }
            set
            {
                this._MouseDownTopColor = value;
                this.Invalidate();
            }
        }
        #endregion
        #region 方法
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            MouseDown = true;
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            MouseOver = true;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            MouseOver = false;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            MouseDown = false;
            base.OnMouseUp(mevent);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            // base.OnPaint(pevent);
            base.OnPaintBackground(pevent);
            if (isOnPaint)
            {
                return;
            }
            isOnPaint = true;
            try
            {
                Graphics g = pevent.Graphics;
                //    DrawRectRound(g, 0, 0, this.Width - 5, this.Height - 5, 2, Color.Black, 1);
                GraphicsPath gp = DrawRectRountPath(g, 0, 0, this.Width - 1, this.Height - 1, 2, Color.WhiteSmoke, 1, Color.Red, Color.Green);

                if (MouseOver)
                {
                    LinearGradientBrush linear = new LinearGradientBrush(this.ClientRectangle, Color.Gray, Color.Green, LinearGradientMode.Vertical);
                    g.FillPath(linear, gp);
                }
                if (MouseDown)
                {
                    LinearGradientBrush linear = new LinearGradientBrush(this.ClientRectangle, Color.Green, Color.Green, LinearGradientMode.Vertical);
                    g.FillPath(linear, gp);
                }

                SolidBrush mybrush = new SolidBrush(TextColor);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                string display = this.Text;
                int amppos = display.IndexOf('&');
                if (amppos != -1)
                    display = display.Remove(amppos, 1);

                g.DrawString(display, this.Font, mybrush, this.ClientRectangle, stringFormat);
            }
            catch (Exception)
            {

                throw;
            }
            isOnPaint = false;
        }
        private void DrawRectRound(Graphics g, float x, float y, float width, float height, float arcSize, Color lineColor, float lineWidth)
        {
            //圆角矩形的半宽和半高
            float hew = width / arcSize / 2 - 1;
            float heh = height / arcSize / 2 - 1;
            //圆角修正
            if (Math.Abs(hew - heh) > 10)
            {
                hew = heh = hew > heh ? heh : hew;
            }
            //边线修正
            int lineMove = 1;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Pen mypen = new Pen(lineColor, lineWidth);

            //画圆角
            g.DrawArc(mypen, x, y, 2 * hew, 2 * heh, 180, 90);

            g.DrawArc(mypen, x + width - 2 * hew, y, 2 * hew, 2 * heh, 270, 90);

            g.DrawArc(mypen, x + width - 2 * hew, y + height - 2 * heh, 2 * hew, 2 * heh, 0, 90);

            g.DrawArc(mypen, x, y + height - 2 * heh, 2 * hew, 2 * heh, 90, 90);

            //画直线连接四个圆
            g.DrawLine(mypen, x + hew - lineMove, y, x + width - hew + lineMove, y);

            g.DrawLine(mypen, x + width, y + heh - lineMove, x + width, y + height - heh + lineMove);

            g.DrawLine(mypen, x + width - hew + lineMove, y + height, x + hew - lineMove, y + height);

            g.DrawLine(mypen, x, y + height - heh + lineMove, x, y + heh - lineMove);
        }

        private GraphicsPath DrawRectRountPath(Graphics g, float x, float y, float width, float height, float arcSize, Color lineColor, float lineWidth, Color BottomColor, Color TopColor)
        {
            //渐变
            LinearGradientBrush linearbrush = new LinearGradientBrush(this.ClientRectangle, BottomColor, TopColor, LinearGradientMode.Vertical);
            //圆角矩形的半宽和半高
            float hew = width / arcSize / 2 - 1;
            float heh = height / arcSize / 2 - 1;
            //圆角修正
            if (Math.Abs(hew - heh) > 10)
            {
                hew = heh = hew > heh ? heh : hew;
            }
            //边线修正
            int lineMove = 1;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Pen mypen = new Pen(lineColor, lineWidth);

            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(x, y, 2 * hew, 2 * heh, 180, 90);//绘制左上角圆弧
            gp.AddLine(x + hew - lineMove, y, x + width - hew + lineMove, y);//顶部横线

            gp.AddArc(x + width - 2 * hew, y, 2 * hew, 2 * heh, 270, 90);//绘制左下角圆弧
            gp.AddLine(x + width, y + heh - lineMove, x + width, y + height - heh + lineMove);//右侧竖线

            gp.AddArc(x + width - 2 * hew, y + height - 2 * heh, 2 * hew, 2 * heh, 0, 90);//绘制右下角圆弧
            gp.AddLine(x + width - hew + lineMove, y + height, x + hew - lineMove, y + height);//底部横线

            gp.AddArc(x, y + height - 2 * heh, 2 * hew, 2 * heh, 90, 90);//绘制右上角圆弧
            gp.AddLine(x, y + height - heh + lineMove, x, y + heh - lineMove);//左侧竖线

            //  SolidBrush brush = new SolidBrush(fillColor);

            g.DrawPath(mypen, gp);
            g.FillPath(linearbrush, gp);

            return gp;
        }
        #endregion
    }
}
