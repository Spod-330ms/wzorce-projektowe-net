using EX03Builder.Builders;
using EX03Builder.Soldiers;

namespace EX03Builder
{
    public static class Garnizon
    {
        public static AWojownik CreateSoldier(TypWojownika type, string name)
        {
            WarriorBuilder builder;
            switch (type)
            {
                case TypWojownika.Piechur:
                    {
                        builder = new PiechurBuilder(name);
                        break;
                    }
                case TypWojownika.Strzelec:
                    {
                        builder = new StrzelecBuilder(name);
                        break;
                    }
                case TypWojownika.Konny:
                    {
                        builder = new KonnyBuilder(name);
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Nieznany typ wojownika");
                    }
            }

            builder.SetBasicAttributes();
            builder.EquipWeapon();
            builder.EquipArmor();
            builder.LearnSkills();

            return builder.Warrior;
        }
    }
}
