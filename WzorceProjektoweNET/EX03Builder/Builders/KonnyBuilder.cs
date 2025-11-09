using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03Builder.Builders
{
    public class KonnyBuilder : WarriorBuilder
    {
        public KonnyBuilder(string name)
        {
            _warrior = new Soldiers.Konny(name);
        }
        public override void EquipArmor()
        {
            _warrior.Armor = "Zbroja konna";
        }

        public override void EquipWeapon()
        {
            _warrior.Weapon = "Lanca";
        }

        public override void LearnSkills()
        {
            _warrior.LearnSkill("Jazda konna");
            _warrior.LearnSkill("Szarża");
        }

        public override void SetBasicAttributes()
        {
            _warrior.Health = 120;
            _warrior.Strength = 60;
            _warrior.Dexterity = 70;
            _warrior.Speed = 80;
        }
    }
}
