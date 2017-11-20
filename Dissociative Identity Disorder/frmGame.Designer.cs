namespace Dissociative_Identity_Disorder.Resources
{
    partial class frmGame
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
            this.timBullets = new System.Windows.Forms.Timer(this.components);
            this.picClass = new System.Windows.Forms.PictureBox();
            this.picBlake = new System.Windows.Forms.PictureBox();
            this.timCounter = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.pnlScores = new System.Windows.Forms.Panel();
            this.lblScores = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlake)).BeginInit();
            this.pnlScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // timBullets
            // 
            this.timBullets.Enabled = true;
            this.timBullets.Interval = 30;
            this.timBullets.Tick += new System.EventHandler(this.timBullets_Tick);
            // 
            // picClass
            // 
            this.picClass.BackColor = System.Drawing.Color.LightGray;
            this.picClass.BackgroundImage = global::Dissociative_Identity_Disorder.Properties.Resources.students_en_US;
            this.picClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClass.Location = new System.Drawing.Point(1121, 1);
            this.picClass.Name = "picClass";
            this.picClass.Size = new System.Drawing.Size(128, 125);
            this.picClass.TabIndex = 3;
            this.picClass.TabStop = false;
            // 
            // picBlake
            // 
            this.picBlake.BackColor = System.Drawing.Color.Black;
            this.picBlake.BackgroundImage = global::Dissociative_Identity_Disorder.Properties.Resources.BlakeHappy;
            this.picBlake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBlake.Location = new System.Drawing.Point(30, 1);
            this.picBlake.Name = "picBlake";
            this.picBlake.Size = new System.Drawing.Size(128, 125);
            this.picBlake.TabIndex = 2;
            this.picBlake.TabStop = false;
            // 
            // timCounter
            // 
            this.timCounter.Enabled = true;
            this.timCounter.Interval = 1000;
            this.timCounter.Tick += new System.EventHandler(this.timCounter_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblTimer.Location = new System.Drawing.Point(593, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(89, 45);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "0:00";
            // 
            // pnlScores
            // 
            this.pnlScores.Controls.Add(this.lblScores);
            this.pnlScores.Controls.Add(this.lblTitle);
            this.pnlScores.Location = new System.Drawing.Point(373, 183);
            this.pnlScores.Name = "pnlScores";
            this.pnlScores.Size = new System.Drawing.Size(530, 360);
            this.pnlScores.TabIndex = 5;
            this.pnlScores.Visible = false;
            this.pnlScores.Click += new System.EventHandler(this.pnlScores_Click);
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblScores.Location = new System.Drawing.Point(221, 180);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(47, 135);
            this.lblScores.TabIndex = 6;
            this.lblScores.Text = "1.\r\n2.\r\n3.";
            this.lblScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblTitle.Location = new System.Drawing.Point(123, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 118);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Your Time:\r\nHigh Scores:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BackgroundImage = global::Dissociative_Identity_Disorder.Properties.Resources.GameBackground;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlScores);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.picClass);
            this.Controls.Add(this.picBlake);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGame_FormClosed);
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmGame_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmGame_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlake)).EndInit();
            this.pnlScores.ResumeLayout(false);
            this.pnlScores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBlake;
        private System.Windows.Forms.PictureBox picClass;
        private System.Windows.Forms.Timer timBullets;
        private System.Windows.Forms.Timer timCounter;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel pnlScores;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblTitle;
    }
}