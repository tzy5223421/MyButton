using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ButtonLibrary
{
    public class RectangleRoundButton : Button
    {
        #region 变量
        internal Color _BottomColor = Color.Blue, _TopColor = Color.Gray, _TextColor = Color.Black, _OutLineColor = Color.Black, _MouseOverBottomColor = Color.Gray, _MouseOverTopColor = Color.Blue;
        internal Color _MouseDownBottomColor = Color.Green, _MouseDownTopColor = Color.Gray;
        internal int _TextSize = 12;
        internal bool isOnPaint = false;
        internal bool _MouseDown = false;
        internal bool _MouseOver = false;
        internal LinearGradientMode _GradientMode = LinearGradientMode.Vertical;
        internal LinearGradientMode _MouseDownGradientMode = LinearGradientMode.Vertical;
        internal LinearGradientMode _MouseOverGradientMode = LinearGradientMode.Vertical;
        #endregion
        #region 属性

        [Description("圆角矩形鼠标按下时颜色渐变方式"), Category("Appearance")]
        public LinearGradientMode MouseDownGradientMode
        {
            get { return this._MouseDownGradientMode; }
            set
            {
                this._MouseDownGradientMode = value;
                this.Invalidate();
            }
        }

        [Description("圆角矩形鼠标经过时颜色渐变方式"), Category("Appearance")]
        public LinearGradientMode MouseOverGradientMode
        {
            get { return this._MouseOverGradientMode; }
            set
            {
                this._MouseOverGradientMode = value;
                this.Invalidate();
            }
        }
        [Description("圆角矩形按钮正常情况下颜色渐变方式"), Category("Appearance")]
        public LinearGradientMode GradientMode
        {
            get { return this._GradientMode; }
            set
            {
                this._GradientMode = value;
                this.Invalidate();
            }
        }

        [Description("圆角矩形按钮正常情况下底部颜色"), Category("Appearance")]
        public Color BottomColor
        {
            get { return _BottomColor; }
            set
            {
                this._BottomColor = value;
                this.Invalidate();
            }
        }

        [Description("圆角矩形按钮正常情况下顶部颜色"), Category("Appearance")]
        public Color TopColor
        {
            get { return _TopColor; }
            set
            {
                this._TopColor = value;
                this.Invalidate();
            }
        }

        [Description("圆角矩形按钮边框颜色"), Category("Appearance")]
        public Color OutLineColor
        {
            get { return _OutLineColor; }
            set
            {
                this._OutLineColor = value;
                this.Invalidate();
            }
        }

        [Description("圆角矩形按钮文本颜色"), Category("Appearance")]
        public Color TextColor
        {
            get { return _TextColor; }
            set
            {
                this._TextColor = value;
                this.Invalidate();
            }
        }

        [Description("圆角矩形按钮鼠标经过底部颜色")]
        public Color MouseOverBottomColor
        {
            get { return _MouseOverBottomColor; }
            set
            {
                this._MouseOverBottomColor = value;
                this.Invalidate();
            }
        }

        [Description("圆角矩形按钮鼠标经过顶部颜色"), Category("Appearance")]
        public Color MouseOverTopColor
        {
            get { return _MouseOverTopColor; }
            set
            {
                this._MouseOverTopColor = value;
                this.Invalidate();
            }
        }

        [Description("圆角矩形按钮鼠标按下底部颜色"), Category("Appearance")]
        public Color MouseDownBottomColor
        {
            get { return _MouseDownBottomColor; }
            set
            {
                this._MouseDownBottomColor = value;
                this.Invalidate();
            }
        }

        [Description("圆角矩形按钮鼠标按下顶部颜色"), Category("Appearance")]
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
        /// <summary>
        /// 按键事件，未修改
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
        /// <summary>
        /// 鼠标按下重写
        /// </summary>
        /// <param name="mevent"></param>
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            _MouseDown = true;
            base.OnMouseDown(mevent);
        }
        /// <summary>
        /// 鼠标触发事件重写
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseEnter(EventArgs e)
        {
            _MouseOver = true;
            base.OnMouseEnter(e);
        }
        /// <summary>
        /// 鼠标离开事件重写
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(EventArgs e)
        {
            _MouseOver = false;
            base.OnMouseLeave(e);
        }
        /// <summary>
        /// 鼠标按键松开事件重写
        /// </summary>
        /// <param name="mevent"></param>
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            _MouseDown = false;
            base.OnMouseUp(mevent);
        }
        /// <summary>
        /// 重绘Button
        /// </summary>
        /// <param name="pevent"></param>
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
                GraphicsPath gp = DrawRectRountPath(g, 0, 0, this.Width - 1, this.Height - 1, 2, OutLineColor, 1, BottomColor, TopColor);

                if (_MouseOver)
                {
                    LinearGradientBrush linear = new LinearGradientBrush(this.ClientRectangle, MouseOverBottomColor, MouseOverTopColor, MouseOverGradientMode);
                    g.FillPath(linear, gp);
                }
                if (_MouseDown)
                {
                    LinearGradientBrush linear = new LinearGradientBrush(this.ClientRectangle, MouseDownBottomColor, MouseDownTopColor, MouseDownGradientMode);
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
        /// <summary>
        /// 绘制圆角矩形
        /// </summary>
        /// <param name="g"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="arcSize"></param>
        /// <param name="lineColor"></param>
        /// <param name="lineWidth"></param>
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
        /// <summary>
        /// 绘制圆角矩形路径并填充
        /// </summary>
        /// <param name="g"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="arcSize"></param>
        /// <param name="lineColor"></param>
        /// <param name="lineWidth"></param>
        /// <param name="BottomColor"></param>
        /// <param name="TopColor"></param>
        /// <returns></returns>
        private GraphicsPath DrawRectRountPath(Graphics g, float x, float y, float width, float height, float arcSize, Color lineColor, float lineWidth, Color BottomColor, Color TopColor)
        {
            //渐变
            LinearGradientBrush linearbrush = new LinearGradientBrush(this.ClientRectangle, BottomColor, TopColor, GradientMode);
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
