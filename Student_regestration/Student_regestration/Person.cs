using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_regestration
{
    public abstract class Person
    {
        protected int ID { get; set; }
        protected string Password { get; set; }
        protected string Name { get; set; }
        protected string Gender { get; set; }
        protected DateTime DoB { get; set; }

        public Person(int ID, string Password, string Name, string Gender, DateTime DoB)
        {
            this.ID = ID;
            this.Password = Password;
            this.Name = Name;
            this.Gender = Gender;
            this.DoB = DoB;
        }
    }
}
