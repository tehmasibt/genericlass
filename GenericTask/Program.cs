using System.Security.Cryptography.X509Certificates;

namespace GenericTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new("Tehmasib", "Taghiyev", 100);
            Student stu2 = new("Emil","Abbasov",80);
            Student stu3 = new("Kenan","Quliyev",70);
            Student stu4 = new("Emin","Musayev",50);

            Group group = new Group();
            group.AddStudent(stu1);
            group.AddStudent(stu2);
            group.AddStudent(stu3);
            group.AddStudent(stu4);
            group.GetAllStudents();
            group.Sort();

            Console.WriteLine("===============");

            Group group1 = new Group();
            group1.AddStudent(stu1);
            group1.AddStudent(stu2);
            group1.AddStudent(stu3);
            group1.AddStudent(stu4);
            group1.GetAllStudents();
            group1.Sort();

        }
    }
}
