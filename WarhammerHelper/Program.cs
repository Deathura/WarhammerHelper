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
            Battle gameBattle = new Battle();
            int test = gameBattle.battleArmy.Count();
            MessageBox.Show(test.ToString());
            gameBattle.AddArmy();


            test = gameBattle.battleArmy.Count();
            MessageBox.Show(test.ToString());

            MessageBox.Show(gameBattle.battleArmy[0].armyUnit[0].GetUnitName());
            //Army inGameArmy = new Army();
            //MessageBox.Show(inGameArmy.armyUnit[1].GetUnitName());
            //MessageBox.Show("hello World ! here is your army name : " + inGameArmy.GetArmyName());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ArmyForm());
        }
    }
}
