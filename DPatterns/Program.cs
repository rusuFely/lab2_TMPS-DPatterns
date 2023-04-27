using System;

namespace DPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a singleton instance of the school
            School school = School.Instance;

            // Construct a student using the builder pattern
            StudentBuilder builder = new StudentBuilder();
            Student student = builder.SetId(1)
                                     .SetName("John Doe")
                                     .SetAge(18)
                                     .SetAddress("123 Main St.")
                                     .Build();

            // Create student and teacher objects using the abstract factory pattern
            PersonFactory factory = new SchoolPersonFactory();
            Student student2 = factory.CreateStudent();
            Teacher teacher = factory.CreateTeacher();

            // Display the objects
            Console.WriteLine("School name: " + school.Name);
            Console.WriteLine("Student name: " + student.Name);
            Console.WriteLine("Student 2 name: " + student2.Name);
            Console.WriteLine("Teacher name: " + teacher.Name);
        }
    }
}
