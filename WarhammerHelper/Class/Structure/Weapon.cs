using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerHelper.Class
{
    public class Weapon
    {
        /*************************
        *      Field
        *************************/

        // private field
        public string weaponName { get; set; }
        int point;
        int range;
        string type;
        string strenght; 
        int armorPenetration;
        string damage;
        string ability;

        /*************************
         *      Constructor
         *************************/
        public Weapon()
        {
            weaponName = "weapon_name";
            point = 0;
            range = 0;
            type = "None";
            strenght = "None";
            armorPenetration = 0;
            damage = "None";
            ability = "None";
            
        }

        /*************************
         *      Method
         *************************/
    }
}
