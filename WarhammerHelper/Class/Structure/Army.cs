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
        public string armyName{ get; set; }
        public int nbUnit { get; set; }

        //public field
        public List<Unit> unitList = new List<Unit>();

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
        public void AddUnit()
        {
            nbUnit += 1;
            unitList.Add(new Unit());
        }
        public void RemoveUnit()
        {
            if (nbUnit > 0)
            {
                unitList.RemoveAt(nbUnit);
                nbUnit -= 1;
            }
        }
    }
}
