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
            this.textBoxAacPath1 = new System.Windows.Forms.TextBox();
            this.textBoxAacPath2 = new System.Windows.Forms.TextBox();
            this.buttonAac1 = new System.Windows.Forms.Button();
            this.buttonAac2 = new System.Windows.Forms.Button();
            this.buttonConvertAac = new System.Windows.Forms.Button();
            this.buttonConvertWav = new System.Windows.Forms.Button();
            this.buttonWav2 = new System.Windows.Forms.Button();
            this.buttonWav1 = new System.Windows.Forms.Button();
            this.textBoxWavPath2 = new System.Windows.Forms.TextBox();
            this.textBoxWavPath1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Audio file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "AAC file:";
            // 
            // textBoxAacPath1
            // 
            this.textBoxAacPath1.Location = new System.Drawing.Point(200, 30);
            this.textBoxAacPath1.Name = "textBoxAacPath1";
            this.textBoxAacPath1.ReadOnly = true;
            this.textBoxAacPath1.Size = new System.Drawing.Size(900, 35);
            this.textBoxAacPath1.TabIndex = 1;
            // 
            // textBoxAacPath2
            // 
            this.textBoxAacPath2.Location = new System.Drawing.Point(200, 85);
            this.textBoxAacPath2.Name = "textBoxAacPath2";
            this.textBoxAacPath2.Size = new System.Drawing.Size(900, 35);
            this.textBoxAacPath2.TabIndex = 1;
            // 
            // buttonAac1
            // 
            this.buttonAac1.Location = new System.Drawing.Point(1130, 30);
            this.buttonAac1.Name = "buttonAac1";
            this.buttonAac1.Size = new System.Drawing.Size(60, 35);
            this.buttonAac1.TabIndex = 2;
            this.buttonAac1.Text = "...";
            this.buttonAac1.UseVisualStyleBackColor = true;
            this.buttonAac1.Click += new System.EventHandler(this.buttonAac1_Click);
            // 
            // buttonAac2
            // 
            this.buttonAac2.Location = new System.Drawing.Point(1130, 85);
            this.buttonAac2.Name = "buttonAac2";
            this.buttonAac2.Size = new System.Drawing.Size(60, 35);
            this.buttonAac2.TabIndex = 2;
            this.buttonAac2.Text = "...";
            this.buttonAac2.UseVisualStyleBackColor = true;
            this.buttonAac2.Click += new System.EventHandler(this.buttonAac2_Click);
            // 
            // buttonConvertAac
            // 
            this.buttonConvertAac.Location = new System.Drawing.Point(500, 170);
            this.buttonConvertAac.Name = "buttonConvertAac";
            this.buttonConvertAac.Size = new System.Drawing.Size(200, 80);
            this.buttonConvertAac.TabIndex = 3;
            this.buttonConvertAac.Text = "Convert";
            this.buttonConvertAac.UseVisualStyleBackColor = true;
            this.buttonConvertAac.Click += new System.EventHandler(this.buttonConvertAac_Click);
            // 
            // buttonConvertWav
            // 
            this.buttonConvertWav.Location = new System.Drawing.Point(505, 444);
            this.buttonConvertWav.Name = "buttonConvertWav";
            this.buttonConvertWav.Size = new System.Drawing.Size(200, 80);
            this.buttonConvertWav.TabIndex = 10;
            this.buttonConvertWav.Text = "Convert";
            this.buttonConvertWav.UseVisualStyleBackColor = true;
            this.buttonConvertWav.Click += new System.EventHandler(this.buttonConvertWav_Click);
            // 
            // buttonWav2
            // 
            this.buttonWav2.Location = new System.Drawing.Point(1130, 359);
            this.buttonWav2.Name = "buttonWav2";
            this.buttonWav2.Size = new System.Drawing.Size(60, 35);
            this.buttonWav2.TabIndex = 8;
            this.buttonWav2.Text = "...";
            this.buttonWav2.UseVisualStyleBackColor = true;
            this.buttonWav2.Click += new System.EventHandler(this.buttonWav2_Click);
            // 
            // buttonWav1
            // 
            this.buttonWav1.Location = new System.Drawing.Point(1130, 304);
            this.buttonWav1.Name = "buttonWav1";
            this.buttonWav1.Size = new System.Drawing.Size(60, 35);
            this.buttonWav1.TabIndex = 9;
            this.buttonWav1.Text = "...";
            this.buttonWav1.UseVisualStyleBackColor = true;
            this.buttonWav1.Click += new System.EventHandler(this.buttonWav1_Click);
            // 
            // textBoxWavPath2
            // 
            this.textBoxWavPath2.Location = new System.Drawing.Point(200, 359);
            this.textBoxWavPath2.Name = "textBoxWavPath2";
            this.textBoxWavPath2.Size = new System.Drawing.Size(900, 35);
            this.textBoxWavPath2.TabIndex = 6;
            // 
            // textBoxWavPath1
            // 
            this.textBoxWavPath1.Location = new System.Drawing.Point(200, 304);
            this.textBoxWavPath1.Name = "textBoxWavPath1";
            this.textBoxWavPath1.ReadOnly = true;
            this.textBoxWavPath1.Size = new System.Drawing.Size(900, 35);
            this.textBoxWavPath1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "WAV file:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Audio file:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 569);
            this.Controls.Add(this.buttonConvertWav);
            this.Controls.Add(this.buttonWav2);
            this.Controls.Add(this.buttonWav1);
            this.Controls.Add(this.textBoxWavPath2);
            this.Controls.Add(this.textBoxWavPath1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonConvertAac);
            this.Controls.Add(this.buttonAac2);
            this.Controls.Add(this.buttonAac1);
            this.Controls.Add(this.textBoxAacPath2);
            this.Controls.Add(this.textBoxAacPath1);
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
        private System.Windows.Forms.TextBox textBoxAacPath1;
        private System.Windows.Forms.TextBox textBoxAacPath2;
        private System.Windows.Forms.Button buttonAac1;
        private System.Windows.Forms.Button buttonAac2;
        private System.Windows.Forms.Button buttonConvertAac;
        private System.Windows.Forms.Button buttonConvertWav;
        private System.Windows.Forms.Button buttonWav2;
        private System.Windows.Forms.Button buttonWav1;
        private System.Windows.Forms.TextBox textBoxWavPath2;
        private System.Windows.Forms.TextBox textBoxWavPath1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

