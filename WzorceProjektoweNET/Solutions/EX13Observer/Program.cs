using EX13Observer;

List<IStudentObserver> students = new List<IStudentObserver>();
students.Add(new Student("Alice"));
students.Add(new Student("Bob"));
students.Add(new Student("Charlie"));
students.Add(new Student("Diana"));

Teacher teacher = new Teacher("Mr. Smith");
teacher.GradeExam("Math Exam", students);

foreach (var student in students)
{
    ((Student)student).PrintGrades();
}