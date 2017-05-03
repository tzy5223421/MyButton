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
            this.rectangleRoundButton1 = new ButtonLibrary.RectangleRoundButton();
            this.rectangleButton2 = new ButtonLibrary.RectangleButton();
            this.rectangleButton1 = new ButtonLibrary.EllipseButton();
            this.SuspendLayout();
            // 
            // rectangleRoundButton1
            // 
            this.rectangleRoundButton1.BottomColor = System.Drawing.Color.Blue;
            this.rectangleRoundButton1.Location = new System.Drawing.Point(265, 125);
            this.rectangleRoundButton1.MouseDownBottomColor = System.Drawing.Color.Green;
            this.rectangleRoundButton1.MouseDownTopColor = System.Drawing.Color.Gray;
            this.rectangleRoundButton1.MouseOverBottomColor = System.Drawing.Color.Gray;
            this.rectangleRoundButton1.MouseOverTopColor = System.Drawing.Color.Blue;
            this.rectangleRoundButton1.Name = "rectangleRoundButton1";
            this.rectangleRoundButton1.OutLineColor = System.Drawing.Color.Black;
            this.rectangleRoundButton1.Size = new System.Drawing.Size(160, 38);
            this.rectangleRoundButton1.TabIndex = 2;
            this.rectangleRoundButton1.Text = "rectangleRoundButton1";
            this.rectangleRoundButton1.TextColor = System.Drawing.Color.Black;
            this.rectangleRoundButton1.TopColor = System.Drawing.Color.Gray;
            this.rectangleRoundButton1.UseVisualStyleBackColor = true;
            // 
            // rectangleButton2
            // 
            this.rectangleButton2.BackColor = System.Drawing.Color.Transparent;
            this.rectangleButton2.BottomColor = System.Drawing.Color.Gray;
            this.rectangleButton2.Location = new System.Drawing.Point(350, 51);
            this.rectangleButton2.MouseDownColor = System.Drawing.Color.Green;
            this.rectangleButton2.MouseOverColor = System.Drawing.Color.Gray;
            this.rectangleButton2.Name = "rectangleButton2";
            this.rectangleButton2.OutLineColor = System.Drawing.Color.Linen;
            this.rectangleButton2.Size = new System.Drawing.Size(75, 23);
            this.rectangleButton2.TabIndex = 1;
            this.rectangleButton2.Text = "rectangleButton2";
            this.rectangleButton2.TextColor = System.Drawing.Color.Black;
            this.rectangleButton2.TopColor = System.Drawing.Color.LawnGreen;
            this.rectangleButton2.UseVisualStyleBackColor = false;
            // 
            // rectangleButton1
            // 
            this.rectangleButton1.BottomButtonBackColor = System.Drawing.Color.Red;
            this.rectangleButton1.Location = new System.Drawing.Point(133, 38);
            this.rectangleButton1.MouseDownColor = System.Drawing.Color.LawnGreen;
            this.rectangleButton1.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))), ((int)(((byte)(3)))));
            this.rectangleButton1.Name = "rectangleButton1";
            this.rectangleButton1.OutLine = System.Drawing.Color.White;
            this.rectangleButton1.Radious = 20;
            this.rectangleButton1.Size = new System.Drawing.Size(120, 125);
            this.rectangleButton1.TabIndex = 0;
            this.rectangleButton1.Text = "ellipseButton1";
            this.rectangleButton1.TextColor = System.Drawing.Color.Black;
            this.rectangleButton1.TopButtonBackColor = System.Drawing.Color.Gray;
            this.rectangleButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 484);
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
    }
}

