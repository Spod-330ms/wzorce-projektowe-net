using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03Builder.Soldiers
{
    internal class Piechur : AWojownik
    {
        public Piechur(string name) : base(name) 
        {  
            _typWojownika = TypWojownika.Piechur;
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
