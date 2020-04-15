using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarhammerHelper
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    /**************************************************
     *              Personnal code
     **************************************************/

    public class Army
    {
        string armyName;
        short nbUnit;

        public Army()
        {
            armyName = "name_of_the_army";
            nbUnit = 0;
        }

        public void AddUnit()
        {
            nbUnit += 1;
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
}
