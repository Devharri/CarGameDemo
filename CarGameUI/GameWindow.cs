using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace CarGameUI
{
    public partial class GameWindow : System.Windows.Forms.Form
    {
        static int GameSpeed = 0;
        public static int CollectedCoins { get; private set; }
        readonly Random r = new();
        int x;
        public GameWindow()
        {
            InitializeComponent();
        }

        public void MoveCenterLine(int speed)
        {
            if (Line1PictureBox.Top >= 777)
            {
                Line1PictureBox.Top = -48;
            }
            else
            {
                Line1PictureBox.Top += speed;
            }

            if (Line2PictureBox.Top >= 777)
            {
                Line2PictureBox.Top = -48;
            }
            else
            {
                Line2PictureBox.Top += speed;
            }

            if (Line3PictureBox.Top >= 777)
            {
                Line3PictureBox.Top = -48;
            }
            else
            {
                Line3PictureBox.Top += speed;
            }

            if (Line4PictureBox.Top >= 777)
            {
                Line4PictureBox.Top = -48;
            }
            else
            {
                Line4PictureBox.Top += speed;
            }

            if (Line5PictureBox.Top >= 777)
            {
                Line5PictureBox.Top = -48;
            }
            else
            {
                Line5PictureBox.Top += speed;
            }

            if (Line6PictureBox.Top >= 777)
            {
                Line6PictureBox.Top = -48;
            }
            else
            {
                Line6PictureBox.Top += speed;
            }
        }

        public void MoveEnemies(int speed)
        {
            int EnemySpeed;
            if (speed > 2)
            {
                EnemySpeed = speed - 2;
            }
            else
            {
                EnemySpeed = speed;
            }

            if (Enemy1PictureBox.Top >= 777)
            {
                x = r.Next(24, 151);
                Enemy1PictureBox.Location = new Point(x, -48);
                Enemy1PictureBox.Top = -48;

            }
            else
            {
                Enemy1PictureBox.Top += EnemySpeed;
            }

            if (Enemy2PictureBox.Top >= 777)
            {
                x = r.Next(203, 331);
                Enemy2PictureBox.Location = new Point(x, -48);
                Enemy2PictureBox.Top = -48;
            }
            else
            {
                Enemy2PictureBox.Top += EnemySpeed;
            }

            if (Enemy3PictureBox.Top >= 777)
            {
                x = r.Next(120, 218);
                Enemy3PictureBox.Location = new Point(x, -48);
                Enemy3PictureBox.Top = -48;
            }
            else
            {
                Enemy3PictureBox.Top += EnemySpeed;
            }
        }

        public void MoveCoins(int speed)
        {
            int CoinSpeed = speed;


            if (Coin1PictureBox.Top >= 777)
            {
                x = r.Next(0, 331);
                Coin1PictureBox.Location = new Point(x, -48);
                Coin1PictureBox.Top = -48;

            }
            else
            {
                Coin1PictureBox.Top += CoinSpeed;
            }

            if (Coin2PictureBox.Top >= 777)
            {
                x = r.Next(0, 331);
                Coin2PictureBox.Location = new Point(x, -48);
                Coin2PictureBox.Top = -48;
            }
            else
            {
                Coin2PictureBox.Top += CoinSpeed;
            }

            if (Coin3PictureBox.Top >= 777)
            {
                x = r.Next(0, 331);
                Coin3PictureBox.Location = new Point(x, -48);
                Coin3PictureBox.Top = -48;
            }
            else
            {
                Coin3PictureBox.Top += CoinSpeed;
            }

            if (Coin4PictureBox.Top >= 777)
            {
                x = r.Next(0, 331);
                Coin4PictureBox.Location = new Point(x, -48);
                Coin4PictureBox.Top = -48;
            }
            else
            {
                Coin4PictureBox.Top += CoinSpeed;
            }
        }

        public void CollectCoins()
        {
            if (CarPictureBox.Bounds.IntersectsWith(Coin1PictureBox.Bounds))
            {
                x = r.Next(0, 331);
                Coin1PictureBox.Location = new Point(x, -48);
                Coin1PictureBox.Top = -48;
                CollectedCoins++;
                CollectedCoinsLabel.Text = "Coins = " + CollectedCoins.ToString();
                EatSound();
            }

            if (CarPictureBox.Bounds.IntersectsWith(Coin2PictureBox.Bounds))
            {
                x = r.Next(0, 331);
                Coin2PictureBox.Location = new Point(x, -48);
                Coin2PictureBox.Top = -48;
                CollectedCoins++;
                CollectedCoinsLabel.Text = "Coins = " + CollectedCoins.ToString();
                EatSound();
            }

            if (CarPictureBox.Bounds.IntersectsWith(Coin3PictureBox.Bounds))
            {
                x = r.Next(0, 331);
                Coin3PictureBox.Location = new Point(x, -48);
                Coin3PictureBox.Top = -48;
                CollectedCoins++;
                CollectedCoinsLabel.Text = "Coins = " + CollectedCoins.ToString();
                EatSound();
            }

            if (CarPictureBox.Bounds.IntersectsWith(Coin4PictureBox.Bounds))
            {
                x = r.Next(0, 331);
                Coin4PictureBox.Location = new Point(x, -48);
                Coin4PictureBox.Top = -48;
                CollectedCoins++;
                CollectedCoinsLabel.Text = "Coins = " + CollectedCoins.ToString();
                EatSound();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveCenterLine(GameSpeed);
            MoveEnemies(GameSpeed);
            MoveCoins(GameSpeed);
            CollectCoins();
            GameOver();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (CarPictureBox.Left > 25)
                {
                    CarPictureBox.Left += -GameSpeed;
                }

            }

            if (e.KeyCode == Keys.Right)
            {
                if (CarPictureBox.Right < 363)
                {
                    CarPictureBox.Left += GameSpeed;
                }

            }

            if (e.KeyCode == Keys.Up)
            {
                if (GameSpeed < 21)
                {
                    GameSpeed++;
                }

            }

            if (e.KeyCode == Keys.Down)
            {
                if (GameSpeed > 0)
                {
                    GameSpeed--;
                }

            }
        }

        public void EatSound()
        {
            SoundPlayer Sound1 = new SoundPlayer(CarGameUI.Properties.Resources.EatingSound);
            Sound1.Play();
        }

        public void CrashSound()
        {
            SoundPlayer Sound2 = new SoundPlayer(CarGameUI.Properties.Resources.ExplosionSound);
            Sound2.Play();
        }
        public void GameOver()
        {
            if (CarPictureBox.Bounds.IntersectsWith(Enemy1PictureBox.Bounds))
            {
                CrashSound();
                timer1.Enabled = false;
                GameOverForm GameOver = new GameOverForm();
                GameOver.ShowDialog();
            }

            if (CarPictureBox.Bounds.IntersectsWith(Enemy2PictureBox.Bounds))
            {           
                CrashSound();
                timer1.Enabled = false;
                GameOverForm GameOver = new GameOverForm();
                GameOver.ShowDialog();
            }


            if (CarPictureBox.Bounds.IntersectsWith(Enemy3PictureBox.Bounds))
            {
                CrashSound();
                timer1.Enabled = false;
                GameOverForm GameOver = new GameOverForm();
                GameOver.ShowDialog();
                
            }


        }

        private void GameWindow_Activated(object sender, EventArgs e)
        {
            GameSpeed = 1;
            CollectedCoins = 0;
            x = 0;
            timer1.Enabled = true;

            x = r.Next(24, 151);
            Enemy1PictureBox.Location = new Point(x, -48);
            Enemy1PictureBox.Top = -348;

            x = r.Next(203, 331);
            Enemy2PictureBox.Location = new Point(x, -48);
            Enemy2PictureBox.Top = -648;

            x = r.Next(120, 218);
            Enemy3PictureBox.Location = new Point(x, -48);
            Enemy3PictureBox.Top = -48;

            x = r.Next(0, 331);
            Coin1PictureBox.Location = new Point(x, -48);
            Coin1PictureBox.Top = -148;

            x = r.Next(0, 331);
            Coin2PictureBox.Location = new Point(x, -48);
            Coin2PictureBox.Top = -248;

            x = r.Next(0, 331);
            Coin3PictureBox.Location = new Point(x, -48);
            Coin3PictureBox.Top = -348;

            x = r.Next(0, 331);
            Coin4PictureBox.Location = new Point(x, -48);
            Coin4PictureBox.Top = -448;

            CollectedCoinsLabel.Text = "Coins = " + CollectedCoins.ToString();
        }
    }
}
