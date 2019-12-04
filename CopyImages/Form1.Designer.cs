namespace CopyImages
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
            this.picUpImage = new System.Windows.Forms.PictureBox();
            this.lnklabUpdata = new System.Windows.Forms.LinkLabel();
            this.picOpenImage = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnUpdata = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUpImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picUpImage
            // 
            this.picUpImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picUpImage.Location = new System.Drawing.Point(86, 41);
            this.picUpImage.Name = "picUpImage";
            this.picUpImage.Size = new System.Drawing.Size(128, 185);
            this.picUpImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUpImage.TabIndex = 0;
            this.picUpImage.TabStop = false;
            // 
            // lnklabUpdata
            // 
            this.lnklabUpdata.AutoSize = true;
            this.lnklabUpdata.Location = new System.Drawing.Point(84, 239);
            this.lnklabUpdata.Name = "lnklabUpdata";
            this.lnklabUpdata.Size = new System.Drawing.Size(53, 12);
            this.lnklabUpdata.TabIndex = 1;
            this.lnklabUpdata.TabStop = true;
            this.lnklabUpdata.Text = "点击选择";
            this.lnklabUpdata.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklabUpdata_LinkClicked);
            // 
            // picOpenImage
            // 
            this.picOpenImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picOpenImage.Location = new System.Drawing.Point(282, 41);
            this.picOpenImage.Name = "picOpenImage";
            this.picOpenImage.Size = new System.Drawing.Size(128, 185);
            this.picOpenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOpenImage.TabIndex = 2;
            this.picOpenImage.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(282, 232);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnUpdata
            // 
            this.btnUpdata.Location = new System.Drawing.Point(143, 234);
            this.btnUpdata.Name = "btnUpdata";
            this.btnUpdata.Size = new System.Drawing.Size(75, 23);
            this.btnUpdata.TabIndex = 4;
            this.btnUpdata.Text = "上传";
            this.btnUpdata.UseVisualStyleBackColor = true;
            this.btnUpdata.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(407, 252);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "安全退出";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(494, 287);
            this.ControlBox = false;
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnUpdata);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picOpenImage);
            this.Controls.Add(this.lnklabUpdata);
            this.Controls.Add(this.picUpImage);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 326);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 326);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUpImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUpImage;
        private System.Windows.Forms.LinkLabel lnklabUpdata;
        private System.Windows.Forms.PictureBox picOpenImage;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnUpdata;
        private System.Windows.Forms.Button btnOut;
    }
}

