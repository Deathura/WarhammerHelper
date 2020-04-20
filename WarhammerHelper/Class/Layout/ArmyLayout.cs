using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarhammerHelper.Class.Layout
{
    class ArmyLayout
    {
        /*************************
        *      Field
        *************************/
        public string armyName { get; set; }
        public int nbUnit { get; set; }

        public FlowLayoutPanel armyFlowLayout = new FlowLayoutPanel();

        public List<UnitLayout> unitLayoutList = new List<UnitLayout>();

        /*************************
        *      Constructor
        *************************/
        public ArmyLayout(BattleLayout battleLayout, Army army)
        {
            armyName = army.armyName;
            for (int i = 0; i < army.nbUnit; i++)
            {
                AddUnitLayout(army.unitList[i]);
            }
            //for (int i = 0; i < gameBattle.nbArmy; i++)
            //{
            //    AddArmyLayout(gameBattle.armyList[i]);
            //}
            InitializeArmyFlowLayout(battleLayout);
        }

        /*************************
         *      Method
         *************************/
        public void InitializeArmyFlowLayout(BattleLayout battleLayout)
        {

            armyFlowLayout.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
                | AnchorStyles.Left)
                | AnchorStyles.Right)));
            armyFlowLayout.BackColor = System.Drawing.Color.White;
            armyFlowLayout.AutoScroll = true;
            armyFlowLayout.Location = new System.Drawing.Point(4, 4);
            armyFlowLayout.Name = "armyFlowLayout";
            armyFlowLayout.Size = new System.Drawing.Size(500, 553);
            armyFlowLayout.TabIndex = 1;

            battleLayout.battleLayout.Controls.Add(armyFlowLayout);
        }

        public void AddUnitLayout(Unit unit)
        {
            nbUnit += 1;
            unitLayoutList.Add(new UnitLayout(this, unit));
        }
    }
}
