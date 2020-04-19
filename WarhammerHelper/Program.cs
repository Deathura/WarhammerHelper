using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using WarhammerHelper.Class;

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
            Battle gameBattle = new Battle();

            //gameBattle.nbArmy = 4;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ArmyCreatorForm(gameBattle));
            Application.Run(new GameForm(gameBattle));
        }
    }
}
