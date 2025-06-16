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
    public partial class player2WinMulti : Form
    {
        public player2WinMulti()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void player2Win_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                this.Hide();
                (this.Owner as FormMulti).pongTimer.Start();
                FormMulti.ActiveForm.Show(); //gapake cara new form, owner this, show > spaya ga keopen double
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                Form GameOver = new GameOver();
                GameOver.Owner = this;
                GameOver.Show(); // show the form
            }
        }
    }
}
