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
        string battleName;
        int nbArmy;

        // public field
        public List<Army> battleArmy = new List<Army>(); // Create a List of Army

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
         public void SetBattleName(string newName)
        {
            battleName = newName;
        }
        public string GetBattleName()
        {
            return battleName;
        }
        public int GetNbArmy()
        {
            return nbArmy;
        }
        public void SetNbArmy(int nb)
        {
            nbArmy = nb;
        }
        public void AddArmy()
        {
            nbArmy += 1;
            battleArmy.Add(new Army());
            MessageBox.Show("New army created");
        }
        public void RemoveArmy()
        {
            if (nbArmy > 0)
            {
                battleArmy.RemoveAt(nbArmy - 1);
                nbArmy -= 1;
                MessageBox.Show("Army deleted");
            }
        }
    }
}
