using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13Observer
{
    public class Teacher
    {
        public string Name { get; private set; }
        public List<GradeBook> GradeBooks { get; private set; } = new List<GradeBook>();
        public Teacher(string name)
        {
            Name = name;
        }

        public void GradeExam(string examTitle, List<IStudentObserver> studentObservers)
        {
            Dictionary<string, int> grades = new Dictionary<string, int>();
            foreach (var studentObserver in studentObservers) 
            {
                Random rand = new Random();
                grades[studentObserver.GetName()] = rand.Next(1, 6);
            }

            ExamGradeBook exam = new ExamGradeBook(examTitle);
            foreach(var studentObserver in studentObservers)
            {
                exam.Attach(studentObserver);
            }
            
            exam.SetGrades(grades);
        }
    }
}
