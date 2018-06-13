namespace homiepure.wizard
{
    partial class FrmWizardContainer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWizardContainer));
            this.panelControl1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelControl2 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new System.Windows.Forms.PictureBox();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.pcWizPage = new System.Windows.Forms.Panel();
            this.toolStripWizardControl = new System.Windows.Forms.ToolStrip();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.tspbTaskProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInfo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslElapsedTime = new System.Windows.Forms.ToolStripLabel();
            this.timerTaskCounter = new System.Windows.Forms.Timer(this.components);
            this.ucTaskProgress = new UserControls.UcTaskProgress();
            
            this.panelControl1.SuspendLayout();
           
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            
            
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            
            this.panelControl2.SuspendLayout();
            
            
            this.toolStripWizardControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.splitContainer1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(736, 289);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbPic);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(732, 285);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 0;
            // 
            // pbPic
            // 
            this.pbPic.Dock = System.Windows.Forms.DockStyle.Fill;
           
            this.pbPic.Location = new System.Drawing.Point(0, 0);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(153, 285);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic.TabIndex = 9;
            this.pbPic.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panelControl2);
            this.splitContainer2.Panel1.Controls.Add(this.pcWizPage);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.toolStripWizardControl);
            this.splitContainer2.Size = new System.Drawing.Size(575, 285);
            this.splitContainer2.SplitterDistance = 254;
            this.splitContainer2.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelControl2.Controls.Add(this.pictureEdit1);
            this.panelControl2.Controls.Add(this.lblTaskDescription);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(575, 56);
            this.panelControl2.TabIndex = 0;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
           
            this.pictureEdit1.Location = new System.Drawing.Point(509, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.InitialImage = Properties.Resources.infinity_sign;
            this.pictureEdit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEdit1.Size = new System.Drawing.Size(65, 56);
            this.pictureEdit1.TabIndex = 21;
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDescription.ForeColor = System.Drawing.Color.Black;
            this.lblTaskDescription.Location = new System.Drawing.Point(5, 34);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(344, 18);
            this.lblTaskDescription.TabIndex = 20;
            this.lblTaskDescription.Text = "<Task Description>";
            this.lblTaskDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcWizPage
            // 
            this.pcWizPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcWizPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pcWizPage.Location = new System.Drawing.Point(0, 55);
            this.pcWizPage.Name = "pcWizPage";
            this.pcWizPage.Size = new System.Drawing.Size(575, 199);
            this.pcWizPage.TabIndex = 0;
            // 
            // toolStripWizardControl
            // 
            this.toolStripWizardControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripWizardControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripWizardControl.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripWizardControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCancel,
            this.toolStripSeparator4,
            this.tsbNext,
            this.toolStripSeparator3,
            this.tsbBack,
            this.tspbTaskProgressBar,
            this.toolStripSeparator1,
            this.tslInfo,
            this.toolStripSeparator2,
            this.tslElapsedTime});
            this.toolStripWizardControl.Location = new System.Drawing.Point(0, 2);
            this.toolStripWizardControl.Name = "toolStripWizardControl";
            this.toolStripWizardControl.Size = new System.Drawing.Size(575, 25);
            this.toolStripWizardControl.TabIndex = 15;
            // 
            // tsbCancel
            // 
            this.tsbCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(47, 22);
            this.tsbCancel.Text = "Cancel";
            this.tsbCancel.ToolTipText = "Cancel";
            this.tsbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbNext
            // 
            this.tsbNext.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
           
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(46, 22);
            this.tsbNext.Text = "Next >";
            this.tsbNext.Click += new System.EventHandler(this.sbNext_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBack
            // 
            this.tsbBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
          
            this.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBack.Name = "tsbBack";
            this.tsbBack.Size = new System.Drawing.Size(47, 22);
            this.tsbBack.Text = "< Back";
            this.tsbBack.ToolTipText = "Back";
            this.tsbBack.Click += new System.EventHandler(this.sbBack_Click);
            // 
            // tspbTaskProgressBar
            // 
            this.tspbTaskProgressBar.Name = "tspbTaskProgressBar";
            this.tspbTaskProgressBar.Size = new System.Drawing.Size(100, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslInfo
            // 
            this.tslInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tslInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslInfo.Name = "tslInfo";
            this.tslInfo.Size = new System.Drawing.Size(18, 22);
            this.tslInfo.Text = "[|]";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslElapsedTime
            // 
            this.tslElapsedTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tslElapsedTime.Name = "tslElapsedTime";
            this.tslElapsedTime.Size = new System.Drawing.Size(49, 22);
            this.tslElapsedTime.Text = "00:00:00";
            // 
            // timerTaskCounter
            // 
            this.timerTaskCounter.Interval = 1000;
            this.timerTaskCounter.Tick += new System.EventHandler(this.timerTaskCounter_Tick);
            // 
            // ucTaskProgress
            // 
            this.ucTaskProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucTaskProgress.AutoSize = true;
            this.ucTaskProgress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucTaskProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucTaskProgress.Location = new System.Drawing.Point(198, 83);
            this.ucTaskProgress.Name = "ucTaskProgress";
            this.ucTaskProgress.Size = new System.Drawing.Size(358, 4);
            this.ucTaskProgress.StatusMessage = null;
            this.ucTaskProgress.TabIndex = 0;
            this.ucTaskProgress.Visible = false;
            // 
            // FrmWizardContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(736, 289);
            this.Controls.Add(this.ucTaskProgress);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.Name = "FrmWizardContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<Name of> Wizard";
           
            this.panelControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
           
            this.splitContainer1.ResumeLayout(false);
           
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
           
            this.splitContainer2.ResumeLayout(false);
           
            this.panelControl2.ResumeLayout(false);
          
            this.toolStripWizardControl.ResumeLayout(false);
            this.toolStripWizardControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelControl1;
        private System.Windows.Forms.Panel pcWizPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panelControl2;
        internal System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.PictureBox pictureEdit1;
        private System.Windows.Forms.Label lblTaskDescription;
        public System.Windows.Forms.Timer timerTaskCounter;
        private System.Windows.Forms.ToolStrip toolStripWizardControl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton tsbBack;
        public System.Windows.Forms.ToolStripProgressBar tspbTaskProgressBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripLabel tslInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripLabel tslElapsedTime;
        public System.Windows.Forms.ToolStripButton tsbCancel;
        public UserControls.UcTaskProgress ucTaskProgress;
    }
}