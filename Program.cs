using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using universitydll;

namespace ISuniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> st16 = new List<Student>();
            Student stud1 = new Student("Вася");
            Student stud2 = new Student("Петя");
            Student stud3 = new Student("Маша");
            st16.Add(stud1);
            st16.Add(stud2);
            st16.Add(stud3);
            var gr16 = new Group();
            gr16.name = "16я группа";
            gr16.students = st16;


            List<Student> st2 = new List<Student>();
            Student stud4 = new Student("Вася");
            st2.Add(stud4);
            var gr2 = new Group();
            gr2.name = "2я группа";
            gr2.students = st2;

            List<Group> groups = new List<Group> { gr16, gr2 };

            List<university> Univer = new List<university>();
            university u1 = new university("Сибирский", "Красноярск", groups); 
            Console.ReadKey();
        }
    }
}
