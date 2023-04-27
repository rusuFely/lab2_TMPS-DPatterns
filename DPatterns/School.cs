using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns
{
    public class School
    {
        private static School instance;
        public string Name { get; set; }

        private School()
        {
            Name = "My School";
        }

        public static School Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new School();
                }
                return instance;
            }
        }

        // Singleton pattern
    }
}
