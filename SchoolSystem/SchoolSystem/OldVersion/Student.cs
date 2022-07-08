
namespace OldVersion
{
    internal class Student : IListedObjects<Student>
    {
        private readonly string name;
        private readonly string lastName;
        private string password;
        private int studentNumber;
        private static int counter = 1;
        private static School school;
        private readonly Dictionary<Course, List<double>> examGrades = new();
        private readonly List<Course> studentCourseList = new();
        public Student(string name, string lastName, string password, School school)
        {
            this.name = name;
            this.lastName = lastName;
            this.password = password;
            Student.school = school;
            studentNumber = counter++;
            school.studentList.Add(this);
        }
        public static void Login()
        {
            Student student = LoginInformation.EnterStudentInfo(school);

            string password = LoginInformation.EnterPassword();

            if (student == null)
                Messages.Error("Student not found.\n");

            else if (!student.password.Equals(password))
                Messages.Error("Wrong Password\n");
            else
            {
                Messages.Success($"WELCOME {student.GetFullName()}. Student Number : {student.studentNumber}\n");
                Options.StudentMenuOptions(student);
            }
        }
        public void PrintExamResults()
        {
            if (examGrades.Count == 0)
                Messages.Error("No course has been added before\n");

            foreach (Course course in examGrades.Keys)
            {
                Console.Write($"{course.GetFullName()} : ");
                if (examGrades[course].Count == 0)
                    Messages.Error("No exam result found for this course!!!\n");

                else
                {
                    List<double> doubleList = examGrades[course];
                    Console.Write($"Mid1: {doubleList[0]}");
                    Console.Write($", Mid2: {doubleList[1]}");
                    Console.Write($", Final: {doubleList[2]}\n\n");
                }
            }

        }

        public void AddCourse(Student student)
        {
            Course c = FindCourse();

            if (c == null)
                Messages.Error("Course doesn't exists");

            else if (studentCourseList.Contains(c))
                Messages.Error("Course is already on the list");

            else
            {
                studentCourseList.Add(c);
                Messages.Success("Course has been added successfully\n");
                examGrades.Add(c, new List<double>());
                c.StudentList.Add(student);
                c.Teacher.ExamGradeMap.Add(this, new List<double>());
            }
        }

        public void RemoveCourse(Student student)
        {
            if (studentCourseList.Count == 0)
                Messages.Error("You don't have any course in your list. Please add a course");

            else
            {
                Course c = FindCourse();

                if (c == null)
                    Messages.Error("Course doesn't exists");

                else if (!studentCourseList.Contains(c))
                    Messages.Error("Course is not on the list");

                else
                {
                    studentCourseList.Remove(c);
                    Messages.Success("Course has been removed successfully");
                    examGrades.Remove(c);
                    c.StudentList.Remove(student);
                    c.Teacher.ExamGradeMap.Remove(student);
                }
            }
        }

        public void PrintCourseList()
        {
            int counter = 0;
            if (studentCourseList.Count == 0)
                Messages.Error("No Course Found!!!");

            else
            {
                Console.WriteLine("Course List : ");
                foreach (Course c in studentCourseList)
                {
                    counter++;
                    Console.WriteLine($"{counter} - {c.GetFullName()}");
                }
            }
        }

        public void ChangePassword()
        {
            Console.WriteLine("Please enter your current password : ");
            string oldPassword = Console.ReadLine();
            if (password.Equals(oldPassword))
            {
                Console.WriteLine("Please enter new password : ");
                password = Console.ReadLine();
                Console.WriteLine("Password changed successfully");
            }
            else
                Messages.Error("Wrong Password");

        }

        static Course FindCourse()
        {
            Console.Write("Please enter the course name : ");
            string name = Console.ReadLine();
            Console.Write("Please enter the course code : ");
            string code = Console.ReadLine();
            Course c = Finder.FindandReturn(name, code, school.courseList);
            return c;
        }

        public Dictionary<Course, List<double>> ExamGrades => examGrades;
        public int StudentNumber
        {
            get => studentNumber;
            set
            {
                studentNumber++;
                studentNumber = value;
            }
        }
        public string GetName() => name;

        public string GetLastName() => lastName;

        public string GetFullName() => $"{name} {lastName}";
        public void PrintInfoForAdmin()
        {
            Console.WriteLine($"{StudentNumber} - {GetFullName()} : ");
            PrintExamResults();
        }

    }
}
