using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerHelper.Class.Layout
{
    class BattleLayout
    {
        /*************************
        *      Field
        *************************/
        public string battleName { get; set; }
        public int nbArmy { get; set; }

        public System.Windows.Forms.TableLayoutPanel battleLayout = new System.Windows.Forms.TableLayoutPanel();

        List<ArmyLayout> armyLayoutList = new List<ArmyLayout>();

        /*************************
        *      Constructor
        *************************/
        public BattleLayout()
        {
            battleName = "name_of_the_battle";
            nbArmy = 0;
        }
        public BattleLayout(System.Windows.Forms.Form windowsForm, string battleName, int nbArmy)
        {
            this.battleName = battleName;

            for (int i = 0; i < nbArmy; i++)
            {
                AddArmyLayout();
            }
            //this.nbArmy = nbArmy;
            initializeTableLayout(windowsForm, nbArmy);
        }

        /*************************
         *      Method
         *************************/
        void initializeTableLayout(System.Windows.Forms.Form winForm)
        {
            battleLayout.Name = "battleLayout";
            battleLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            battleLayout.AutoSize = true;
            battleLayout.BackColor = System.Drawing.Color.White;
            battleLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            battleLayout.Location = new System.Drawing.Point(12, 12);
            battleLayout.Size = new System.Drawing.Size(998, 514);
            battleLayout.TabIndex = 0;
            winForm.Controls.Add(battleLayout);
        }
        void initializeTableLayout(System.Windows.Forms.Form winForm, int nbArmy)
        {
            initializeTableLayout(winForm);

            if (nbArmy == 1)
            {
                battleLayout.ColumnCount = 1;
                battleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

                battleLayout.RowCount = 1;
                battleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            }
            if (nbArmy == 2)
            {
                battleLayout.ColumnCount = 2;
                battleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                battleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

                battleLayout.RowCount = 1;
                battleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            }
            if (nbArmy > 2)
            {
                battleLayout.ColumnCount = 2;
                battleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                battleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

                battleLayout.RowCount = 2;
                battleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                battleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            }
        }

        public void AddArmyLayout()
        {
            nbArmy += 1;
            armyLayoutList.Add(new ArmyLayout(this));
        }
        public void RemoveArmyLayout()
        {
            if (nbArmy > 0)
            {
                armyLayoutList.RemoveAt(nbArmy - 1);
                nbArmy -= 1;
            }
        }
    }
}
