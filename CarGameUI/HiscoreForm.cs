using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGameUI
{
    public partial class HiscoreForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();
        public HiscoreForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HiscoreForm_Load(object sender, EventArgs e)
        {
            people = SqliteDataAccess.LoadPeople();

            WireUpPeopleList();

        }

        private void WireUpPeopleList()
        {
            try
            {
            Name1Label.Text = people[0].Name;
            Score1Label.Text = people[0].Score.ToString();

            Name2Label.Text = people[1].Name;
            Score2Label.Text = people[1].Score.ToString();

            Name3Label.Text = people[2].Name;
            Score3Label.Text = people[2].Score.ToString();

                Name4Label.Text = people[3].Name;
                Score4Label.Text = people[3].Score.ToString();

                Name5Label.Text = people[4].Name;
                Score5Label.Text = people[4].Score.ToString();

                Name6Label.Text = people[5].Name;
                Score6Label.Text = people[5].Score.ToString();

                    Name7Label.Text = people[6].Name;
                    Score7Label.Text = people[6].Score.ToString();

                    Name8Label.Text = people[7].Name;
                    Score8Label.Text = people[7].Score.ToString();

                    Name9Label.Text = people[8].Name;
                    Score9Label.Text = people[8].Score.ToString();
                
                        Name10Label.Text = people[9].Name;
                        Score10Label.Text = people[9].Score.ToString();

            }
            catch
            {
                MessageBox.Show("Something went wrong.");
            }
        }
    }
}
