namespace Pong_Game_1__Winform_
{
    partial class Form2Multi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Multi));
            this.bola3 = new System.Windows.Forms.PictureBox();
            this.bola4 = new System.Windows.Forms.PictureBox();
            this.bola2 = new System.Windows.Forms.PictureBox();
            this.bola1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bola3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bola4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bola2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bola1)).BeginInit();
            this.SuspendLayout();
            // 
            // bola3
            // 
            this.bola3.BackColor = System.Drawing.Color.Transparent;
            this.bola3.Image = ((System.Drawing.Image)(resources.GetObject("bola3.Image")));
            this.bola3.Location = new System.Drawing.Point(407, 212);
            this.bola3.Name = "bola3";
            this.bola3.Size = new System.Drawing.Size(160, 160);
            this.bola3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bola3.TabIndex = 5;
            this.bola3.TabStop = false;
            this.bola3.Click += new System.EventHandler(this.bola3_Click);
            // 
            // bola4
            // 
            this.bola4.BackColor = System.Drawing.Color.Transparent;
            this.bola4.Image = ((System.Drawing.Image)(resources.GetObject("bola4.Image")));
            this.bola4.Location = new System.Drawing.Point(603, 212);
            this.bola4.Name = "bola4";
            this.bola4.Size = new System.Drawing.Size(160, 160);
            this.bola4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bola4.TabIndex = 4;
            this.bola4.TabStop = false;
            this.bola4.Click += new System.EventHandler(this.bola4_Click);
            // 
            // bola2
            // 
            this.bola2.BackColor = System.Drawing.Color.Transparent;
            this.bola2.Image = ((System.Drawing.Image)(resources.GetObject("bola2.Image")));
            this.bola2.Location = new System.Drawing.Point(218, 212);
            this.bola2.Name = "bola2";
            this.bola2.Size = new System.Drawing.Size(160, 160);
            this.bola2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bola2.TabIndex = 2;
            this.bola2.TabStop = false;
            this.bola2.Click += new System.EventHandler(this.bola2_Click);
            // 
            // bola1
            // 
            this.bola1.BackColor = System.Drawing.Color.Transparent;
            this.bola1.Image = ((System.Drawing.Image)(resources.GetObject("bola1.Image")));
            this.bola1.Location = new System.Drawing.Point(28, 212);
            this.bola1.Name = "bola1";
            this.bola1.Size = new System.Drawing.Size(160, 160);
            this.bola1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bola1.TabIndex = 1;
            this.bola1.TabStop = false;
            this.bola1.Click += new System.EventHandler(this.bola1_Click);
            // 
            // Form2Multi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 442);
            this.Controls.Add(this.bola3);
            this.Controls.Add(this.bola4);
            this.Controls.Add(this.bola2);
            this.Controls.Add(this.bola1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form2Multi";
            this.Text = "Choose A Ball";
            ((System.ComponentModel.ISupportInitialize)(this.bola3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bola4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bola2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bola1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox bola1;
        private System.Windows.Forms.PictureBox bola2;
        private System.Windows.Forms.PictureBox bola4;
        private System.Windows.Forms.PictureBox bola3;
    }
}