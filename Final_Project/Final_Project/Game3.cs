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
    public partial class Game3 : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer(); // 加入音檔
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(); // 內建撥放音效
        SoundPlayer sp2 = new SoundPlayer("lion_g3.wav");

        bool pin = false , exit = false; // 未刮的狀態 ; 還沒達到結束標準

        //  刮的總數         輪到哪隊   系統目標 
        int countTotal = 0 , turn = 0 , r = 0 ,  r1 = 0 , r2 = 0 , time = 0;
        
        public Game3()
        {
            InitializeComponent();
        }

        private void Game3_MouseMove(object sender, MouseEventArgs e) // 探針移動
        {
            if(e.X > pictureBox_pin.Left) { pictureBox_pin.Left = e.X; }
            if (e.X < pictureBox_pin.Left) { pictureBox_pin.Left = e.X; }
            if (e.Y > pictureBox_pin.Top) { pictureBox_pin.Top = e.Y - pictureBox_pin.Height; }
            if (e.Y < pictureBox_pin.Top) { pictureBox_pin.Top = e.Y - pictureBox_pin.Height; }
        }

        private void button1_Click(object sender, EventArgs e) // 遊戲介紹完處理
        {
            this.Controls.Remove(pictureBox2);
            this.Controls.Remove(button1);
        }

        private void button3_Click(object sender, EventArgs e) // 比賽結果處理
        {
            if (exit == true) // 遊戲結束
                Application.Exit();

            else // 遊戲還沒達到結束標準
            {
                timer1.Start();

                Random random = new Random();
                r = random.Next(30, 70);
                r1 = random.Next(4, 7);
                r2 = random.Next(9, 13);

                turn = 1; countTotal = 0;  label2.Text = "紅隊攻擊";label2.ForeColor = Color.Red; // 回到紅隊攻擊 ; 重新計數 ; 顯示紅隊攻擊

                pictureBox_lionSay.Visible = false; 
                pictureBox1.Image = Properties.Resources.lion_sleep; // 回到睡覺照片
                foreach (Control x in this.Controls)
                {
                    if(x.Tag == "final")
                        x.Visible = false;
                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e) // 比賽結束時為顯示獅子所說的話
        {
            time++;
            if(time >= 2)
            {
                timer2.Stop();
                time = 0;
                foreach (Control x in this.Controls) // 顯示結果
                {
                    if (x.Tag == "final")
                        x.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // 換隊用
        {
            if (turn == 1)
            {
                label2.Text = "綠隊攻擊";
                label2.ForeColor = Color.Green;
                turn = 2;
            }
                
            else if (turn == 2)
            {
                label2.Text = "紅隊攻擊";
                label2.ForeColor = Color.Red;
                turn = 1;
            }
        }

        private void Game3_MouseDown(object sender, MouseEventArgs e)
        {
            pin = true;

            if (e.X > pictureBox_pin.Left) { pictureBox_pin.Left = e.X; }
            if (e.X < pictureBox_pin.Left) { pictureBox_pin.Left = e.X; }
            if (e.Y > pictureBox_pin.Top) { pictureBox_pin.Top = e.Y - pictureBox_pin.Height; }
            if (e.Y < pictureBox_pin.Top) { pictureBox_pin.Top = e.Y - pictureBox_pin.Height; }
        }

        private void Game3_MouseUp(object sender, MouseEventArgs e) // 進行計數
        {
            if (pin == true) countTotal++;
            pin = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox_lionSay.Visible = false;

            label1.Text = "目前次數：" + countTotal.ToString();

            label_redNum.Text = "剩餘人數：" + Game1.redTeam.ToString();
            label_greenNum.Text = "剩餘人數：" + Game1.greenTeam.ToString();
            label_totalMoney.Text = "累積獎金：" + Game1.totalMoney.ToString();

            if (countTotal == r) // 達標
            {
                // 顯示獅子醒來
                timer1.Stop();
                sp2.Play();
                pictureBox_lionSay.Visible = true;
                pictureBox_lionSay.Image = Properties.Resources.lion_say;
                pictureBox1.Image = Properties.Resources.lion_wake;

                timer2.Start();

                if(turn == 1)
                {
                    if(r < Game1.redTeam)
                    {
                        Game1.redTeam -= r;
                        Game1.totalMoney += r * 10000;
                    }
                    else if(Game1.redTeam <= r)
                    {
                        Game1.totalMoney += Game1.redTeam * 10000;
                        Game1.redTeam = 0;

                        exit = true;

                        label_result.Text = "綠隊獲勝";
                        label_result.ForeColor = Color.Green;
                        button3.Text = "離開";
                    }

                    label_rNum.Text = Game1.redTeam.ToString();
                    label_gNum.Text = Game1.greenTeam.ToString();
                    label_total.Text = Game1.totalMoney.ToString();
                }

                else if(turn == 2)
                {
                    if (r < Game1.greenTeam)
                    {
                        Game1.greenTeam -= r;
                        Game1.totalMoney += r * 10000;
                    }
                    else if (Game1.greenTeam <= r)
                    {
                        Game1.totalMoney += Game1.greenTeam * 10000;
                        Game1.greenTeam = 0;

                        exit = true;

                        label_result.Text = "紅隊獲勝";
                        label_result.ForeColor = Color.Red;
                        button3.Text = "離開";
                    }

                    label_rNum.Text = Game1.redTeam.ToString();
                    label_gNum.Text = Game1.greenTeam.ToString();
                    label_total.Text = Game1.totalMoney.ToString();
                }
            }

            // 接近提示
            if(r == countTotal + r1)
            {
                pictureBox_lionSay.Visible = true;
                pictureBox_lionSay.Image = Properties.Resources.wake_up2_G3;
            }

            if(r == countTotal + r2)
            {
                pictureBox_lionSay.Visible = true;
                pictureBox_lionSay.Image = Properties.Resources.wake_up_G3;
            }
            //
        }

        private void Game3_Load(object sender, EventArgs e)
        {
            this.SetBounds(0, 0, 1540, 820);
            wplayer.URL = "background_enter.mp3";
            wplayer.controls.play();

            timer1.Start();

            Random random = new Random();
            r = random.Next(30, 70);
            r1 = random.Next(4, 7);
            r2 = random.Next(9, 13);

            pictureBox1.SendToBack();
            pictureBox_pin.BringToFront();
            turn = 1;
        }
    }
}
