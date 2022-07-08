using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldVersion
{
    internal class Course : IListedObjects<Course>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        private Teacher teacher;
        private readonly List<Student> studentList = new();
        public Course(string name, string code, School school)
        {
            Name = name;
            Code = code;
            school.courseList.Add(this);
        }
        public List<Student> StudentList => studentList;
        public Teacher Teacher
        {
            get => teacher;
            set => teacher = value;
        }
        public void PrintExamResults()
        {
            teacher.PrintExamResults();
        }
        public string GetName() => Name;

        public string GetLastName() => Code;

        public string GetFullName() => $"{Name} {Code}";

        public void PrintInfoForAdmin()
        {
            Console.WriteLine($"{GetFullName()} : Instructor is {Teacher.GetFullName()}");
            PrintExamResults();
        }

    }
}
