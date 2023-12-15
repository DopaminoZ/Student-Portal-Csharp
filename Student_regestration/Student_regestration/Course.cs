using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_regestration
{
    public class Course
    {
        private string name;
        private string code;
        private string description;
        private double creditHours;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Code
        {
            set { code = value; }
            get { return code; }
        }
        public string Description
        {
            set { description = value; }
            get { return description; }
        }
        public double CreditHours
        {
            set
            {
                if (value > 0)
                    creditHours = value;
            }
            get { return creditHours; }

        }
    }
}
