using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLibrary;

namespace CarGameUI
{
    public partial class AddNameToHiscoreListForm : Form
    {
        int LastId = 0;
        public AddNameToHiscoreListForm()
        {
            InitializeComponent();
        }

        private void AddNameButton_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.SavePerson(AddNameListBox.Text, GameWindow.CollectedCoins, LastId);
            this.Close();
        }

        private void AddNameToHiscoreListForm_Load(object sender, EventArgs e)
        {
            LastId = GetRankHelper.GetLastId();
        }
    }
}
