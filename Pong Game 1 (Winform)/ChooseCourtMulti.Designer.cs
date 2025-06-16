namespace Pong_Game_1__Winform_
{
    partial class ChooseCourtMulti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCourtMulti));
            this.tennisCourt = new System.Windows.Forms.PictureBox();
            this.basketCourt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tennisCourt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketCourt)).BeginInit();
            this.SuspendLayout();
            // 
            // tennisCourt
            // 
            this.tennisCourt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tennisCourt.BackgroundImage")));
            this.tennisCourt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tennisCourt.Location = new System.Drawing.Point(378, 136);
            this.tennisCourt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tennisCourt.Name = "tennisCourt";
            this.tennisCourt.Size = new System.Drawing.Size(290, 151);
            this.tennisCourt.TabIndex = 2;
            this.tennisCourt.TabStop = false;
            this.tennisCourt.Click += new System.EventHandler(this.tennisCourt_Click);
            // 
            // basketCourt
            // 
            this.basketCourt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("basketCourt.BackgroundImage")));
            this.basketCourt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.basketCourt.Location = new System.Drawing.Point(43, 136);
            this.basketCourt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.basketCourt.Name = "basketCourt";
            this.basketCourt.Size = new System.Drawing.Size(290, 151);
            this.basketCourt.TabIndex = 1;
            this.basketCourt.TabStop = false;
            this.basketCourt.Click += new System.EventHandler(this.basketCourt_Click);
            // 
            // ChooseCourtMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.tennisCourt);
            this.Controls.Add(this.basketCourt);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChooseCourtMulti";
            this.Text = "Choose Court";
            ((System.ComponentModel.ISupportInitialize)(this.tennisCourt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketCourt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox basketCourt;
        private System.Windows.Forms.PictureBox tennisCourt;
    }
}