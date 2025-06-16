using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pong_Game_1__Winform_.Properties;

namespace Pong_Game_1__Winform_
{
    public partial class Pong : Form
    {
        //CATATAN: Player1 di kiri (tombol w & s), CPU di kanan (tombol panah atas & panah bawah)

        // Location variables
        //cpuDirection code HARUS AKTIF JIKA INGIN SINGLE PLAYER MODE
        int cpuDirection = 5; // speed of (cpu paddles) (5 itu kyk brp pixel moving)

        int ballXCoordinate = 4; // speed of ball
        int ballYCoordinate = 4; // speed of ball

        // Score variables
        int playerScore = 0;
        int cpuScore = 0;

        // Size variables
        int bottomBoundary; // jd papan tidak bs melewati garis bawah/ klo mentok ya stop (khusus paddles bkn bola(?))
        int centerPoint; // titik tengah
        int xMidpoint;
        int yMidpoint;

        // Detection Variables (utk detect the paddles is going up/down)
        bool playerDetectedUp;
        bool playerDetectedDown;
        //NEW
        bool cpuDetectedUp;
        bool cpuDetectedDown;

        // Special keys
        int spaceBarClicked = 0; // klo spacebar dipencet > pause game

        public Pong()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - player1.Height; // paddle bisa going up/down sepanjang tinggi windows (tab) - panjang paddle itu sndiri
            xMidpoint = ClientSize.Width / 2; // titik tengah sb x
            yMidpoint = ClientSize.Height / 2; // titik tengah sb y

            // pjg papan bottom boundary udh dihitung, klo bola blm jd hrs +pongball.height/width

        }

        private void Pong_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pongTimer_Tick(object sender, EventArgs e) // every 20 ms what happen maka code inside will run, utk detect apakah bola kluar arena dsb
        {
            Random newBallSpot = new Random(); // spawn bola random
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100); // clientsize-100 spy spawn bola ga terlalu dekat dgn sisi windows


            // Adjust where the ball is (we need to make the ball move every single time the tick fire)
            pongBall.Top -= ballYCoordinate; //pongBall.Top > the top side of the picture box, -= ballYCoordinate(5) so evrytime is ticking just subtract 4 from top of pcture box (moving down)
            pongBall.Left -= ballXCoordinate;


            //LINE OF CODE YANG HARUS DIAKTIFKAN JIKA INGIN SINGLE PLAYER MODE
            //BATAS AWAL
            // Make the CPU move
            cpuPlayer.Top += cpuDirection; //each time the timer is ticking, the cpu paddle is going up by 5 until it mentok lalu kebawah
           
            // Make CPU better at the game, the higher the playerScore
            if (playerScore > 5)
            {
                cpuPlayer.Top = pongBall.Top + 30;
            }
            
            // Check if cpu (paddle) has reached the top or the bottom
            if (cpuPlayer.Top < 0 || cpuPlayer.Top > bottomBoundary) //0 is gonna be the top of the screen. 
            {
                cpuDirection = -cpuDirection; // klo ke atas mentok maka ke bawah vice versa
            }
            //BATAS AKHIR


            // Check if the ball has exited the left side of the screen
            if (pongBall.Left < 0)
            {
                pongBall.Left = xMidpoint; //spawn ditengah titik x
                pongBall.Top = newSpot; //spawn pd height yg random di sb y
                ballXCoordinate = -ballXCoordinate; //-5 unit to the other direction, so it moves to the opposite direction  > klo di badmin kyk ganti servis ke lwan kalah
               
                if (playerScore < 5) // to make the ball faster, -2 karena respawn ke kanan
                { 
                    ballXCoordinate -= 1; 
                }
               
                cpuScore++;
                cpuScoreLabel.Text = cpuScore.ToString();
            }
            // Check if the ball has exited the right side of the screen
            if (pongBall.Left + pongBall.Width > ClientSize.Width) //+ pongBall.Width agar saat bola nyentuh sisi kanan maka terhitung score, klo gada maka bola ndelep ke kanan bru score
            {
                pongBall.Left = xMidpoint; //spawn ditengah titik x
                pongBall.Top = newSpot; //spawn pd height yg random di sb y
                ballXCoordinate = -ballXCoordinate; //-5 unit to the other direction, so it moves to the opposite direction  > klo di badmin kyk ganti servis ke lwan kalah

                if (playerScore < 5) // to make the ball faster after respawn, +2 krn respawn ke kiri
                {
                    ballXCoordinate += 1;
                }

                playerScore++;
                playerScoreLabel.Text = playerScore.ToString();
            }

            // Ensure the ball is within the boundaries of the screen (mastiin bola msi dlm boundaries sb y)
            if (pongBall.Top < 0 || pongBall.Top + pongBall.Height > ClientSize.Height)
            {
                ballYCoordinate = -ballYCoordinate; // makes the ball bounce
            }

            // Check if the ball hits the player or CPU paddle
            if (pongBall.Bounds.IntersectsWith(player1.Bounds) || pongBall.Bounds.IntersectsWith(cpuPlayer.Bounds)) //bounds itu maksudnya utk boundary pda objek yg dmksd
            {
                // Generate a random color for player(mengganti warna paddle setiap kena bola)
                Random rand = new Random();
                int r = rand.Next(256);
                int g = rand.Next(256);
                int b = rand.Next(256);
                Color c = Color.FromArgb(r, g, b);

                // Generate a random color for CPU
                int r2 = rand.Next(256);
                int g2 = rand.Next(256);
                int b2 = rand.Next(256);
                Color c2 = Color.FromArgb(r2, g2, b2);

                // Change the color of the paddle
                player1.BackColor = c;
                cpuPlayer.BackColor = c2;

                // Send ball opposite direction (mantul)
                ballXCoordinate = -ballXCoordinate;
            }


            // Move player 1 up
            if (playerDetectedUp == true && player1.Top > 0) //player1.Top > 0 mastiin blm mentok di atas
            {
                player1.Top -= 10; //jd every tick of the timer when we hold the arrow key upwards, paddle moves 10 unit
            }
            // Move player 1 down
            if (playerDetectedDown == true && player1.Top < bottomBoundary)
            {
                player1.Top += 10; //jd every tick of the timer when we hold the arrow key downwards, paddle moves 10 unit down
            }


            //LINE OF CODE YANG HARUS DIAKTIFKAN JIKA INGIN MULTIPLAYER MODE
            ////BATAS AWAL
            //// Move player 2 up
            //if (cpuDetectedUp == true && cpuPlayer.Top > 0) 
            //{
            //    cpuPlayer.Top -= 10; 
            //}
            //// Move player 2 down
            //if (cpuDetectedDown == true && cpuPlayer.Top < bottomBoundary)
            //{
            //    cpuPlayer.Top += 10; 
            //}
            ////BATAS AKHIR



            // Check for winner (max score 10)
            if (playerScore >= 10)
            {
                pongTimer.Stop();

                //BUAT RESET KALAU MAU MAIN LAGI
                //reset score
                playerScore = 0;
                cpuScore = 0;
                playerScoreLabel.Text = playerScore.ToString();
                cpuScoreLabel.Text = cpuScore.ToString();
                //reset kecepatan bola
                ballXCoordinate = 4;
                ballYCoordinate = 4;
                //spawn ulang
                Random newBallSpot_ = new Random();
                int newSpot_ = newBallSpot_.Next(100, ClientSize.Height - 100);
                pongBall.Left = xMidpoint;
                pongBall.Top = newSpot_;
                //arah servis bola random setelah spawn
                Random arahServis = new Random();
                int servis = arahServis.Next(2);
                if (servis == 0)
                {
                    ballXCoordinate = +ballXCoordinate;
                }
                else if (servis == 1)
                {
                    ballXCoordinate = -ballXCoordinate;
                }

                Form player1W = new player1Win();
                player1W.Owner = this;
                player1W.Show(); //show the form
            }

            if (cpuScore >= 10)
            {
                pongTimer.Stop();

                //BUAT RESET KALAU MAU MAIN LAGI
                //reset score
                playerScore = 0;
                cpuScore = 0;
                playerScoreLabel.Text = playerScore.ToString();
                cpuScoreLabel.Text = cpuScore.ToString();
                //reset kecepatan bola
                ballXCoordinate = 4;
                ballYCoordinate = 4;
                //spawn ulang
                Random newBallSpot_ = new Random();
                int newSpot_ = newBallSpot_.Next(100, ClientSize.Height - 100);
                pongBall.Left = xMidpoint;
                pongBall.Top = newSpot_;
                //arah servis bola random setelah spawn
                Random arahServis = new Random();
                int servis = arahServis.Next(2);
                if (servis == 0)
                {
                    ballXCoordinate = +ballXCoordinate;
                }
                else if (servis == 1)
                {
                    ballXCoordinate = -ballXCoordinate;
                }

                Form player2W = new player2Win();
                player2W.Owner = this;
                player2W.Show(); //show the form
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) // utk deteksi klo org sudah ga nekan arrow
        {

            if (e.KeyCode == Keys.W)
            {
                playerDetectedUp = false;
            }

            if (e.KeyCode == Keys.S)
            {
                playerDetectedDown = false;
            }

            ////LINE OF CODE YANG HARUS DIAKTIFKAN JIKA INGIN MULTIPLAYER MODE
            ////BATAS AWAL
            //if (e.KeyCode == Keys.Up)
            //{
            //    cpuDetectedUp = false;
            //}

            //if (e.KeyCode == Keys.Down)
            //{
            //    cpuDetectedDown = false;
            //}
            ////BATAS AKHIR
            
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            // If player 1 presses the up arrow, move paddles upwards
            if (e.KeyCode == Keys.W)
            {
                playerDetectedUp = true;
            }
            // If player 1 presses the down arrow, move paddles downwards
            if (e.KeyCode == Keys.S)
            {
                playerDetectedDown = true;
            }

            //LINE OF CODE YANG HARUS DIAKTIFKAN JIKA INGIN MULTIPLAYER MODE
            ////BATAS AWAL
            //// If player 2 presses the W key, move paddles upwards
            //if (e.KeyCode == Keys.Up)
            //{
            //    cpuDetectedUp = true;
            //}
            //// If player 2 presses the S key, move paddles downwards
            //if (e.KeyCode == Keys.Down)
            //{
            //    cpuDetectedDown = true;
            //}
            ////BATAS AKHIR

            // If player presses the C key, open the character selection screen
            if (e.KeyCode == Keys.C)
            {
                Form character = new CharacterForm();
                character.Owner = this; //jd pemilik new formnya adalah kita
                pongTimer.Stop(); //game berhenti
                character.Show(); //show the form
            }

            // If player presses spacebar, pause the game
            if (e.KeyCode == Keys.Space)
            {

                if (spaceBarClicked %  2 == 0) //gtw knp tp anggap aja ktika klik start, spcae bar auto terklik sekali
                {
                    pongTimer.Stop();
                }
                else
                {
                    pongTimer.Start();
                }

                spaceBarClicked++;
            }

            //R for reset game
            if (e.KeyCode == Keys.R)
            {
                //reset score
                playerScore = 0;
                cpuScore = 0;
                playerScoreLabel.Text = playerScore.ToString();
                cpuScoreLabel.Text = cpuScore.ToString();

                //reset kecepatan bola
                ballXCoordinate = 4; 
                ballYCoordinate = 4;

                //spawn ulang
                Random newBallSpot = new Random();
                int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
                pongBall.Left = xMidpoint; 
                pongBall.Top = newSpot;
                
                //arah servis bola random setelah spawn
                Random arahServis = new Random();
                int servis = arahServis.Next(2); 
                if (servis == 0)
                {
                    ballXCoordinate = +ballXCoordinate;
                }
                else if (servis == 1)
                {
                    ballXCoordinate = -ballXCoordinate;
                }
            }

            //M for multiplayer mode
            if (e.KeyCode == Keys.M)
            {
                pongTimer.Stop();
                this.Hide();
                Form multiPlayer = new FormMulti();
                multiPlayer.Owner = this;
                multiPlayer.Show();
            }
            //N for singleplayer mode
            if (e.KeyCode == Keys.N)
            { 
                //nothing to change krn udah single mode
            }

            //game over
            if (e.KeyCode == Keys.Escape)
            {
                pongTimer.Stop();
                this.Hide();
                Form GameOver = new GameOver();
                GameOver.Owner = this;
                GameOver.Show(); // show the form
            }

            //ganti court
            if (e.KeyCode == Keys.L)
            {
                Form court = new ChooseCourt();
                court.Owner = this;
                pongTimer.Stop();
                court.Show();
            }

            //open feature list
            if (e.KeyCode == Keys.X)
            {
                pongTimer.Stop();
                Form feature = new PauseOption();
                feature.Owner = this;
                feature.Show();
            }

             
            
        }
















































        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
