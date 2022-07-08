 
namespace NewVersion
{
    public class School : IEntity
    {
        public string Name { get; set; }
        public Principal Principal { get; set; }
        public List<ISchoolMember> PrincipleList { get; set; } = new();
        public List<ISchoolMember> TeacherList { get; set; } = new();
        public List<ISchoolMember> StudentList { get; set; } = new();
        public List<ISchoolMember> CourseList { get; set; } = new();

        public ISchoolMember Find(string name, string lastName, List<ISchoolMember> list)
        {
            foreach (var s in list.Where(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                                    s.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)))
            {
                return s;
            }

            return null;
        } 
    }
}

