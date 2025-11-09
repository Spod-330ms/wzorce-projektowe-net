using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04Prototype
{
    public class Ork
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strenght { get; set; }

        public Ork(string name, int health, int strenght)
        {
            Name = name;
            Health = health;
            Strenght = strenght;
        }
        public Ork Clone()
        {
            return new Ork(Name, Health, Strenght);
        }
        public override string ToString()
        {
            return $"Ork: {Name}, Health: {Health}, Strenght: {Strenght}";
        }
    }
}
