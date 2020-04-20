using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarhammerHelper.Class.Layout
{
    class BattleLayout
    {
        /*************************
        *      Field
        *************************/
        public string battleName { get; set; }
        public int nbArmy { get; set; }

        public TableLayoutPanel battleLayout = new TableLayoutPanel();

        public List<ArmyLayout> armyLayoutList = new List<ArmyLayout>();

        /*************************
        *      Constructor
        *************************/
        public BattleLayout()
        {
            battleName = "name_of_the_battle";
            nbArmy = 0;
        }
        public BattleLayout(Form windowsForm, Battle gameBattle)
        {
            battleName = gameBattle.battleName;
            for (int i = 0; i < gameBattle.nbArmy; i++)
            {
                AddArmyLayout(gameBattle.armyList[i]);
            }
            initializeTableLayout(windowsForm, nbArmy);
        }

        /*************************
         *      Method
         *************************/
        void initializeTableLayout(Form winForm)
        {
            battleLayout.Name = "battleLayout";
            battleLayout.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            battleLayout.AutoSize = true;
            battleLayout.BackColor = System.Drawing.Color.White;
            battleLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            battleLayout.Location = new System.Drawing.Point(12, 12);
            battleLayout.Size = new System.Drawing.Size(998, 514);
            battleLayout.TabIndex = 0;
            winForm.Controls.Add(battleLayout);
        }
        void initializeTableLayout(Form winForm, int nbArmy)
        {
            initializeTableLayout(winForm);

            if (nbArmy == 1)
            {
                battleLayout.ColumnCount = 1;
                battleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

                battleLayout.RowCount = 1;
                battleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            }
            if (nbArmy == 2)
            {
                battleLayout.ColumnCount = 2;
                battleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                battleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

                battleLayout.RowCount = 1;
                battleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            }
            if (nbArmy > 2)
            {
                battleLayout.ColumnCount = 2;
                battleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                battleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

                battleLayout.RowCount = 2;
                battleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                battleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            }
        }

        public void AddArmyLayout(Army army)
        {
            nbArmy += 1;
            armyLayoutList.Add(new ArmyLayout(this, army));
        }
        public void RemoveArmyLayout()
        {
            // Only hide item ?
            
            //if (nbArmy > 0)
            //{
            //    armyLayoutList.RemoveAt(nbArmy - 1);
            //    nbArmy -= 1;
            //}
        }
    }
}
