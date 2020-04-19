using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarhammerHelper.Class;

namespace WarhammerHelper
{
    public partial class ArmyCreatorForm : Form
    {
        Battle gameBattle;
        public ArmyCreatorForm(Battle gameBattle)
        {
            this.gameBattle = gameBattle;
            InitializeComponent();
        }

        private void fightButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxSelectNbArmy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = int.Parse(comboBoxSelectNbArmy.Text);
            int difference = choice - gameBattle.nbArmy;
            for (int i = 0; i < Math.Abs(difference); i++)
            {
                if (difference > 0)
                {
                    gameBattle.AddArmy();
                }
                if (difference < 0)
                {
                    gameBattle.RemoveArmy();
                }
            }
        }
    }
}
