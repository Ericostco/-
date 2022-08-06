using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;

namespace Final_Project
{
    public partial class GameStart : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer(); // 加入音檔
        int count = 0;
        public GameStart()
        {
            InitializeComponent();
        }

        private void GameStart_Load(object sender, EventArgs e)
        {
            this.SetBounds(0, 0, 1540, 820);
            label_enterGame.Location = new Point(this.Width / 2 - label_enterGame.Width / 2, 580);
            button1.Location = new Point(this.Width / 2 - button1.Width / 2, 580);

            wplayer.URL = "background_enter.mp3";
            wplayer.controls.play();
            timer1.Start();
            this.BackgroundImage = Properties.Resources.StartBack_1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            
            switch(count % 5)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.StartBack_2;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.StartBack_3;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.StartBack_4;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources.StartBack_5;
                    break;
                case 0:
                    this.BackgroundImage = Properties.Resources.StartBack_1;
                    break;
            }
        }

        private void label_enterGame_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.gameIntro;
            button1.Visible = true;
            this.Controls.Remove(label_enterGame);
            timer1.Stop();
        }

        private void label_enterGame_MouseHover(object sender, EventArgs e)
        {
            label_enterGame.ForeColor = Color.Yellow;
        }

        private void label_enterGame_MouseLeave(object sender, EventArgs e)
        {
            label_enterGame.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= .2;
            if(this.Opacity == 0)
            {
                wplayer.controls.stop();
                timer2.Stop();
                Game1 game1 = new Game1();
                game1.Show();
                this.Hide();
            }
        }
    }
}
