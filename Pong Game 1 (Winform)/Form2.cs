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
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

         private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void bola1_Click(object sender, EventArgs e) // bola basket
        {
            //sblmnya gmbr pongBall di form1 hrs di set ke public dulu agar smua form bisa mendeteksi pongBall
            //BISA DIGANTI SESUAI FILE DI LAPTOP, gunakan copy as path pada foto di file explorer
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"D:\Users\jevon (Data D)\Loker Kuliah\Coding C# Kuliah\Pong Game 1 (Winform) - FINAL MODIF\Attributes pong games\Basketball_For_Pong.png");
            //sblmnya timer di form1 hrs di set ke public dulu
            (this.Owner as Pong).pongTimer.Start(); //utk start game sesudah milih bola
            this.Hide(); //to hide the form
        }

        private void bola2_Click(object sender, EventArgs e) // bola sepak
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"D:\Users\jevon (Data D)\Loker Kuliah\Coding C# Kuliah\Pong Game 1 (Winform) - FINAL MODIF\Attributes pong games\Soccerball_For_Pong.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void bola3_Click(object sender, EventArgs e) // bola tennis
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"D:\Users\jevon (Data D)\Loker Kuliah\Coding C# Kuliah\Pong Game 1 (Winform) - FINAL MODIF\Attributes pong games\Tennisball_For_Pong.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide(); 
        }

        private void bola4_Click(object sender, EventArgs e) // bola volly
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"D:\Users\jevon (Data D)\Loker Kuliah\Coding C# Kuliah\Pong Game 1 (Winform) - FINAL MODIF\Attributes pong games\Volleyball_For_Pong.png");
            (this.Owner as Pong).pongTimer.Start(); 
            this.Hide(); 
        }

        private void CharacterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
