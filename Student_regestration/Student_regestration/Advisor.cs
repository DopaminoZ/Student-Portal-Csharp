using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_regestration
{
    internal class Advisor : Staff
    {
        public Advisor(int ID, string Password, string Name, string Gender, DateTime DoB, double salary, string Admin, int Term) : base(ID, Password, Name, Gender, DoB, salary, "true", 0)
        {
        }
    }
}
