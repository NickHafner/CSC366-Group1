using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class gameForm : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;


        public gameForm()
        {
            InitializeComponent();
            
            //Initial game setup; Starts on game over screen
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            paddlePictureBox.Top = gamePanel.Bottom - (gamePanel.Bottom / 10);

            gameOverLabel.Left = (gamePanel.Width/2) - (gameOverLabel.Width/2);
            gameOverLabel.Top = (gamePanel.Height / 2) - (gameOverLabel.Height / 2);
            gameOverLabel.Visible = true;
        }

        //Paint next scene based off timer ticks
        private void Timer1_Tick(object sender, EventArgs e)
        {   
            //Moves paddle's xpos based on where the cursor is located
            paddlePictureBox.Left = Cursor.Position.X - (paddlePictureBox.Width / 2);
            ballPictureBox.Left += speed_left;
            ballPictureBox.Top += speed_top;

            //Deal with case of the ball hitting the paddle.  Increases ball speed, increment score, and change background
            if (ballPictureBox.Bottom >= paddlePictureBox.Top && ballPictureBox.Bottom <= paddlePictureBox.Bottom && ballPictureBox.Left >= paddlePictureBox.Left && ballPictureBox.Right <= paddlePictureBox.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                scoreLabel.Text = points.ToString();

                Random r = new Random();
                gamePanel.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
            }

            //Deals with case of the ball hitting the edges of the game panel
            if (ballPictureBox.Left <= gamePanel.Left)
            {
                speed_left = -speed_left;
            }

            if (ballPictureBox.Right >= gamePanel.Right)
            {
                speed_left = -speed_left;
            }
            if (ballPictureBox.Top <= gamePanel.Top)
            {
                speed_top = -speed_top;
            }
            //Game over case
            if (ballPictureBox.Bottom >= gamePanel.Bottom)
            {
                timer1.Enabled = false;
                gameOverLabel.Visible = true;
            }
        }

        //Handle key down events
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Escape key closes app; f1 key setups the game and begins the timer
            if (e.KeyCode == Keys.Escape) { Application.Exit(); }
            if (e.KeyCode == Keys.F1)
            {
                ballPictureBox.Top = 50;
                ballPictureBox.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                scoreLabel.Text = "0";
                timer1.Enabled = true;
                gameOverLabel.Visible = false;
                gamePanel.BackColor = Color.FromArgb(41, 44, 51);
            }
        }
    }
}
