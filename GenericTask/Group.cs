using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask
{
    internal class Group
    {
        static int noo = 100;
        public string No { get; }
        private List<Student> Students { get; }
        public Group()
        {
            Students = new List<Student>();
            noo++;
            No = $"Ap{noo}";
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);   
        }
        public void GetAllStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"Id: {student.Id}, Group: {No} Name: {student.Name}, Surname: {student.Surname}, Point: {student.Point}");
            }
        }
        public void Sort()
        {
            List<Student> studentsort = new List<Student>();
            studentsort = Students;
            studentsort.Sort((n,m)=>n.Point.CompareTo(m.Point));
            foreach (var item in studentsort)
            {
                Console.WriteLine($"Id: {item.Id}, Group: {No} Name: {item.Name}, Surname: {item.Surname}, Point: {item.Point}");
            }
        }
    } 
}
