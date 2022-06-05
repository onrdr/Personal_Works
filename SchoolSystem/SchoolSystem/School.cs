using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholManagementSystem
{
    internal class School
    {
        private readonly string name;
        public readonly List<Student> studentList = new List<Student>();
        public readonly List<Teacher> teacherList = new List<Teacher>();
        public readonly List<Course> courseList = new List<Course>();
        private SchoolPrincipal principal;
        public School(string name)
        {
            this.name = name;
            principal = new SchoolPrincipal("a1", "1a", this); 
        } 
        public Student FindStudent(string name, string lastName)
        {
            foreach (Student s in studentList)
            {
                if (s.GetName().Equals(name, StringComparison.OrdinalIgnoreCase) &&
                        s.GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return s;
                }
            }
            return null;
        }

        public Teacher FindTeacher(string name, string lastName)
        {
            foreach (Teacher t in teacherList)
            {
                if (t.GetName().Equals(name, StringComparison.OrdinalIgnoreCase) &&
                        t.GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return t;
                }
            }
            return null;
        }

        public Course FindCourse(string name, string lastName)
        {
            foreach (Course c in courseList)
            {
                if (c.GetName().Equals(name, StringComparison.OrdinalIgnoreCase) &&
                        c.GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return c;
                }
            }
            return null;
        }

        public SchoolPrincipal Principal { get { return this.principal; } }
         
        public string Name { get { return this.name; } }





    }
}
