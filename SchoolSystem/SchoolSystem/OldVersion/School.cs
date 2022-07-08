using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldVersion
{ 
    internal class School
    {
        private readonly string name;
        public readonly List<Student> studentList = new();
        public readonly List<Teacher> teacherList = new();
        public readonly List<Course> courseList = new();
        private readonly SchoolPrincipal principal;
        public School(string name)
        {
            this.name = name;
            principal = new SchoolPrincipal("a1", "1a", this);
        }

        public SchoolPrincipal Principal => principal;

        public string Name => name;

    }
}
