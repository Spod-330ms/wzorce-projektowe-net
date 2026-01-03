using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13Observer
{
    public class GradeBook
    {
        public string Title { get; private set; }
        public Dictionary<string, int> Grades { get; private set; } = new Dictionary<string, int>();


        public GradeBook(string title)
        {
            Title = title;
        }

        List<IStudentObserver> observers = new List<IStudentObserver>();
        public void Attach(IStudentObserver observer)
        {
            observers.Add(observer);
        }
        public void Detach(IStudentObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }

        public void SetGrades(Dictionary<string, int> grades)
        {
            Grades = grades;
            NotifyObservers();
        }
    }
}
