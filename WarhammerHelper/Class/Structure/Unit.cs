using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WarhammerHelper.Class
{
    public class Unit
    {
        /*************************
         *      Field
         *************************/

        // private field
        public string unitName{ get; set; }
        public int nbFigurine { get; set; }

        // public field
        public List<Figurine> figurineList = new List<Figurine>();


        /*************************
         *      Constructor
         *************************/
        public Unit()
        {
            unitName = "name_of_the_unit";
            nbFigurine = 0;
        }

        /*************************
         *      Method
         *************************/
        public void AddFigurine()
        {
            nbFigurine += 1;
            figurineList.Add(new Figurine());
            MessageBox.Show("New army created");
        }
        public void RemoveArmy()
        {
            if (nbFigurine > 0)
            {
                figurineList.RemoveAt(nbFigurine - 1);
                nbFigurine -= 1;
                MessageBox.Show("Army deleted");
            }
        }

    }
}
