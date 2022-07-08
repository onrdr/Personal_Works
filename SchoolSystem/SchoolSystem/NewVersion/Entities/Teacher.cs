
namespace NewVersion
{
    public class Teacher : Person, IPerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public School School { get; set; }
        public Course Course { get; set; }
        public Dictionary<IPerson, List<double>> ExamGrades { get; set; } = new();

        public void LoginMenu()
        { 
            while (true)
            {
                MenuScreens.TeacherScreen();
                int choice = Option.GetValidChoice(6);
                switch (choice)
                {
                    case 0:
                        Messages.CloseSystem();
                        Environment.Exit(0);
                        break;
                    case 1:
                        EnterExamResults();
                        break;
                    case 2:
                        ModifyExamResults();
                        break;
                    case 3:
                        PrintExamResults();
                        break;
                    case 4:
                        PrintStudentInformation();
                        break;
                    case 5:
                        ChangePassword(this);
                        break;
                    case 6:
                        Messages.Success("Logged out successfully "); 
                        return; 
                }
            }
        }
        public void EnterExamResults()
        {
            if (Course.CourseStudentList.Count == 0)
            {
                Messages.Error("No student registered to your class");
            }
            else
            {
                Student student = FindStudent();

                if (student == null)
                    Messages.Error("Student not Found");

                else if (!Course.CourseStudentList.Contains(student))
                    Messages.Error("Student not in your class");

                else if (!(ExamGrades[student].Count == 0))
                {
                    Messages.Error("You have entered exam results before. Please modify results from menu");
                }
                else
                {
                    List<double> _examGrades = GetExamGradesAsList();
                    student.ExamGrades.Remove(Course);
                    student.ExamGrades.Add(Course, _examGrades);
                    ExamGrades.Remove(student);
                    ExamGrades.Add(student, _examGrades);
                    Messages.Success("Added successfully...");
                }
            }
        }
        public void ModifyExamResults()
        {
            bool flag = true;
            foreach (List<double> doubleList in ExamGrades.Values)
            {
                if (!(doubleList.Count == 0))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Messages.Error("No exam result had been entered before");
            }
            else
            {
                Student student = FindStudent();

                if (student == null)
                    Messages.Error("Student not found");

                else if (!Course.CourseStudentList.Contains(student))
                    Messages.Error("Student not in your class");

                else if (ExamGrades[student].Count == 0)
                    Messages.Error("You have not entered exam results for this student.");

                else
                {
                    List<double> _examGrades = GetExamGradesAsList();
                    student.ExamGrades.Remove(Course);
                    student.ExamGrades.Add(Course, _examGrades);
                    ExamGrades.Remove(student);
                    ExamGrades.Add(student, _examGrades);
                    Messages.Success("Modified successfully...");
                }
            }
        }
        public Student FindStudent()
        {
            Console.Write("Please enter student name : ");
            string studentName = Console.ReadLine();
            Console.Write("Please enter student last name : ");
            string studentLastName = Console.ReadLine();

            return (Student)School.Find(studentName, studentLastName, School.StudentList);
        }
        public static List<double> GetExamGradesAsList()
        {

            List<double> examGrades = new();
            while (true)
            {
                try
                {
                    Console.Write("Please enter the midterm 1 result : ");
                    double mid1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the midterm 2 result : ");
                    double mid2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the final exam result : ");
                    double finalExam = Convert.ToDouble(Console.ReadLine());

                    if (mid1 < 0 || mid1 > 100 ||
                        mid2 < 0 || mid2 > 100 ||
                        finalExam < 0 || finalExam > 100)
                        Messages.Error("One of the exam grade is out of range (0 - 100)");

                    else
                    {
                        examGrades.Add(mid1);
                        examGrades.Add(mid2);
                        examGrades.Add(finalExam);
                        break;
                    }
                }
                catch (Exception)
                {
                    Messages.Error("Invalid Input!!!");
                }
            }
            return examGrades;
        }
        public void PrintExamResults()
        {
            bool flag = true;
            foreach (List<double> doubleList in ExamGrades.Values)
            {
                if (ExamGrades.Count != 0)
                {
                    flag = false;
                    break;
                }
            } 
            if (flag)
                Messages.Error("No exam result had been entered before");

            else
            {
                List<double> doubleList;
                foreach (Student student in ExamGrades.Keys)
                {
                    Console.Write($"{student.StudentNumber} {student.Name} {student.LastName} : ");

                    if (ExamGrades[student].Count == 0)
                    {
                        Messages.Error("No exam result had been entered before\n");
                    }
                    else
                    {
                        doubleList = ExamGrades[student];
                        Console.Write($"Mid1: {doubleList[0]}");
                        Console.Write($", Mid2: {doubleList[1]}");
                        Console.Write($", Final: {doubleList[2]}\n\n");
                    }
                }
            }
        }
        public void PrintStudentInformation()
        {
            if (Course.CourseStudentList.Count == 0)
                Messages.Error("No student registered to your course!!!");

            else
            {
                Console.WriteLine("Students List : ");
                foreach (Student student in Course.CourseStudentList)
                    Console.Write($"{student.StudentNumber} {student.Name} {student.LastName}\n");
            }
        }
        public void PrintAllInfo()
        {
            Console.WriteLine($"{Name} {LastName} : ");
            PrintExamResults();
        }
    }
}
