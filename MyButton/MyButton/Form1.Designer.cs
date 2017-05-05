namespace MyButton
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.rectangleRoundButton1 = new ButtonLibrary.RectangleRoundButton();
            this.rectangleButton2 = new ButtonLibrary.RectangleButton();
            this.rectangleButton1 = new ButtonLibrary.EllipseButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rectangleRoundButton1
            // 
            this.rectangleRoundButton1.BottomColor = System.Drawing.SystemColors.Control;
            this.rectangleRoundButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.rectangleRoundButton1.Location = new System.Drawing.Point(346, 47);
            this.rectangleRoundButton1.MouseDownBottomColor = System.Drawing.Color.Gray;
            this.rectangleRoundButton1.MouseDownGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.rectangleRoundButton1.MouseDownTopColor = System.Drawing.Color.Gray;
            this.rectangleRoundButton1.MouseOverBottomColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleRoundButton1.MouseOverGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.rectangleRoundButton1.MouseOverTopColor = System.Drawing.Color.Gray;
            this.rectangleRoundButton1.Name = "rectangleRoundButton1";
            this.rectangleRoundButton1.OutLineColor = System.Drawing.Color.Black;
            this.rectangleRoundButton1.Size = new System.Drawing.Size(160, 38);
            this.rectangleRoundButton1.TabIndex = 2;
            this.rectangleRoundButton1.Text = "rectangleRoundButton1";
            this.rectangleRoundButton1.TextColor = System.Drawing.Color.Black;
            this.rectangleRoundButton1.TopColor = System.Drawing.Color.Gray;
            this.rectangleRoundButton1.UseVisualStyleBackColor = true;
            this.rectangleRoundButton1.Click += new System.EventHandler(this.rectangleRoundButton1_Click);
            // 
            // rectangleButton2
            // 
            this.rectangleButton2.BackColor = System.Drawing.Color.Transparent;
            this.rectangleButton2.BottomColor = System.Drawing.SystemColors.Control;
            this.rectangleButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.rectangleButton2.Location = new System.Drawing.Point(265, 62);
            this.rectangleButton2.MouseDownBottomColor = System.Drawing.Color.Gray;
            this.rectangleButton2.MouseDownGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.rectangleButton2.MouseDownTopColor = System.Drawing.Color.Gray;
            this.rectangleButton2.MouseOverBottomColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleButton2.MouseOverGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.rectangleButton2.MouseOverTopColor = System.Drawing.Color.Gray;
            this.rectangleButton2.Name = "rectangleButton2";
            this.rectangleButton2.OutLineColor = System.Drawing.Color.Linen;
            this.rectangleButton2.Size = new System.Drawing.Size(75, 23);
            this.rectangleButton2.TabIndex = 1;
            this.rectangleButton2.Text = "rectangleButton2";
            this.rectangleButton2.TextColor = System.Drawing.Color.Black;
            this.rectangleButton2.TopColor = System.Drawing.Color.Gray;
            this.rectangleButton2.UseVisualStyleBackColor = false;
            // 
            // rectangleButton1
            // 
            this.rectangleButton1.BottomButtonBackColor = System.Drawing.SystemColors.Control;
            this.rectangleButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.rectangleButton1.Location = new System.Drawing.Point(139, 4);
            this.rectangleButton1.MouseDownBottomColor = System.Drawing.Color.Gray;
            this.rectangleButton1.MouseDownGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.rectangleButton1.MouseDownTopColor = System.Drawing.Color.Gray;
            this.rectangleButton1.MouseOverBottomColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleButton1.MouseOverGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.rectangleButton1.MouseOverTopColor = System.Drawing.Color.DarkGray;
            this.rectangleButton1.Name = "rectangleButton1";
            this.rectangleButton1.OutLine = System.Drawing.Color.White;
            this.rectangleButton1.Radious = 20;
            this.rectangleButton1.Size = new System.Drawing.Size(120, 125);
            this.rectangleButton1.TabIndex = 0;
            this.rectangleButton1.Text = "ellipseButton1";
            this.rectangleButton1.TextColor = System.Drawing.Color.Black;
            this.rectangleButton1.TopButtonBackColor = System.Drawing.Color.DarkGray;
            this.rectangleButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rectangleRoundButton1);
            this.Controls.Add(this.rectangleButton2);
            this.Controls.Add(this.rectangleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonLibrary.EllipseButton rectangleButton1;
        private ButtonLibrary.RectangleButton rectangleButton2;
        private ButtonLibrary.RectangleRoundButton rectangleRoundButton1;
        private System.Windows.Forms.Button button1;
    }
}

