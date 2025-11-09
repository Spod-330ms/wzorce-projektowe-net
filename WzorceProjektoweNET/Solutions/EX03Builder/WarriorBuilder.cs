using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03Builder
{
    public abstract class WarriorBuilder
    {
        protected AWojownik _warrior;
        public AWojownik Warrior
        {
            get { return _warrior; }
        }

        public abstract void SetBasicAttributes();
        public abstract void EquipWeapon();
        public abstract void EquipArmor();
        public abstract void LearnSkills();
    }
}
