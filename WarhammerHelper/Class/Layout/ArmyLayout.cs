using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerHelper.Class.Layout
{
    class ArmyLayout
    {
        /*************************
        *      Field
        *************************/
        public string armyName { get; set; }
        public int nbUnit { get; set; }

        System.Windows.Forms.FlowLayoutPanel armyFlowLayout = new System.Windows.Forms.FlowLayoutPanel();

        List<UnitLayout> unitLayoutList = new List<UnitLayout>();

        /*************************
        *      Constructor
        *************************/
        public ArmyLayout(BattleLayout battleLayout)
        {
            armyName = "name_of_the_battle";
            nbUnit = 0;
            InitializeArmyFlowLayout(battleLayout);
        }
        //public ArmyLayout(BattleLayout battleLayout, string armyName, int nbUnit)
        //{
        //    this.armyName = armyName;
        //    this.nbUnit = nbUnit;
        //    InitializeArmyFlowLayout(battleLayout);
        //}

        /*************************
         *      Method
         *************************/
        public void InitializeArmyFlowLayout(BattleLayout battleLayout)
        {

            armyFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            armyFlowLayout.BackColor = System.Drawing.Color.Red;
            armyFlowLayout.Location = new System.Drawing.Point(4, 4);
            armyFlowLayout.Name = "armyFlowLayout";
            armyFlowLayout.Size = new System.Drawing.Size(500, 553);
            armyFlowLayout.TabIndex = 1;

            battleLayout.battleLayout.Controls.Add(armyFlowLayout);
        }

        //public void addUnit()
        //{

        //}
    }
}
