using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_regestration
{
    internal class Postgrad : Student
    {
        public int YearofGrad;
        public Postgrad(int ID, string Password, string Name, string Gender, DateTime DoB, int YearofGrad) : base(ID, Password, Name, Gender, DoB)
        {
            this.YearofGrad = YearofGrad;
        }
    }
}
