
namespace NewVersion
{
    public class Student : Person, IPerson
    {
        private static int counter = 0;
        public string Password { get; set; }
        public string LastName { get; set; }
        public School School { get; set; }
        public string Name { get; set; }
        public int StudentNumber { get; set; } = ++counter;
        public Dictionary<Course, List<double>> ExamGrades { get; set; } = new();
        public List<Course> StudentCourseList { get; set; } = new();

        public void LoginMenu()
        {
            while (true)
            {
                MenuScreens.StudentScreen();
                int choice = Option.GetValidChoice(6);
                switch (choice)
                {
                    case 0:
                        Messages.CloseSystem();
                        Environment.Exit(0);
                        break;
                    case 1:
                        AddCourse();
                        break;
                    case 2:
                        RemoveCourse();
                        break;
                    case 3:
                        PrintExamResults();
                        break;
                    case 4:
                        PrintCourseList();
                        break;
                    case 5:
                        base.ChangePassword(this);
                        break;
                    case 6:
                        Messages.Success("Logged out successfully");
                        return;
                }
            }
        }
        public void AddCourse()
        {
            Course c = FindCourse();

            if (c == null)
                Messages.Error("Course doesn't exists");

            else if (StudentCourseList.Contains(c))
                Messages.Error("Course is already on the list");

            else
            {
                StudentCourseList.Add(c);
                ExamGrades.Add(c, new List<double>());
                c.CourseStudentList.Add(this);
                c.Teacher.ExamGrades.Add(this, new List<double>());
                Messages.Success("Course has been added successfully\n");
            }
        }
        public void RemoveCourse()
        {


            if (StudentCourseList.Count == 0)
                Messages.Error("You don't have any course in your list. Please add a course");
            else
            {
                Course c = FindCourse();
                if (c == null)
                    Messages.Error("Course doesn't exists");

                else if (!StudentCourseList.Contains(c))
                    Messages.Error("Course is not on the list");

                else
                {
                    StudentCourseList.Remove(c);
                    Messages.Success("Course has been removed successfully");
                    ExamGrades.Remove(c);
                    c.CourseStudentList.Remove(this);
                    c.Teacher.ExamGrades.Remove(this);
                }
            }
        }
        public Course FindCourse()
        {
            Console.Write("Please enter the course name : ");
            string name = Console.ReadLine();
            Console.Write("Please enter the course code : ");
            string code = Console.ReadLine();

            return (Course)School.Find(name, code, School.CourseList);
        }
        public void PrintExamResults()
        {
            if (ExamGrades.Values.Count == 0)
                Messages.Error("No course has been added before\n");

            foreach (Course course in ExamGrades.Keys)
            {
                Console.Write($"{course.Name} {course.LastName} : ");
                if (ExamGrades[course].Count == 0)
                    Messages.Error("No exam result found for this course!!!\n");

                else
                {
                    List<double> doubleList = ExamGrades[course];
                    Console.Write($"Mid1: {doubleList[0]}");
                    Console.Write($", Mid2: {doubleList[1]}");
                    Console.Write($", Final: {doubleList[2]}\n\n");
                }
            }
        }
        public void PrintCourseList()
        {
            int counter = 0;
            if (StudentCourseList.Count == 0)
                Messages.Error("No Course Found!!!");

            else
            {
                Console.WriteLine("Course List : ");
                foreach (Course c in StudentCourseList)
                {
                    counter++;
                    Console.WriteLine($"{counter} - {c.Name} {c.LastName}");
                }
            }
        }
        public void PrintAllInfo()
        {
            Console.WriteLine($"{StudentNumber} - {Name} {LastName} : ");
            PrintExamResults();
        }
    }
}
