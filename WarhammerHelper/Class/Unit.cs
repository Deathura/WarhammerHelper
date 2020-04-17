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
        string unitName = "unit_name";
        string UnitPicturePath = "unit_picture_path";
        int nbFigurine = 0;

        // public field
        public List<Figurine> unitFigurine = new List<Figurine>();


        /*************************
         *      Constructor
         *************************/
        public Unit()
        {
            unitName = "name_of_the_unit";
            nbFigurine = 0;
            MessageBox.Show("Yo");
        }

        /*************************
         *      Method
         *************************/
        public void SetUnitName(string NewName)
        {
            unitName = NewName;
            //TODO Secure entry (check if its really a correct string)
        }
        public string GetUnitName()
        {
            return unitName;
        }
        public void AddFigurine()
        {
            nbFigurine += 1;
            unitFigurine.Add(new Figurine());
            MessageBox.Show("New army created");
        }
        public void RemoveArmy()
        {
            if (nbFigurine > 0)
            {
                unitFigurine.RemoveAt(nbFigurine - 1);
                nbFigurine -= 1;
                MessageBox.Show("Army deleted");
            }
        }

    }
}
