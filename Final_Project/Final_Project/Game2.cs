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
    public partial class Game2 : Form
    {
        int[] glass = new int[6]; // the glass ground
        int turn = 0  , nowIndex = 0; // who first , where now
        Random r = new Random();

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer(); // 加入音檔
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(); // 內建撥放音效
        SoundPlayer sp2 = new SoundPlayer("scream_g2.wav");
        SoundPlayer sp3 = new SoundPlayer("glassBroken_g2.wav");

        public Game2()
        {
            InitializeComponent();
        }

        private void Game2_Load(object sender, EventArgs e)
        {
            this.SetBounds(0, 0, 1540, 820);
            wplayer.URL = "Game2background.mp3";
            wplayer.controls.play();

            for (int i = 0; i < 6; ++i) // set the glass ground status
            {
                int num = r.Next(1, 3);
                turn = r.Next(1, 3);
                glass[i] = num;
            }

            timer_green.Start();
            timer_red.Start();
        }

        private void timer_red_Tick(object sender, EventArgs e)
        {
            label_redNum.Text = "剩餘人數："  + Game1.redTeam.ToString();
            label_totalMoney.Text = "累積獎金：" + Game1.totalMoney.ToString();
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if(count >= 10)
            {
                timer1.Stop();
                label_turn.Visible = false;
                timer1.Start();
                
                foreach (Control x in this.Controls) // make glass sent to back
                {
                    if (x.Tag == "glass")
                        x.SendToBack();
                }
            }
        }

        private void timer_green_Tick(object sender, EventArgs e)
        {
            label_greenNum.Text = "剩餘人數：" + Game1.greenTeam.ToString();
        }

        private void Game2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                foreach(Control x in this.Controls)
                {
                    if (x.Tag == "player")
                    {
                        x.Location = new Point(595, 550 - 100 * nowIndex);
                        x.BringToFront();

                        if (glass[nowIndex] == 1)
                            nowIndex++;

                        else if (glass[nowIndex] == 2)
                        {
                            sp3.Play();
                            Game1.totalMoney += 10000;
                            this.Controls.Remove(x);

                            GlassBroken(585, 601 - 100 * nowIndex);
                            nowIndex = 0;

                            
                            if (turn == 1)
                            {
                                Game1.redTeam--;
                                turn = 2;
                                CreateGreen();
                            }
                            else if (turn == 2)
                            {
                                Game1.greenTeam--;
                                turn = 1;
                                CreateRed();
                            }
                            sp2.Play();
                        }

                        if (nowIndex == 6) // terminal
                        {
                            timer1.Stop();
                            x.Location = new Point(585, 550 - 100 * nowIndex);
                            this.KeyPreview = false;

                            foreach (Control y in this.Controls) // make glass sent to back
                            {
                                if (y.Tag == "broken_glass")
                                    this.Controls.Remove(y);
                            }
                            ShowFinal();
                        }
                    }
                }
            }
            else if(e.KeyChar == '2')
            {
                foreach (Control x in this.Controls)
                {
                    if (x.Tag == "player")
                    {
                        x.Location = new Point(857 , 550 - 100 * nowIndex);
                        x.BringToFront();

                        if (glass[nowIndex] == 2)
                            nowIndex++;

                        else if (glass[nowIndex] == 1)
                        {
                            sp3.Play();
                            Game1.totalMoney += 10000;
                            this.Controls.Remove(x);

                            GlassBroken(847, 601 - 100 * nowIndex);
                            nowIndex = 0;
                            
                            if (turn == 1)
                            {
                                Game1.redTeam--;
                                turn = 2;
                                CreateGreen();
                            }
                            else if (turn == 2)
                            {
                                Game1.greenTeam--;
                                turn = 1;
                                CreateRed();
                            }
                            sp2.Play();
                        }

                        if (nowIndex == 6) // terminal
                        {
                            timer1.Stop();
                            x.Location = new Point(847, 550 - 100 * nowIndex);
                            this.KeyPreview = false;

                            foreach (Control y in this.Controls) // make glass sent to back
                            {
                                if (y.Tag == "broken_glass")
                                    this.Controls.Remove(y);
                            }
                            ShowFinal();
                        }
                    }
                }
            }
        }

        void CreateGreen()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.green_person2;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(70, 130);
            pictureBox.Location = new Point(700, 600);
            pictureBox.Tag = "player";
            pictureBox.BringToFront();

            this.Controls.Add(pictureBox);
        }

        void CreateRed()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.red_person2;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(70, 130);
            pictureBox.Location = new Point(700, 600);
            pictureBox.Tag = "player";
            pictureBox.BringToFront();
           
            this.Controls.Add(pictureBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(pictureBox13);
            this.Controls.Remove(button1);

            timer1.Start();
            if (turn == 1)
            {
                label_turn.Visible = true;
                label_turn.Text = "紅隊先走";
                label_turn.ForeColor = Color.Red;

                CreateRed();
            }
            else if (turn == 2)
            {
                label_turn.Visible = true;
                label_turn.Text = "綠隊先走";
                label_turn.ForeColor = Color.Green;

                CreateGreen();
            }
        }

        void GlassBroken(int left,int top)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BackColor = Color.Black;
            pictureBox.Size = new Size(80, 80);
            pictureBox.Location = new Point(left, top);
            pictureBox.Tag = "broken_glass";
            pictureBox.BringToFront();
            this.Controls.Add(pictureBox);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            wplayer.controls.stop();
            Game3 game3 = new Game3();
            this.Hide();
            game3.Show();
        }

        void ShowFinal()
        {
            timer_green.Stop();
            timer_red.Stop();
           
            foreach (Control x in this.Controls) // make glass sent to back
            {
                if (x.Tag == "broken_glass")
                    this.Controls.Remove(x);
            }
            
            foreach (Control x in this.Controls)
            {
                if(x.Tag == "final")
                    x.Visible = true;
            }

            label_rNum.Text = Game1.redTeam.ToString();
            label_gNum.Text = Game1.greenTeam.ToString();
            label_total.Text = Game1.totalMoney.ToString();
        }
    }
}
