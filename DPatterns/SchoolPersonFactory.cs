using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns
{
          public class SchoolPersonFactory : PersonFactory
    {
        public override Student CreateStudent()
        {
            return new Student(2, "Mary Johnson", 17, "456 Oak St.");
        }

        public override Teacher CreateTeacher()
        {
            return new Teacher();
        }
    }
    // abstract factory pattern
}
