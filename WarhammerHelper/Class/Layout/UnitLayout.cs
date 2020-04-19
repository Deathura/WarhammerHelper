using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerHelper.Class.Layout
{
    class UnitLayout
    {
        public string UnitName { get; set; }
        public int nbFigurine { get; set; }

        public string unitImagePath { get; set; }

        System.Windows.Forms.PictureBox unitLayout = new System.Windows.Forms.PictureBox();

        //List<> figurineLayoutList = new List<>();
    }
}
