namespace FileMoveTool
{
    partial class FilesMoverForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.txtMon = new System.Windows.Forms.TextBox();
            this.plTop = new System.Windows.Forms.Panel();
            this.btnSelectTarget = new System.Windows.Forms.Button();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.chkClearDir = new System.Windows.Forms.CheckBox();
            this.plTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(250, 75);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "源文件夹：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "目标文件夹：";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(86, 7);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(381, 21);
            this.txtSource.TabIndex = 3;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(86, 39);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(381, 21);
            this.txtTarget.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(262, 125);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Checked = true;
            this.chkOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOverwrite.Location = new System.Drawing.Point(133, 96);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(72, 16);
            this.chkOverwrite.TabIndex = 6;
            this.chkOverwrite.Text = "强行覆盖";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // txtMon
            // 
            this.txtMon.Location = new System.Drawing.Point(12, 164);
            this.txtMon.Multiline = true;
            this.txtMon.Name = "txtMon";
            this.txtMon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMon.Size = new System.Drawing.Size(505, 240);
            this.txtMon.TabIndex = 7;
            // 
            // plTop
            // 
            this.plTop.Controls.Add(this.chkClearDir);
            this.plTop.Controls.Add(this.btnSelectTarget);
            this.plTop.Controls.Add(this.label1);
            this.plTop.Controls.Add(this.btnSelectSource);
            this.plTop.Controls.Add(this.txtSource);
            this.plTop.Controls.Add(this.chkOverwrite);
            this.plTop.Controls.Add(this.btnGo);
            this.plTop.Controls.Add(this.label2);
            this.plTop.Controls.Add(this.txtTarget);
            this.plTop.Location = new System.Drawing.Point(12, 12);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(508, 112);
            this.plTop.TabIndex = 8;
            // 
            // btnSelectTarget
            // 
            this.btnSelectTarget.Location = new System.Drawing.Point(473, 37);
            this.btnSelectTarget.Name = "btnSelectTarget";
            this.btnSelectTarget.Size = new System.Drawing.Size(32, 23);
            this.btnSelectTarget.TabIndex = 10;
            this.btnSelectTarget.Text = "...";
            this.btnSelectTarget.UseVisualStyleBackColor = true;
            this.btnSelectTarget.Click += new System.EventHandler(this.btnSelectTarget_Click);
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(473, 5);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(32, 23);
            this.btnSelectSource.TabIndex = 9;
            this.btnSelectSource.Text = "...";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // chkClearDir
            // 
            this.chkClearDir.AutoSize = true;
            this.chkClearDir.Checked = true;
            this.chkClearDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClearDir.Location = new System.Drawing.Point(34, 96);
            this.chkClearDir.Name = "chkClearDir";
            this.chkClearDir.Size = new System.Drawing.Size(96, 16);
            this.chkClearDir.TabIndex = 11;
            this.chkClearDir.Text = "清理空文件夹";
            this.chkClearDir.UseVisualStyleBackColor = true;
            // 
            // FilesMoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 416);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.txtMon);
            this.Controls.Add(this.btnStop);
            this.Name = "FilesMoverForm";
            this.Text = "PP\'s FileMover";
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.TextBox txtMon;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.Button btnSelectTarget;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.CheckBox chkClearDir;
    }
}

