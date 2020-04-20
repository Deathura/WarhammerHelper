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
            gameBattleLayout = new BattleLayout(this, gameBattle);

            InitializeComponent();
            ;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            int actualSize = gameBattleLayout.armyLayoutList[0].armyFlowLayout.Size.Width;
            Size newImageSize = new Size(actualSize / 4 - 10, actualSize / 4 - 10);

            //int i = 0;
            //int j = 0;

            for (int i = 0; i < gameBattleLayout.nbArmy; i++)
            {
                for (int j = 0; j < gameBattleLayout.armyLayoutList[i].nbUnit; j++)
                {
                    gameBattleLayout.armyLayoutList[i].unitLayoutList[j].unitPictureBox.Size = newImageSize;
                }
            }


            //foreach (ArmyLayout armyItem in gameBattleLayout.armyLayoutList)
            //{
            //    foreach (UnitLayout unitItem in gameBattleLayout.armyLayoutList[i].unitLayoutList)
            //    {
            //        gameBattleLayout.armyLayoutList[i].unitLayoutList[j].unitPictureBox.Size = newImageSize;
            //        j++;
            //    }
            //    i++;
            //}
        }
    }
}
