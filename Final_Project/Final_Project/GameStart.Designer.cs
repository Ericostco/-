
namespace Final_Project
{
    partial class GameStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameStart));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_enterGame = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_enterGame
            // 
            this.label_enterGame.AutoSize = true;
            this.label_enterGame.BackColor = System.Drawing.Color.Gainsboro;
            this.label_enterGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_enterGame.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_enterGame.ForeColor = System.Drawing.Color.Black;
            this.label_enterGame.Location = new System.Drawing.Point(375, 343);
            this.label_enterGame.MaximumSize = new System.Drawing.Size(500, 100);
            this.label_enterGame.MinimumSize = new System.Drawing.Size(150, 80);
            this.label_enterGame.Name = "label_enterGame";
            this.label_enterGame.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.label_enterGame.Size = new System.Drawing.Size(231, 80);
            this.label_enterGame.TabIndex = 0;
            this.label_enterGame.Text = "進入遊戲";
            this.label_enterGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_enterGame.Click += new System.EventHandler(this.label_enterGame_Click);
            this.label_enterGame.MouseLeave += new System.EventHandler(this.label_enterGame_MouseLeave);
            this.label_enterGame.MouseHover += new System.EventHandler(this.label_enterGame_MouseHover);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(386, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "我要參加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // GameStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_enterGame);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GameStart";
            this.Text = "掙錢遊戲";
            this.Load += new System.EventHandler(this.GameStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_enterGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
    }
}