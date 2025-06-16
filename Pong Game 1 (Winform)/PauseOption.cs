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
    public partial class PauseOption : Form
    {
        public PauseOption()
        {
            InitializeComponent();
        }

        private void penjelasan_Click(object sender, EventArgs e)
        {

        }

        private void PauseOption_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X)
            {
                (this.Owner as Pong).pongTimer.Start();
                this.Hide();
            }
            else
            {
                (this.Owner as Pong).pongTimer.Start();
                this.Hide();
            }
            
        }
    }
}
