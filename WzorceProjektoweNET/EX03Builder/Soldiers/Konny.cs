using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03Builder.Soldiers
{
    internal class Konny : AWojownik
    {
        public Konny(string name) : base(name)
        {
            _typWojownika = TypWojownika.Konny;
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
