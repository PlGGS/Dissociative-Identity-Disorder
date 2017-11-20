using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Dissociative_Identity_Disorder.Resources
{
    public partial class frmGame : Form
    {
        bool classGoDown = true;
        bool gameInSession = false;
        int seconds = 0;
        int minutes = 0;
        string formattedTime;
        static int amtBullets = 6;
        PictureBox[] bullets = new PictureBox[amtBullets];
        Random rng = new Random();
        SoundPlayer song = new SoundPlayer(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Brothers in Arms.wav");

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            Taskbar.Hide();
            loadBullets();
            gameInSession = true;
            song.PlayLooping();
        }

        private void loadBullets()
        {
            for (int i = 0; i < amtBullets; i++)
            {
                bullets[i] = new PictureBox();
                this.Controls.Add(bullets[i]);
                bullets[i].Size = new Size(130, 70);
                bullets[i].SizeMode = PictureBoxSizeMode.StretchImage;
                bullets[i].Visible = true;
                setBulletYPosition(i);
            }
        }

        private int setBulletYPosition(int i)
        {
            int num = rng.Next(0, Bounds.Height - i);
            bullets[i].Location = new Point(Bounds.Width, num);

            if (num % 2 == 0)
            {
                bullets[i].Image = Properties.Resources.yes;
            }
            else
            {
                bullets[i].Image = Properties.Resources.no;
            }

            return num;
        }

        private void frmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Taskbar.Show();
        }

        private void frmGame_MouseMove(object sender, MouseEventArgs e)
        {
            if (gameInSession)
            {
                picBlake.Location = new Point(picBlake.Location.X, e.Y - (picBlake.Bounds.Height / 2));
            }
        }

        public string getFormattedTime()
        {
            if (seconds > 9 && seconds < 60)
            {
                 formattedTime = minutes + ":" + seconds % 60;
            } else if (seconds < 10)
            {
                formattedTime = minutes + ":0" + seconds % 60;
            } else
            {
                formattedTime = ++minutes + ":00";
                seconds = 0;
            }

            return formattedTime;
        }

        private void timCounter_Tick(object sender, EventArgs e)
        {
            if (gameInSession)
            {
                lblTimer.Text = getFormattedTime();

                if (minutes == 1)
                {
                    timBullets.Interval = 20;
                } else if (minutes == 2)
                {
                    timBullets.Interval = 10;
                }

                seconds++;
            }
        }

        private void timBullets_Tick(object sender, EventArgs e)
        {
            if (gameInSession)
            {
                if (picClass.Bounds.Bottom >= this.Height)
                {
                    classGoDown = false;
                }
                else if (picClass.Location.Y <= 0)
                {
                    classGoDown = true;
                }

                if (classGoDown)
                {
                    picClass.Location = new Point(picClass.Location.X, picClass.Location.Y + 15);
                }
                else
                {
                    picClass.Location = new Point(picClass.Location.X, picClass.Location.Y - 15);
                }

                for (int i = 0; i < amtBullets; i++)
                {
                    bullets[i].Location = new Point(bullets[i].Location.X - 20, bullets[i].Location.Y);
                    Point xLoc = bullets[i].Location;

                    if (xLoc.X < 0)
                    {
                        setBulletYPosition(i);
                    }

                    if (bullets[i].Bounds.IntersectsWith(picBlake.Bounds))
                    {
                        gameInSession = false;
                        song.Stop();
                        
                        if (seconds > Properties.Settings.Default.First)
                        {
                            Properties.Settings.Default.Third = Properties.Settings.Default.Second;
                            Properties.Settings.Default.Second = Properties.Settings.Default.First;
                            Properties.Settings.Default.First = seconds;
                            Properties.Settings.Default.Save();
                        } else if (seconds > Properties.Settings.Default.Second && seconds != Properties.Settings.Default.First)
                        {
                            Properties.Settings.Default.Third = Properties.Settings.Default.Second;
                            Properties.Settings.Default.Second = seconds;
                            Properties.Settings.Default.Save();
                        } else if (seconds > Properties.Settings.Default.Third && seconds != Properties.Settings.Default.Second)
                        {
                            Properties.Settings.Default.Third = seconds;
                            Properties.Settings.Default.Save();
                        }

                        lblTitle.Text = "Your score: " + seconds + "\nTop Scores:";
                        lblScores.Text = "1. " + Properties.Settings.Default.First + "\n2. " + Properties.Settings.Default.Second + "\n3. " + Properties.Settings.Default.Third;
                        lblTimer.Hide();
                        pnlScores.Show();
                    }
                }
            }
        }

        private void frmGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                this.Close();
                Environment.Exit(0);
            } else if (e.Button == MouseButtons.Left)
            {
                restartGame();
            }
        }

        private void restartGame()
        {
            lblTimer.Show();
            pnlScores.Hide();
            timBullets.Interval = 30;
            seconds = 0;
            minutes = 0;

            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i].Location = new Point(1280, setBulletYPosition(i));
            }

            gameInSession = true;
            song.PlayLooping();
        }

        private void pnlScores_Click(object sender, EventArgs e)
        {
            restartGame();
        }
    }
}
