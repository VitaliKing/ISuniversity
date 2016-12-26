using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universitydll
{
    public struct Group
    {
        public string name;
        public List<Student> students;

        public Group(string name, List<Student> students)
        {
            this.name = name;
            this.students = students;
        }
    }
}
