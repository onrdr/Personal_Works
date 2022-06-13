using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Course : IListedObjects<Course>
    {
        private readonly string name;
        private readonly string code;
        private Teacher teacher;
        private readonly List<Student> studentList = new();
        public Course(string name, string code, School school)
        {
            this.name = name;
            this.code = code;
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
        public string GetName() => name;
        
        public string GetLastName() => code;
         
        public string GetFullName() => ($"{name} {code}");
        
        public void PrintInfoForAdmin()
        { 
            Console.WriteLine($"{GetFullName()} : Instructor is {Teacher.GetFullName()}");
            PrintExamResults();
        }
       
    }
}
