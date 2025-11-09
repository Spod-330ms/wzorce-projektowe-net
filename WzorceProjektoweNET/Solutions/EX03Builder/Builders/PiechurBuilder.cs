using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03Builder.Builders
{
    public class PiechurBuilder : WarriorBuilder
    {
        public PiechurBuilder(string name)
        {
            _warrior = new Soldiers.Piechur(name);
        }
        public override void EquipArmor()
        {
            _warrior.Armor = "Ciężka zbroja";
        }

        public override void EquipWeapon()
        {
            _warrior.Weapon = "Długi miecz";
        }

        public override void LearnSkills()
        {
            _warrior.LearnSkill("Cięcie");
            _warrior.LearnSkill("Blok");
        }

        public override void SetBasicAttributes()
        {
            _warrior.Health = 150;
            _warrior.Strength = 90;
            _warrior.Dexterity = 65;
            _warrior.Speed = 50;
        }
    }
}
