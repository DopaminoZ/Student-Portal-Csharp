using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_regestration
{
    internal abstract class Staff : Person
    {
        protected double salary { get; set; }
        protected string Admin { get; set; }
        protected int Term { get; set; }
        public Staff(int ID, string Password, string Name, string Gender, DateTime DoB, double salary, string Admin, int Term) : base(ID, Password, Name, Gender, DoB)
        {
            this.Admin = Admin; 
            this.Term = Term;
            this.salary = salary;
        }
    }
}
