namespace homiepure.wizard.UserControls
{
    partial class UcTaskProgress
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lcTaskStatus = new System.Windows.Forms.Label();
            this.pictureEdit1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lcTaskStatus
            // 
            this.lcTaskStatus.Location = new System.Drawing.Point(139, 45);
            this.lcTaskStatus.Name = "lcTaskStatus";
            this.lcTaskStatus.Size = new System.Drawing.Size(72, 13);
            this.lcTaskStatus.TabIndex = 1;
            this.lcTaskStatus.Text = "<Task Status>";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(125, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 44);
            this.pictureEdit1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lcTaskStatus);
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 63);
            this.panel1.TabIndex = 3;
            // 
            // UcTaskProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "UcTaskProgress";
            this.Size = new System.Drawing.Size(353, 66);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureEdit1;
        public System.Windows.Forms.Label lcTaskStatus;
        public System.Windows.Forms.Panel panel1;
    }
}
