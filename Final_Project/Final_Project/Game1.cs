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
    public partial class Game1 : Form
    {
        public static int redTeam = 100 , greenTeam = 100 , totalMoney = 0; // total num of people in a team
        int redRope = 0, greenRope = 0 , s = 0; // for race

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer(); // 加入音檔
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(); // 內建撥放音效
        SoundPlayer sp2 = new SoundPlayer("whistle.wav");

        public Game1()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e) // 遊戲結束處理
        {
            if(pictureBox1.Left >= pictureBox_g.Left) // team green win
            {
                timer2.Stop();
                sp2.Play();

                redTeam -= redRope;
                totalMoney += 10000 * redRope;

                foreach (Control x in this.Controls)
                {
                    if(x.Tag == "final")
                    {
                        x.Visible = true;
                        label_win.Text = "綠隊獲勝!!!";
                        label_win.ForeColor = Color.Green;

                        label5.Text = redTeam.ToString();
                        label_gNum.Text = greenTeam.ToString();
                        label_total.Text = totalMoney.ToString();
                    }
                }

                this.KeyPreview = false;
            }

            else if(pictureBox1.Left + pictureBox1.Width <= pictureBox_r.Left) // red team win
            {
                timer2.Stop();
                sp2.Play();

                greenTeam -= greenRope;
                totalMoney += 10000 * greenRope;

                foreach (Control x in this.Controls)
                {
                    if (x.Tag == "final")
                    {
                        x.Visible = true;
                        label_win.Text = "紅隊獲勝!!!";
                        label_win.ForeColor = Color.Red;

                        label5.Text = redTeam.ToString();
                        label_gNum.Text = greenTeam.ToString();
                        label_total.Text = totalMoney.ToString();
                    }
                }

                this.KeyPreview = false;
            }
        }

        private void Game1_KeyUp(object sender, KeyEventArgs e) // 拔河處理
        {
            foreach(Control x in this.Controls)
            {
                if (e.KeyCode == Keys.A && x.Tag == "race")
                    x.Left -= redRope * 5;
                else if (e.KeyCode == Keys.L && x.Tag == "race")
                    x.Left += greenRope * 5;
            }
        }

        private void timer3_Tick(object sender, EventArgs e) // 畫面淡入
        {
            this.Opacity += .2;
            if (this.Opacity == 1) timer3.Stop();
        }

        private void button3_Click(object sender, EventArgs e) // 切換畫面
        {
            Game2 game2 = new Game2();
            game2.Show();
            this.Hide();

            wplayer.controls.stop();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            int nowSecond = 5;
            s++;
            label_second.Text = (nowSecond - s -1).ToString();

            if(nowSecond - s <= 1 && nowSecond - s > 0)
            {
                label_second.Text = "開始";
                sp2.Play();
            }

            else if (nowSecond - s <= 0)
            {
                timer1.Stop();
                label_second.Visible = false;
                this.KeyPreview = true;
                timer2.Start();
            }    
        }

        private void Game1_Load(object sender, EventArgs e)
        {
            this.SetBounds(0, 0, 1540, 820);
            this.KeyPreview = false;
            timer3.Start();

            wplayer.URL = "Game1background.mp3";
            wplayer.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox_instruct.Visible = false;
            this.Controls.Remove(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            redRope = int.Parse(textBox_red.Text);
            greenRope = int.Parse(textBox_green.Text);

            label_redNum.Text = "剩餘人數：" + redTeam.ToString();
            label_greenNum.Text = "剩餘人數：" + greenTeam.ToString();
            label_totalMoney.Text = "累積獎金：" + totalMoney.ToString();

            foreach (Control x in this.Controls)
            {
                if (x.Tag == "level2") this.Controls.Remove(x);
            }

            this.Controls.Remove(label_red);
            this.Controls.Remove(textBox_red);
            this.Controls.Remove(button2);

            for (int i = 0; i < redRope; i++)
            {
                PictureBox red = new PictureBox();
                red.SizeMode = PictureBoxSizeMode.StretchImage;
                red.Image = Properties.Resources.red_person;
                red.BackColor = Color.Transparent;
                red.Size = new Size(25, 50);
                red.Location = new Point(pictureBox_r.Left - 30*(i+1), 304);
                red.Tag = "race";
                red.BringToFront();
                this.Controls.Add(red);
            }

            for (int i = 0; i < greenRope; i++)
            {
                PictureBox green = new PictureBox();
                green.SizeMode = PictureBoxSizeMode.StretchImage;
                green.Image = Properties.Resources.green_person;
                green.BackColor = Color.Transparent;
                green.Size = new Size(25, 50);
                green.Location = new Point(pictureBox_g.Left + 30 * (i+1), 304);
                green.BringToFront();
                green.Tag = "race";
                this.Controls.Add(green);
            }

            timer1.Start();//倒數計時
        }
    }
}
