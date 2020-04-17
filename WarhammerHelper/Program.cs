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
            //int test = gameBattle.battleArmy.
            //    Count();
            //MessageBox.Show(test.ToString());
            //gameBattle.AddArmy();

            //gameBattle.battleArmy[0].SetArmyName("Ork");


            //MessageBox.Show(gameBattle.battleArmy[0].GetArmyName());

            //test = gameBattle.battleArmy.Count();
            //MessageBox.Show(test.ToString());


            //gameBattle.AddArmy();
            //MessageBox.Show(gameBattle.battleArmy[1].GetArmyName());

            //test = gameBattle.battleArmy.Count();
            //MessageBox.Show(test.ToString());

            //gameBattle.RemoveArmy();
            //test = gameBattle.battleArmy.Count();
            //MessageBox.Show(test.ToString());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ArmyForm(gameBattle));
        }
    }
}
