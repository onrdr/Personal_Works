using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class School
    {
        private readonly string name;
        public readonly List<IListedObjects<Student>> studentList = new();
        public readonly List<IListedObjects<Teacher>> teacherList = new();
        public readonly List<IListedObjects<Course>> courseList = new();
        private readonly SchoolPrincipal principal;
        public School(string name)
        {
            this.name = name;
            principal = new SchoolPrincipal("a1", "1a", this);
        }

        public IListedObjects<T> FindandReturn<T>(string name, string lastName, List<IListedObjects<T>> list) 
        { 
            foreach (IListedObjects<T> t in list)
            {
                if (t.GetName().Equals(name, StringComparison.OrdinalIgnoreCase) &&
                        t.GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return t;
                }
            }
            return null;
        }
        
        public SchoolPrincipal Principal { get { return this.principal; } }

        public string Name { get { return this.name; } }





    }
}
