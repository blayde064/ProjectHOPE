using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHOPE.Classes
{
    public class WorkInstruction
    {

        public string Location { get; set; }
        public string AssemblyNumber { get; set; }
        public string AssemblyName { get; set; }
        public string Series { get; set; }
        public string Name { get; set; }

        public WorkInstruction(string loc, string num, string aname, string ser, string name)
        {
            Location=loc;
            AssemblyNumber=num;
            AssemblyName=aname;
            Series=ser;
            Name=name;
        }
    }
}
