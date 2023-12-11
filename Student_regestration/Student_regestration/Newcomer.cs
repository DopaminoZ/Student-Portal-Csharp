using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_regestration
{
    public class Newcomer : Person
    {
        public string email { get; set; }
        public Newcomer(int ID, string Password, string Name, string Gender, DateTime DoB, string email) : base(ID, Password, Name, Gender, DoB)
        {
            this.email = email;
        }
    }
}
