namespace Pong_Game_1__Winform_
{
    partial class Pong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.cpuScoreLabel = new System.Windows.Forms.Label();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            this.pongBall = new System.Windows.Forms.PictureBox();
            this.cpuPlayer = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerScoreLabel.Font = new System.Drawing.Font("Cascadia Mono", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLabel.ForeColor = System.Drawing.Color.Blue;
            this.playerScoreLabel.Location = new System.Drawing.Point(381, 57);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(55, 55);
            this.playerScoreLabel.TabIndex = 4;
            this.playerScoreLabel.Text = "0";
            // 
            // cpuScoreLabel
            // 
            this.cpuScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuScoreLabel.Font = new System.Drawing.Font("Cascadia Mono", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.cpuScoreLabel.Location = new System.Drawing.Point(608, 57);
            this.cpuScoreLabel.Name = "cpuScoreLabel";
            this.cpuScoreLabel.Size = new System.Drawing.Size(55, 55);
            this.cpuScoreLabel.TabIndex = 5;
            this.cpuScoreLabel.Text = "0";
            // 
            // pongTimer
            // 
            this.pongTimer.Enabled = true;
            this.pongTimer.Interval = 10;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // pongBall
            // 
            this.pongBall.BackColor = System.Drawing.Color.Transparent;
            this.pongBall.Image = ((System.Drawing.Image)(resources.GetObject("pongBall.Image")));
            this.pongBall.Location = new System.Drawing.Point(512, 210);
            this.pongBall.Name = "pongBall";
            this.pongBall.Size = new System.Drawing.Size(28, 28);
            this.pongBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pongBall.TabIndex = 2;
            this.pongBall.TabStop = false;
            // 
            // cpuPlayer
            // 
            this.cpuPlayer.BackColor = System.Drawing.Color.Lime;
            this.cpuPlayer.Location = new System.Drawing.Point(1027, 278);
            this.cpuPlayer.Name = "cpuPlayer";
            this.cpuPlayer.Size = new System.Drawing.Size(12, 106);
            this.cpuPlayer.TabIndex = 1;
            this.cpuPlayer.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Blue;
            this.player1.Location = new System.Drawing.Point(12, 159);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(12, 106);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            this.player1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(453, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1052, 644);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(931, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Press X for Options";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 638);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pongBall);
            this.Controls.Add(this.cpuScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.cpuPlayer);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1069, 685);
            this.MinimumSize = new System.Drawing.Size(1069, 685);
            this.Name = "Pong";
            this.Text = "Pong (Single Player)";
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox cpuPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label cpuScoreLabel;
        public System.Windows.Forms.PictureBox pongBall;
        public System.Windows.Forms.Timer pongTimer;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

