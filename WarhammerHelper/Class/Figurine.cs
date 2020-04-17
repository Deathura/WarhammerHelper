using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerHelper.Class
{
    public class Figurine
    {
        /*************************
         *      Field
         *************************/

        // private field
        string figurineName = "figurine_name";
        int value;
        int movement;
        int weaponSkill;
        int ballisticSkill;
        int strength;
        int toughness;
        int attacks;
        int leadership;
        int armourSave;
        
        int nbRangeWeapon;
        int nbMeleeWeapon;

        // public field
        public List<string> keyWord = new List<string>();
        public List<string> figurineAbility = new List<string>();

        public List<Weapon> meleeWeapon = new List<Weapon>();
        public List<Weapon> rangeWeapon = new List<Weapon>();

        /*************************
         *      Constructor
         *************************/
        public Figurine()
        {
            figurineName = "figurine_name";
            value = 0;
            movement = 0;
            weaponSkill = 0;
            ballisticSkill = 0;
            strength = 0;
            toughness = 0;
            attacks = 0;
            leadership = 0;
            armourSave = 0;

            nbRangeWeapon = 0;
            nbMeleeWeapon = 0;
        }

        /*************************
         *      Method
         *************************/
        public void SetFigurineName(string NewName)
        {
            figurineName = NewName;
            //TODO Secure entry (check if its really a correct string)
        }
        public string GetFigurineName()
        {
            return figurineName;
        }
        public void AddRangeWeapon()
        {
            nbRangeWeapon += 1;
            rangeWeapon.Add(new Weapon());
        }
        public void RemoveRangeWeapon()
        {
            if(nbRangeWeapon > 0)
            {
                rangeWeapon.RemoveAt(nbRangeWeapon - 1);
                nbRangeWeapon -= 1;
            }
        }
        public void AddMeleeWeapon()
        {
            nbMeleeWeapon += 1;
            meleeWeapon.Add(new Weapon());
        }
        public void RemoveMeleeWeapon()
        {
            if (nbMeleeWeapon > 0)
            {
                meleeWeapon.RemoveAt(nbMeleeWeapon - 1);
                nbMeleeWeapon -= 1;
            }
        }
    }
}
