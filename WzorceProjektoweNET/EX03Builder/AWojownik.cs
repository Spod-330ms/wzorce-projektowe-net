namespace EX03Builder
{
    public abstract class AWojownik
    {
        internal string Name { get; }
        protected TypWojownika _typWojownika;
        internal int Health { get; set; }
        internal int Strength { get; set; }
        internal int Speed { get; set; }
        internal int Dexterity { get; set; }
        internal string Weapon { get; set; }
        internal string Armor { get; set; }
        internal List<string> Skills { get; } = new List<string>();

        public AWojownik(string name)
        {
            Name = name;
        }
        public abstract void Attack();
        public void LearnSkill(string skill)
        {
            Skills.Add(skill);
        }

        public override string ToString()
        {
            return $"Wojownik: {Name}, Typ: {_typWojownika}, Zdrowie: {Health}, Siła: {Strength}, Szybkość: {Speed}, Zręczność: {Dexterity}, Broń: {Weapon}, Zbroja: {Armor}, Umiejętności: {string.Join(", ", Skills)}";
        }
    }
}
