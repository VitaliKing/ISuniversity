using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universitydll
{
    public struct university
    {
        public string name;
        public string adress;
        public List<Group> groups;

        public university(string name, string adress, List<Group> groups)
        {
            this.name = name;
            this.adress = adress;
            this.groups = groups;
        }
    }
}
