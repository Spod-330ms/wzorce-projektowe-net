using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03Builder.Builders
{
    public class StrzelecBuilder : WarriorBuilder
    {
        public StrzelecBuilder(string name)
        {
            _warrior = new Soldiers.Strzelec(name);
        }
        public override void EquipArmor()
        {
            _warrior.Armor = "Lekka skórzana zbroja";
        }

        public override void EquipWeapon()
        {
            _warrior.Weapon = "Długi łuk";
        }

        public override void LearnSkills()
        {
            _warrior.LearnSkill("Precyzjny strzał");
            _warrior.LearnSkill("Kamuflaż");
        }

        public override void SetBasicAttributes()
        {
            _warrior.Health = 100;
            _warrior.Strength = 50;
            _warrior.Dexterity = 90;
            _warrior.Speed = 60;
        }
    }
}
