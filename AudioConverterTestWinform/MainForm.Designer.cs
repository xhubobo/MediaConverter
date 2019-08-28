namespace AudioConverterTestWinform
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAacPath = new System.Windows.Forms.TextBox();
            this.textBoxWavPath = new System.Windows.Forms.TextBox();
            this.buttonAacPath = new System.Windows.Forms.Button();
            this.buttonWavPath = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "AAC file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "WAV file:";
            // 
            // textBoxAacPath
            // 
            this.textBoxAacPath.Location = new System.Drawing.Point(150, 30);
            this.textBoxAacPath.Name = "textBoxAacPath";
            this.textBoxAacPath.ReadOnly = true;
            this.textBoxAacPath.Size = new System.Drawing.Size(900, 35);
            this.textBoxAacPath.TabIndex = 1;
            // 
            // textBoxWavPath
            // 
            this.textBoxWavPath.Location = new System.Drawing.Point(150, 85);
            this.textBoxWavPath.Name = "textBoxWavPath";
            this.textBoxWavPath.Size = new System.Drawing.Size(900, 35);
            this.textBoxWavPath.TabIndex = 1;
            // 
            // buttonAacPath
            // 
            this.buttonAacPath.Location = new System.Drawing.Point(1080, 30);
            this.buttonAacPath.Name = "buttonAacPath";
            this.buttonAacPath.Size = new System.Drawing.Size(60, 35);
            this.buttonAacPath.TabIndex = 2;
            this.buttonAacPath.Text = "...";
            this.buttonAacPath.UseVisualStyleBackColor = true;
            this.buttonAacPath.Click += new System.EventHandler(this.buttonAacPath_Click);
            // 
            // buttonWavPath
            // 
            this.buttonWavPath.Location = new System.Drawing.Point(1080, 85);
            this.buttonWavPath.Name = "buttonWavPath";
            this.buttonWavPath.Size = new System.Drawing.Size(60, 35);
            this.buttonWavPath.TabIndex = 2;
            this.buttonWavPath.Text = "...";
            this.buttonWavPath.UseVisualStyleBackColor = true;
            this.buttonWavPath.Click += new System.EventHandler(this.buttonWavPath_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(500, 170);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(200, 80);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 302);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonWavPath);
            this.Controls.Add(this.buttonAacPath);
            this.Controls.Add(this.textBoxWavPath);
            this.Controls.Add(this.textBoxAacPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "AAC转WAV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAacPath;
        private System.Windows.Forms.TextBox textBoxWavPath;
        private System.Windows.Forms.Button buttonAacPath;
        private System.Windows.Forms.Button buttonWavPath;
        private System.Windows.Forms.Button buttonConvert;
    }
}

