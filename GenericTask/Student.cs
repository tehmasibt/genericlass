using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask
{
    internal class Student
    {
        private int no=0;

        public Student(string name, string surname, int point)
        {
            no++;
            Id = no;
            Name = name;
            Surname = surname;
            Point = point;

        }

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Surname: {Surname}, Age: {Age}, Point: {Point}");
        }
        public static bool operator > ( Student a, Student b)
        {
            return a.Point > b.Point;
        }
        public static bool operator <(Student a, Student b)
        {
            return a.Point < b.Point;
        }
    }
}
