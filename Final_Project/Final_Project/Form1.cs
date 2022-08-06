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
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer(); // 加入音檔
        int count = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetBounds(0, 0, 1540, 820);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count += 1;
            this.Opacity += .2;

            wplayer.URL = "background_start.mp3";
            if (count == 5)
            {
                timer1.Stop();
                count = 0;
                wplayer.controls.play();
                timer2.Start();
                
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            count += 1;

            if(count >=  60)
                this.Opacity -= .2;

            if(this.Opacity == 0)
            {
                timer2.Stop();

                GameStart gameStart = new GameStart();
                gameStart.Show();
                this.Hide();
            }
        }
    }
}
