namespace Dissociative_Identity_Disorder
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPictures = new System.Windows.Forms.Label();
            this.plrVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlGuy = new System.Windows.Forms.Panel();
            this.pnlGirl = new System.Windows.Forms.Panel();
            this.pnlGirlMirror = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.plrVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Candara", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitle.Location = new System.Drawing.Point(17, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1232, 117);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dissociative Identity Disorder";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblAuthor.Location = new System.Drawing.Point(20, 146);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(1243, 78);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Blake Boris                                                 Period 4";
            // 
            // lblPictures
            // 
            this.lblPictures.AutoSize = true;
            this.lblPictures.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPictures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblPictures.Location = new System.Drawing.Point(516, 657);
            this.lblPictures.Name = "lblPictures";
            this.lblPictures.Size = new System.Drawing.Size(232, 15);
            this.lblPictures.TabIndex = 5;
            this.lblPictures.Text = "Pictures ^^^ Because I they\'re necessary";
            // 
            // plrVideo
            // 
            this.plrVideo.Enabled = true;
            this.plrVideo.Location = new System.Drawing.Point(1242, 685);
            this.plrVideo.Name = "plrVideo";
            this.plrVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("plrVideo.OcxState")));
            this.plrVideo.Size = new System.Drawing.Size(1280, 720);
            this.plrVideo.TabIndex = 6;
            this.plrVideo.Visible = false;
            this.plrVideo.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.plrVideo_ClickEvent);
            // 
            // pnlGuy
            // 
            this.pnlGuy.BackgroundImage = global::Dissociative_Identity_Disorder.Properties.Resources.guy;
            this.pnlGuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlGuy.Location = new System.Drawing.Point(300, 283);
            this.pnlGuy.Name = "pnlGuy";
            this.pnlGuy.Size = new System.Drawing.Size(538, 313);
            this.pnlGuy.TabIndex = 4;
            // 
            // pnlGirl
            // 
            this.pnlGirl.BackgroundImage = global::Dissociative_Identity_Disorder.Properties.Resources.girl;
            this.pnlGirl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGirl.Location = new System.Drawing.Point(913, 283);
            this.pnlGirl.Name = "pnlGirl";
            this.pnlGirl.Size = new System.Drawing.Size(328, 313);
            this.pnlGirl.TabIndex = 3;
            // 
            // pnlGirlMirror
            // 
            this.pnlGirlMirror.BackgroundImage = global::Dissociative_Identity_Disorder.Properties.Resources.girlmirror;
            this.pnlGirlMirror.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGirlMirror.Location = new System.Drawing.Point(38, 283);
            this.pnlGirlMirror.Name = "pnlGirlMirror";
            this.pnlGirlMirror.Size = new System.Drawing.Size(194, 313);
            this.pnlGirlMirror.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.plrVideo);
            this.Controls.Add(this.lblPictures);
            this.Controls.Add(this.pnlGuy);
            this.Controls.Add(this.pnlGirl);
            this.Controls.Add(this.pnlGirlMirror);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Click += new System.EventHandler(this.frmMain_Click);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.plrVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Panel pnlGirlMirror;
        private System.Windows.Forms.Panel pnlGirl;
        private System.Windows.Forms.Panel pnlGuy;
        private System.Windows.Forms.Label lblPictures;
        private AxWMPLib.AxWindowsMediaPlayer plrVideo;
    }
}

