using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_regestration
{
    public abstract class Person
    {
        public int ID { get; set; }
        protected string Password { get; set; }
        public string Name { get; set; }
        protected string Gender { get; set; }
        protected DateTime DoB { get; set; }

        public Person()
        {
            ID = 0;
            Password = string.Empty;
            Name = string.Empty;
            Gender = string.Empty;
            DoB = DateTime.Now;
        }
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
