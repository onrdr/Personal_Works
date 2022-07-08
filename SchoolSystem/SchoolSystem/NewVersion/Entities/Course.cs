 
namespace NewVersion
{
    public class Course : ICourse
    {
        public string Name { get; set; }
        public string LastName { get; set; } 
        public Teacher Teacher { get; set; }
        public School School { get; set; }
        public List<IPerson> CourseStudentList { get; set; } = new(); 
        public void PrintAllInfo()
        {
            Console.WriteLine($"{Name} {LastName} : Instructor is {Teacher.Name} {Teacher.LastName}");
            Teacher.PrintExamResults();
        }
    }
}