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
    public partial class GameForm : Form
    {
        Battle gameBattle;

        public GameForm(Battle gameBattle)
        {
            this.gameBattle = gameBattle;
            InitializeComponent();
            UpdateLayout();
        }

        void UpdateLayout()
        {
            int nbArmyInGame = gameBattle.GetNbArmy();

            if (nbArmyInGame == 2)
            {
                this.battleTableLayout.ColumnCount = 2;
                this.battleTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            }
            if (nbArmyInGame > 2 )
            {
                // Add a column
                this.battleTableLayout.ColumnCount = 2;
                this.battleTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

                // Add a Row
                this.battleTableLayout.RowCount = 2;
                this.battleTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            }
        }
        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
