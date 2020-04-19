using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerHelper.Class.Layout
{
    class ArmyLayout
    {
        public string armyName { get; set; }
        public int nbUnit { get; set; }

        System.Windows.Forms.FlowLayoutPanel armyLayout = new System.Windows.Forms.FlowLayoutPanel();

        List<UnitLayout> unitLayoutList = new List<UnitLayout>();
    }
}
