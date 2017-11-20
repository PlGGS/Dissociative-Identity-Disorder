using System;
using System.Drawing;
using System.Windows.Forms;
using Dissociative_Identity_Disorder.Resources;

namespace Dissociative_Identity_Disorder
{
    public partial class frmMain : Form
    {
        private int clickNum = 0;
        

        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Click(object sender, EventArgs e)
        {
            clickNum += 1;
            switch (clickNum)
            {
                case 1:
                    plrVideo.Location = new Point(0, 0);
                    plrVideo.Visible = true;
                    plrVideo.URL = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Video.mp4";
                    plrVideo.Ctlcontrols.play();
                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
        }

        private void plrVideo_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            if (e.nButton == 1)
            {
                frmQuestions questions = new frmQuestions();
                questions.Show();
                this.Close();
            }
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (plrVideo != null)
                {
                    if (plrVideo.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        plrVideo.Ctlcontrols.pause();
                    }
                    else
                    {
                        plrVideo.Ctlcontrols.play();
                    }
                }
                
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Taskbar.Show();
        }
    }
}
