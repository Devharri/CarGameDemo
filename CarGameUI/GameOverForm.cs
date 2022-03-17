using System;
using System.Windows.Forms;
using DemoLibrary;

namespace CarGameUI
{
    public partial class GameOverForm : System.Windows.Forms.Form
    {
        int Rank = 0;
        public GameOverForm()
        {
            InitializeComponent();

        }

        private void GameOverForm_Load(object sender, EventArgs e)
        {
            CollectedCoinsLabel.Text = "You got :" + GameWindow.CollectedCoins + " coins!";
            Rank = GetRankHelper.GetRank(GameWindow.CollectedCoins);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HiscoreButton_Click(object sender, EventArgs e)
        {
            HiscoreForm Hiscores = new HiscoreForm();
            Hiscores.ShowDialog();
        }

        private void Timer1Tick(object sender, EventArgs e)
        {
            if (Rank > 0 && Rank < 11)
            {
                timer1.Enabled = false;
                AddNameToHiscoreListForm AddName = new AddNameToHiscoreListForm();
                AddName.ShowDialog();

            }
        }
    }
}
