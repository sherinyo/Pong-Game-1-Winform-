using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Game_1__Winform_
{
    public partial class ChooseCourtMulti : Form
    {
        public ChooseCourtMulti()
        {
            InitializeComponent();
        }

        private void basketCourt_Click(object sender, EventArgs e) // option lapangan basket
        {
            //file courtnya blm diubah ke yg bener
            (this.Owner as FormMulti).pictureBox2.Image = Image.FromFile(@"D:\Users\jevon (Data D)\Loker Kuliah\Coding C# Kuliah\Pong Game 1 (Winform) - FINAL MODIF\Attributes pong games\BasketCourt.jpeg");
            (this.Owner as FormMulti).BackColor = Color.Peru;
            (this.Owner as FormMulti).pongTimer.Start();
            this.Hide();
        }

        private void tennisCourt_Click(object sender, EventArgs e) // option lapangan tennis
        {
            (this.Owner as FormMulti).pictureBox2.Image = Image.FromFile(@"D:\Users\jevon (Data D)\Loker Kuliah\Coding C# Kuliah\Pong Game 1 (Winform) - FINAL MODIF\Attributes pong games\tennisCourt.jpg");
            (this.Owner as FormMulti).BackColor = Color.LightGreen;
            (this.Owner as FormMulti).pongTimer.Start();
            this.Hide();
        }
    }
}
