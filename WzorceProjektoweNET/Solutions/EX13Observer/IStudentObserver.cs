using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13Observer
{
    public interface IStudentObserver
    {
        public void Update(GradeBook grades);
        public string GetName();
    }
}
