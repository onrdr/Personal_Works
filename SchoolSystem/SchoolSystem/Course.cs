using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholManagementSystem
{
    internal class Course : IListedObjects<Course>
    {
        private readonly string name;
        private readonly string code;
        private Teacher teacher;
        private static School school;
        private readonly List<Student> studentList = new List<Student>();
        public Course(string name, string code, School school)
        {
            this.name = name;
            this.code = code;
            Course.school = school;
            school.courseList.Add(this);
        }
        public List<Student> StudentList { get { return studentList; } }
        public Teacher Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }
        public string GetName()
        {
            return name;
        }
        public string GetLastName()
        {
            return code;
        }
        public string GetFullName()
        {
            return name + " " + code;
        }
        public void PrintInfoForAdmin()
        {
            Console.WriteLine("{0} : ", GetFullName());
            PrintExamResults();
        }
        public void PrintExamResults()
        {
            teacher.PrintExamResults();
        }
        public Course FindandReturn(string name, string lastName)
        {
            foreach (Course c in School.courseList)
            {
                if (c.GetName().Equals(name, StringComparison.OrdinalIgnoreCase) &&
                        c.GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return c;
                }
            }
            return null;
        }

        public static School School { get { return school; } }
    }
}
