using System.Drawing.Drawing2D;

namespace Licenta
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, shooting, isGameOver = false, goUp, goDown;
        int score;
        int playerSpeed = 20;
        int enemySpeed;
        int bullet1Speed;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }
        public Bitmap RotateImage(Bitmap inputImage, float angleDegrees)
        {

            Matrix matrix = new Matrix();
            matrix.RotateAt(angleDegrees, new PointF(inputImage.Width / 2, inputImage.Height / 2));

            Bitmap rotatedImage = new Bitmap(inputImage.Width, inputImage.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.Transform = matrix;
                float xOffset = (inputImage.Width - rotatedImage.Width) / 2f;
                float yOffset = (inputImage.Height - rotatedImage.Height) / 2f;
                g.DrawImage(inputImage, xOffset, yOffset, rotatedImage.Width, rotatedImage.Height);
            }

            return rotatedImage;
        }
        private void Respawn()
        {
            if (bullet.Bounds.IntersectsWith(enemyOne.Bounds) || bullet2.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                enemyOne.Image = (Image)RotateImage((Bitmap)enemyOne.Image, 60);
                score += 1;
                enemyOne.Top = -450;
                enemyOne.Left = rnd.Next(20, 600);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyTwo.Bounds) || bullet2.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                enemyTwo.Image = (Image)RotateImage((Bitmap)enemyTwo.Image, 90);
                score += 1;
                enemyTwo.Top = -650;
                enemyTwo.Left = rnd.Next(20, 600);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyThree.Bounds) || bullet2.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                enemyThree.Image = (Image)RotateImage((Bitmap)enemyThree.Image, 30);
                score += 1;
                enemyThree.Top = -750;
                enemyThree.Left = rnd.Next(20, 600);
                shooting = false;
            }
            while (enemyOne.Bounds.IntersectsWith(enemyTwo.Bounds) ||  //collision checker
                   enemyTwo.Bounds.IntersectsWith(enemyThree.Bounds) ||
                   enemyOne.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                enemyOne.Left = rnd.Next(20, 600);
                enemyTwo.Left = rnd.Next(20, 600);
                enemyThree.Left = rnd.Next(20, 600);
            }
        }
        private void playerMovement()
        {
            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 688)
            {
                player.Left += playerSpeed;
            }
            if (goUp == true && player.Top > 160)
            {
                player.Top -= playerSpeed;
            }
            if (goDown == true && player.Top < 580)
            {
                player.Top += playerSpeed;
            }
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                bullet.Top = player.Top - 30;
                bullet.Left = player.Left + (player.Width / 2) + 50;
                bullet2.Top = player.Top - 30;
                bullet2.Left = player.Left + (player.Width / 2) - 50;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                ResetGame();
            }
        }
        private void ResetGame()
        {
            player.Location = new Point(436, 657);

            endingLabel.Visible = false;
            gameTimer.Start();
            enemySpeed = 4;


            enemyOne.Left = rnd.Next(20, 600);
            enemyTwo.Left = rnd.Next(20, 600);
            enemyThree.Left = rnd.Next(20, 600);

            enemyOne.Top = rnd.Next(0, 200) * -1;
            enemyTwo.Top = rnd.Next(0, 500) * -1;
            enemyThree.Top = rnd.Next(0, 900) * -1;

            score = 0;
            bullet1Speed = 0;
            bullet.Left = -300;
            shooting = false;

            isGameOver = false;
            txtScore.Text = score.ToString();

        }
        private void GameOver()
        {   
           
            isGameOver = true;
            gameTimer.Stop();
            endingLabel.Text = "";
            endingLabel.Text += Environment.NewLine + "Game Over..." + Environment.NewLine + "Press Enter to try again.";
            endingLabel.Visible = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score.ToString();
            enemyOne.Top += enemySpeed;
            enemyTwo.Top += enemySpeed;
            enemyThree.Top += enemySpeed;
            if (enemyOne.Top > 710 || enemyTwo.Top > 710 || enemyThree.Top > 710)
            {
                GameOver();
            }

            playerMovement();

            if (shooting == true)
            {
                bullet1Speed = 20;
                bullet.Top -= bullet1Speed;

                bullet2.Top -= bullet1Speed;
            }
            else
            {
                bullet.Left = -300;
                bullet1Speed = 0;
                bullet2.Left = -300;

            }
            if (bullet.Top < -30 || bullet2.Top < -30)
            {
                shooting = false;
            }

            Respawn();

            if (player.Bounds.IntersectsWith(enemyOne.Bounds) || player.Bounds.IntersectsWith(enemyTwo.Bounds) || player.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                GameOver();
            }
            if (score == 5)
            {
                enemySpeed = 6;
            }
            if (score == 10)
            {
                enemySpeed = 8;
            }
        }
    }
}
