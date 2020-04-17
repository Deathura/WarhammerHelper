using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarhammerHelper
{
    public class Battle
    {
        string battleName;
        //public string battleName; { get; set; }
        int nbArmy;
        public string PartName { get; set; }

        // Create a list of parts.
        public List<Army> battleArmy = new List<Army>();

        public Battle()
        {
            battleName = "name_of_the_battle";
            nbArmy = 0;
        }

        public string GetBattleName()
        {
            return battleName;
        }

        public void SetBattleName(string Name)
        {
            battleName = Name;
            //TODO Secure input
        }

        public void AddArmy()
        {
            nbArmy += 1;
            // Add Army to the list.
            battleArmy.Add(new Army());
        }

        public void RemoveArmy()
        {
            nbArmy -= 1;
            //TODO unititialize 1 object ? (c'est possible ?)
        }
    }

    public class Army
    {
        string armyName;
        short nbUnit;
        public Unit[] armyUnit = new Unit[10];
        //public Unit armyUnit = new Unit();

        public Army()
        {
            armyName = "name_of_the_army";
            nbUnit = 2;
            for (int i=0; i < nbUnit; i++)
            {
                armyUnit[i] = new Unit();
            }
        }

        public void AddUnit()
        {
            nbUnit += 1;
            armyUnit[nbUnit - 1] = new Unit();
        }

        public void SetArmyName(string NewName)
        {
            armyName = NewName;
            //TODO Secure entry (check if its really a correct string)
        }

        public string GetArmyName()
        {
            return armyName;
        }
    }

    public class Unit
    {
        string unitName = "unit_name";
        string UnitPicturePath = "unit_picture_path";
        int nbFigurine = 0;
        //Figurine unitFigurine[nbFigurine]

        public Unit()
        {
            unitName = "name_of_the_unit";
            nbFigurine = 0;
            MessageBox.Show("Yo");
        }
        public void AddUnit()
        {
            nbFigurine += 1;
            //TODO update Figurine Array
        }
        public void removeUnit()
        {
            nbFigurine -= 1;
            //TODO update Figurine Array
        }
        public void SetUnitName(string NewName)
        {
            unitName = NewName;
            //TODO Secure entry (check if its really a correct string)
        }
        public string GetUnitName()
        {
            return unitName;
        }

    }
}
