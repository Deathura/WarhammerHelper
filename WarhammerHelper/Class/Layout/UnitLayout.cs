using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarhammerHelper.Class.Layout
{
    class UnitLayout
    {
        /*************************
        *      Field
        *************************/
        public string unitName { get; set; }
        public int nbFigurine { get; set; }

        public string unitImagePath { get; set; }

        public PictureBox unitPictureBox = new PictureBox();

        //List<> figurineLayoutList = new List<>();

        /*************************
        *      Constructor
        *************************/
        public UnitLayout(ArmyLayout armyLayout, Unit unit)
        {
            this.unitName = unit.unitName;
            for(int i = 0; i < unit.nbFigurine; i++)
            {
                AddFigurineLayout(unit.figurineList[i]);
            }

            InitializeUnitLayoutPicture(armyLayout);
        }

        /*************************
         *      Method
         *************************/

        public void InitializeUnitLayoutPicture(ArmyLayout armyLayout)
        {
            string unitImagePath = Directory.GetCurrentDirectory();
            unitImagePath = unitImagePath + @"\..\..\..\ressources\img\unitPicture\" + unitName + ".png";

            Image picture = Image.FromFile(unitImagePath);

            unitPictureBox.Image = picture;


            unitPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            //unitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            unitPictureBox.Location = new System.Drawing.Point(3, 3);
            unitPictureBox.Name = unitPictureBox.Name + "pictureBox";
            unitPictureBox.Size = new System.Drawing.Size(180, 180);
            unitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            unitPictureBox.TabIndex = 1;
            unitPictureBox.TabStop = false;

            armyLayout.armyFlowLayout.Controls.Add(unitPictureBox);
        }
        public void AddFigurineLayout(Figurine figurine)
        {
            //figurineLayoutList.add(new FigurineLayout(this, figurine);
        }
        
    }
}
