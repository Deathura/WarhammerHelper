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
using WarhammerHelper.Class.Layout;

namespace WarhammerHelper
{
    public partial class GameForm : Form
    {
        Battle gameBattle;
        BattleLayout gameBattleLayout;

        public GameForm(Battle gameBattle)
        {
            this.gameBattle = gameBattle;
            gameBattleLayout = new BattleLayout(this, gameBattle.battleName, gameBattle.nbArmy);
            //gameBattleLayout.AddArmyLayout();
            //gameBattleLayout.AddArmyLayout();
            //gameBattleLayout.AddArmyLayout();
            //gameBattleLayout.AddArmyLayout();

            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
