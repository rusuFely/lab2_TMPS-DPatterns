using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns
{
    public abstract class PersonFactory
    {
        public abstract Student CreateStudent();
        public abstract Teacher CreateTeacher();
    }
    // abstract factory pattern
}
