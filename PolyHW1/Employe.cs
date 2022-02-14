using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyHW1
{
    internal class Employe
    {
        public static int No_dynamic = 0;
        public int No;
        public string Fullname;
        public double Salary;
        public string Position;

        
        public Employe(string name,double salary,string position)
        {
            Fullname = name;
            Salary = salary;
            Position = position;
            No= ++No_dynamic;
        }
        
    }
}
