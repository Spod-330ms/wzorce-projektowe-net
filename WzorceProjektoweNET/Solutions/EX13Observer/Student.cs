using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13Observer
{
    public class Student : IStudentObserver
    {
        private Dictionary<string, int> grades { get; set; }
        public string Name { get; private set; }
        public Student(string name)
        {
            grades = new Dictionary<string, int>();
            Name = name;
        }
        public void Update(GradeBook gradeBook)
        {
            var topic = gradeBook.Title; 
            var grade = gradeBook.Grades[this.Name];
            
            grades.Add(topic, grade);
        }
        public string GetName()
        {
            return Name;
        }

        public void PrintGrades()
        {
            Console.WriteLine($"Grades for {Name}:");
            foreach (var entry in grades)
            {
                Console.WriteLine($"  {entry.Key}: {entry.Value}");
            }
        }
    }
}
