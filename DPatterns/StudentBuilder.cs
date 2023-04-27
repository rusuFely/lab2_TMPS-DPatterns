using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns
{
    public class StudentBuilder
    {
        private int id;
        private string name;
        private int age;
        private string address;

        public StudentBuilder SetId(int id)
        {
            this.id = id;
            return this;
        }

        public StudentBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public StudentBuilder SetAge(int age)
        {
            this.age = age;
            return this;
        }

        public StudentBuilder SetAddress(string address)
        {
            this.address = address;
            return this;
        }

        public Student Build()
        {
            return new Student(id, name, age, address);
        }
    }
    // builder pattern
}
