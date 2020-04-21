using System;
using System.Collections.Generic;
using System.IO;
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

            CreateTestArmy(gameBattle);

            //string path = Directory.GetCurrentDirectory();
            //MessageBox.Show(path);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ArmyCreatorForm(gameBattle));;
            Application.Run(new GameForm(gameBattle));
        }

        static void CreateTestArmy(Battle gameBattle)
        {
            gameBattle.AddArmy();
            gameBattle.armyList[0].AddUnit("SW_ThunderwolfCavalry");
            gameBattle.armyList[0].AddUnit("SW_GreyHunter");
            //gameBattle.armyList[0].unitList[0].AddFigurine();

            gameBattle.AddArmy();
            gameBattle.armyList[1].AddUnit("Ork_Warboss");
            gameBattle.armyList[1].AddUnit("Ork_Painboy");
            gameBattle.armyList[1].AddUnit("Ork_Boyz");
            gameBattle.armyList[1].AddUnit("Ork_Boyz");
            gameBattle.armyList[1].AddUnit("Ork_Boyz");
            gameBattle.armyList[1].AddUnit("Ork_Boyz");
            gameBattle.armyList[1].AddUnit("Ork_Boyz");
            gameBattle.armyList[1].AddUnit("Ork_Boyz");
            gameBattle.armyList[1].AddUnit("Ork_Boyz");
            gameBattle.armyList[1].AddUnit("Ork_Boyz");


            //gameBattle.AddArmy();

        }
    }
}
