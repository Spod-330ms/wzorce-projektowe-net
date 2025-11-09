using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03Builder.Soldiers
{
    internal class Strzelec : AWojownik
    {
        public Strzelec(string name) : base(name)
        {
            _typWojownika = TypWojownika.Strzelec;
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
