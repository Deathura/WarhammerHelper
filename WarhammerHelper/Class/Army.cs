using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerHelper.Class
{
    public class Army
    {
        /*************************
        *      Field
        *************************/

        // private field
        string armyName;
        int nbUnit;

        //public field
        public List<Unit> armyUnit = new List<Unit>();

        /*************************
        *      Constructor
        *************************/
        public Army()
        {
            armyName = "name_of_the_army";
            nbUnit = 0;
        }

        /*************************
         *      Method
         *************************/
        public void SetArmyName(string NewName)
        {
            armyName = NewName;
            //TODO Secure entry (check if its really a correct string)
        }
        public string GetArmyName()
        {
            return armyName;
        }
        public void AddUnit()
        {
            nbUnit += 1;
            armyUnit.Add(new Unit());
        }
        public void RemoveUnit()
        {
            if (nbUnit > 0)
            {
                armyUnit.RemoveAt(nbUnit);
                nbUnit -= 1;
            }
        }
    }
}
