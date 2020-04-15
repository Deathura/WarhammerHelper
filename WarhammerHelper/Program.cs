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

    public class Team
    {
        public String TeamName = "TeamName";
        public Int16 nbUnit = 0;

        private void AddUnit()
        {
            nbUnit += 1;
        }

        private void ChangeTeamName(string NewName)
        {
            TeamName = NewName;
            //TODO Secure entry (check if its really a correct string)
        }
    }
}
