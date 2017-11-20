using System;
using System.Windows.Forms;

namespace Dissociative_Identity_Disorder.Resources
{
    public partial class frmQuestions : Form
    {
        public frmQuestions()
        {
            InitializeComponent();
        }

        private void frmQuestions_Load(object sender, EventArgs e)
        {
            Taskbar.Hide();
        }

        private void frmQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Taskbar.Show();
        }   

        private void frmQuestions_Click(object sender, EventArgs e)
        {
            frmGame game = new frmGame();
            game.Show();
            this.Close();
        }
    }
}
