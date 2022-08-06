
namespace Final_Project
{
    partial class Game3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_pin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_lionSay = new System.Windows.Forms.PictureBox();
            this.label_redNum = new System.Windows.Forms.Label();
            this.label_totalMoney = new System.Windows.Forms.Label();
            this.label_greenNum = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_rNum = new System.Windows.Forms.Label();
            this.label_gNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.label_result = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lionSay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "目前次數：";
            // 
            // pictureBox_pin
            // 
            this.pictureBox_pin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_pin.Image = global::Final_Project.Properties.Resources.pin_G3;
            this.pictureBox_pin.Location = new System.Drawing.Point(1403, 191);
            this.pictureBox_pin.Name = "pictureBox_pin";
            this.pictureBox_pin.Size = new System.Drawing.Size(81, 84);
            this.pictureBox_pin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pin.TabIndex = 0;
            this.pictureBox_pin.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.lion_sleep;
            this.pictureBox1.Location = new System.Drawing.Point(198, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(832, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_lionSay
            // 
            this.pictureBox_lionSay.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_lionSay.Image = global::Final_Project.Properties.Resources.lion_say;
            this.pictureBox_lionSay.Location = new System.Drawing.Point(793, 96);
            this.pictureBox_lionSay.Name = "pictureBox_lionSay";
            this.pictureBox_lionSay.Size = new System.Drawing.Size(336, 179);
            this.pictureBox_lionSay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_lionSay.TabIndex = 3;
            this.pictureBox_lionSay.TabStop = false;
            this.pictureBox_lionSay.Visible = false;
            // 
            // label_redNum
            // 
            this.label_redNum.AutoSize = true;
            this.label_redNum.BackColor = System.Drawing.Color.Transparent;
            this.label_redNum.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_redNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_redNum.Location = new System.Drawing.Point(12, 9);
            this.label_redNum.Name = "label_redNum";
            this.label_redNum.Size = new System.Drawing.Size(155, 36);
            this.label_redNum.TabIndex = 4;
            this.label_redNum.Text = "剩餘人數：";
            // 
            // label_totalMoney
            // 
            this.label_totalMoney.AutoSize = true;
            this.label_totalMoney.BackColor = System.Drawing.Color.Transparent;
            this.label_totalMoney.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_totalMoney.ForeColor = System.Drawing.Color.Blue;
            this.label_totalMoney.Location = new System.Drawing.Point(619, 9);
            this.label_totalMoney.Name = "label_totalMoney";
            this.label_totalMoney.Size = new System.Drawing.Size(155, 36);
            this.label_totalMoney.TabIndex = 5;
            this.label_totalMoney.Text = "累積獎金：";
            // 
            // label_greenNum
            // 
            this.label_greenNum.AutoSize = true;
            this.label_greenNum.BackColor = System.Drawing.Color.Transparent;
            this.label_greenNum.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_greenNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_greenNum.Location = new System.Drawing.Point(1234, 9);
            this.label_greenNum.Name = "label_greenNum";
            this.label_greenNum.Size = new System.Drawing.Size(155, 36);
            this.label_greenNum.TabIndex = 6;
            this.label_greenNum.Text = "剩餘人數：";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.Game3Intro;
            this.pictureBox2.Location = new System.Drawing.Point(138, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1237, 574);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(695, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "了解規則";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(18, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "紅隊攻擊";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(596, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 61);
            this.label3.TabIndex = 45;
            this.label3.Tag = "final";
            this.label3.Text = "比賽結果";
            this.label3.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(607, 596);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 63);
            this.button3.TabIndex = 44;
            this.button3.Tag = "final";
            this.button3.Text = "繼續";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.BackColor = System.Drawing.Color.Silver;
            this.label_total.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_total.ForeColor = System.Drawing.Color.Blue;
            this.label_total.Location = new System.Drawing.Point(614, 478);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(56, 61);
            this.label_total.TabIndex = 43;
            this.label_total.Tag = "final";
            this.label_total.Text = "0";
            this.label_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_total.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(596, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 61);
            this.label6.TabIndex = 42;
            this.label6.Tag = "final";
            this.label6.Text = "累積金額";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // label_rNum
            // 
            this.label_rNum.AutoSize = true;
            this.label_rNum.BackColor = System.Drawing.Color.Silver;
            this.label_rNum.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_rNum.ForeColor = System.Drawing.Color.Red;
            this.label_rNum.Location = new System.Drawing.Point(311, 420);
            this.label_rNum.Name = "label_rNum";
            this.label_rNum.Size = new System.Drawing.Size(56, 61);
            this.label_rNum.TabIndex = 41;
            this.label_rNum.Tag = "final";
            this.label_rNum.Text = "0";
            this.label_rNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_rNum.Visible = false;
            // 
            // label_gNum
            // 
            this.label_gNum.AutoSize = true;
            this.label_gNum.BackColor = System.Drawing.Color.Silver;
            this.label_gNum.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_gNum.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_gNum.Location = new System.Drawing.Point(1011, 420);
            this.label_gNum.Name = "label_gNum";
            this.label_gNum.Size = new System.Drawing.Size(56, 61);
            this.label_gNum.TabIndex = 40;
            this.label_gNum.Tag = "final";
            this.label_gNum.Text = "0";
            this.label_gNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_gNum.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(889, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 61);
            this.label4.TabIndex = 39;
            this.label4.Tag = "final";
            this.label4.Text = "綠隊剩餘人數";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(199, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 61);
            this.label5.TabIndex = 38;
            this.label5.Tag = "final";
            this.label5.Text = "紅隊剩餘人數";
            this.label5.Visible = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox14.Location = new System.Drawing.Point(138, 149);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(1237, 574);
            this.pictureBox14.TabIndex = 37;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "final";
            this.pictureBox14.Visible = false;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.BackColor = System.Drawing.Color.LightGray;
            this.label_result.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_result.Location = new System.Drawing.Point(596, 252);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 61);
            this.label_result.TabIndex = 46;
            this.label_result.Tag = "final";
            this.label_result.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Game3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.Game3Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1522, 773);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_rNum);
            this.Controls.Add(this.label_gNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox_pin);
            this.Controls.Add(this.label_greenNum);
            this.Controls.Add(this.label_totalMoney);
            this.Controls.Add(this.label_redNum);
            this.Controls.Add(this.pictureBox_lionSay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Game3";
            this.Text = "掙錢遊戲";
            this.Load += new System.EventHandler(this.Game3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Game3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game3_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Game3_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lionSay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_pin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_lionSay;
        private System.Windows.Forms.Label label_redNum;
        private System.Windows.Forms.Label label_totalMoney;
        private System.Windows.Forms.Label label_greenNum;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_rNum;
        private System.Windows.Forms.Label label_gNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Timer timer2;
    }
}