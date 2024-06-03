namespace Launcher
{
    partial class LMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LMain));
            DLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(components);
            StartGameButton = new DevExpress.XtraEditors.SimpleButton();
            TotalProgressBar = new DevExpress.XtraEditors.ProgressBarControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            StatusLabel = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            DownloadSizeLabel = new DevExpress.XtraEditors.LabelControl();
            DownloadSpeedLabel = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            PatchNotesHyperlinkControl = new DevExpress.XtraEditors.HyperlinkLabelControl();
            RepairButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)TotalProgressBar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // StartGameButton
            // 
            StartGameButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            StartGameButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("StartGameButton.ImageOptions.Image");
            StartGameButton.Location = new System.Drawing.Point(616, 354);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new System.Drawing.Size(100, 46);
            StartGameButton.TabIndex = 0;
            StartGameButton.Text = "Start Game";
            StartGameButton.Click += StartGameButton_Click;
            // 
            // TotalProgressBar
            // 
            TotalProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TotalProgressBar.Location = new System.Drawing.Point(12, 382);
            TotalProgressBar.Name = "TotalProgressBar";
            TotalProgressBar.Properties.FlowAnimationEnabled = true;
            TotalProgressBar.Properties.ShowTitle = true;
            TotalProgressBar.Size = new System.Drawing.Size(598, 18);
            TotalProgressBar.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl1.Location = new System.Drawing.Point(28, 344);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(35, 13);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Status:";
            // 
            // StatusLabel
            // 
            StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            StatusLabel.Location = new System.Drawing.Point(69, 344);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(41, 13);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "<None>";
            StatusLabel.Click += StatusLabel_Click;
            // 
            // labelControl3
            // 
            labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl3.Location = new System.Drawing.Point(12, 363);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(51, 13);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Download:";
            // 
            // DownloadSizeLabel
            // 
            DownloadSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            DownloadSizeLabel.Location = new System.Drawing.Point(69, 363);
            DownloadSizeLabel.Name = "DownloadSizeLabel";
            DownloadSizeLabel.Size = new System.Drawing.Size(41, 13);
            DownloadSizeLabel.TabIndex = 5;
            DownloadSizeLabel.Text = "<None>";
            // 
            // DownloadSpeedLabel
            // 
            DownloadSpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            DownloadSpeedLabel.Location = new System.Drawing.Point(554, 363);
            DownloadSpeedLabel.Name = "DownloadSpeedLabel";
            DownloadSpeedLabel.Size = new System.Drawing.Size(41, 13);
            DownloadSpeedLabel.TabIndex = 7;
            DownloadSpeedLabel.Text = "<None>";
            // 
            // labelControl6
            // 
            labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            labelControl6.Location = new System.Drawing.Point(464, 363);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(84, 13);
            labelControl6.TabIndex = 6;
            labelControl6.Text = "Download Speed:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.PatchHeader;
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(704, 307);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // PatchNotesHyperlinkControl
            // 
            PatchNotesHyperlinkControl.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            PatchNotesHyperlinkControl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            PatchNotesHyperlinkControl.Appearance.Options.UseFont = true;
            PatchNotesHyperlinkControl.Cursor = System.Windows.Forms.Cursors.Hand;
            PatchNotesHyperlinkControl.LineVisible = true;
            PatchNotesHyperlinkControl.Location = new System.Drawing.Point(107, 322);
            PatchNotesHyperlinkControl.Name = "PatchNotesHyperlinkControl";
            PatchNotesHyperlinkControl.Size = new System.Drawing.Size(488, 13);
            PatchNotesHyperlinkControl.TabIndex = 9;
            PatchNotesHyperlinkControl.Text = "Si quieres conseguir muchos GAME GOLD para comprar articulos de pago PINCHA AQUI!";
            PatchNotesHyperlinkControl.HyperlinkClick += PatchNotesHyperlinkControl_HyperlinkClick;
            PatchNotesHyperlinkControl.Click += PatchNotesHyperlinkControl_Click;
            // 
            // RepairButton
            // 
            RepairButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            RepairButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("RepairButton.ImageOptions.Image");
            RepairButton.Location = new System.Drawing.Point(616, 325);
            RepairButton.Name = "RepairButton";
            RepairButton.Size = new System.Drawing.Size(100, 23);
            RepairButton.TabIndex = 15;
            RepairButton.Text = "Repair";
            RepairButton.Click += RepairButton_Click;
            // 
            // LMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(728, 412);
            Controls.Add(RepairButton);
            Controls.Add(PatchNotesHyperlinkControl);
            Controls.Add(pictureBox1);
            Controls.Add(DownloadSpeedLabel);
            Controls.Add(labelControl6);
            Controls.Add(DownloadSizeLabel);
            Controls.Add(labelControl3);
            Controls.Add(StatusLabel);
            Controls.Add(labelControl1);
            Controls.Add(TotalProgressBar);
            Controls.Add(StartGameButton);
            IconOptions.Icon = (System.Drawing.Icon)resources.GetObject("LMain.IconOptions.Icon");
            Name = "LMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Server La Corrupción de Mir";
            Load += LMain_Load;
            ((System.ComponentModel.ISupportInitialize)TotalProgressBar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel DLookAndFeel;
        private DevExpress.XtraEditors.ProgressBarControl TotalProgressBar;
        private DevExpress.XtraEditors.SimpleButton StartGameButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl StatusLabel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl DownloadSizeLabel;
        private DevExpress.XtraEditors.LabelControl DownloadSpeedLabel;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton RepairButton;
        protected DevExpress.XtraEditors.HyperlinkLabelControl PatchNotesHyperlinkControl;
    }
}

