using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarhammerHelper.Class
{
    public class Battle
    {
        /*************************
        *      Field
        *************************/
        // private field
        public string battleName { get; set; }
        public int nbArmy { get; set; }

        // public field
        public List<Army> armyList = new List<Army>(); // Create a List of Army

        /*************************
        *      Constructor
        *************************/
        public Battle()
        {
            battleName = "name_of_the_battle";
            nbArmy = 0;
        }

        /*************************
         *      Method
         *************************/
        public void AddArmy()
        {
            nbArmy += 1;
            armyList.Add(new Army());
            MessageBox.Show("New army created");
        }
        public void RemoveArmy()
        {
            if (nbArmy > 0)
            {
                armyList.RemoveAt(nbArmy - 1);
                nbArmy -= 1;
                MessageBox.Show("Army deleted");
            }
        }
    }
}
