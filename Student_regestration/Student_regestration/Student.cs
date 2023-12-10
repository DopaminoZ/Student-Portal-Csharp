using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_regestration
{
    public class Student : Person
    {
        
        public Student(int ID, string Password, string Name, string Gender, DateTime DoB) : base(ID, Password, Name, Gender, DoB)
        {
          
        }
    }
}
