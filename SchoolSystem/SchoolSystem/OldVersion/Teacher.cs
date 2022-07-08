
namespace OldVersion 
{     
    internal class Teacher : IListedObjects<Teacher>
    {
        private readonly string name;
        private readonly string lastName;
        private readonly Course course;
        private string password;
        private static School school;
        private readonly Dictionary<Student, List<double>> examGradesMap = new();

        public Teacher(string name, string lastName, string password, Course course, School school)
        {
            this.name = name;
            this.lastName = lastName;
            this.course = course;
            this.password = password;
            Teacher.school = school;
            course.Teacher = this;
            school.teacherList.Add(this);
        }

        public static void TeacherLoginCheckInformation()
        {
            Console.WriteLine("=============== TEACHER LOGIN ===============");
            Console.Write("Please enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Please enter your last name : ");
            string lastName = Console.ReadLine();
            Console.Write("Please enter your password : ");
            string password = Console.ReadLine();

            Teacher teacher = Finder.FindandReturn(name, lastName, school.teacherList);

            if (teacher == null)
                Messages.Error("Teacher not found.");

            else if (!teacher.password.Equals(password))
                Messages.Error("Wrong Password");

            else
            {
                Messages.Success($"Login successful... WELCOME {teacher.GetFullName()} \n");
                TeacherLoginMenu(teacher);
            }
        }

        public static void TeacherLoginMenu(Teacher teacher)
        {
            int choice;
            bool flag = true;
            while (flag)
            {
                try
                {
                    MenuScreens.TeacherScreen();
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            Messages.CloseSystem();
                            Environment.Exit(0);
                            break;
                        case 1:
                            teacher.EnterExamResults();
                            break;
                        case 2:
                            teacher.ModifyExamResults();
                            break;
                        case 3:
                            teacher.PrintExamResults();
                            break;
                        case 4:
                            teacher.PrintStudentInformation();
                            break;
                        case 5:
                            teacher.ChangePassword();
                            break;
                        case 6:
                            Messages.Success("Logged out successfully ");
                            flag = false;
                            break;
                        default:
                            Messages.Error("Not a valid option");
                            break;
                    }
                }
                catch (Exception)
                {
                    Messages.Error("Invalid Input!!!");
                }
            }
        }

        public void EnterExamResults()
        {
            Student student = FindStudent();
            if (student == null)
                Messages.Error("Student not Found");

            else if (!course.StudentList.Contains(student))
                Messages.Error("Student not in your class");

            else if (!(examGradesMap[student].Count == 0))
            {
                Messages.Error("You have entered exam results before. \nPlease modify results from menu");
            }
            else
            {
                List<double> examGrades = EnterExamGradesAndTakeExamListBack();
                student.ExamGrades.Remove(course);
                student.ExamGrades.Add(course, examGrades);
                examGradesMap.Remove(student);
                examGradesMap.Add(student, examGrades);
                Messages.Success("Added successfully...");
            }
        }

        public void ModifyExamResults()
        {
            bool flag = true;
            foreach (List<double> doubleList in examGradesMap.Values)
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

                else if (!course.StudentList.Contains(student))
                    Messages.Error("Student not in your class");

                else if (examGradesMap[student].Count == 0)
                    Messages.Error("You have not entered exam results for this student.");

                else
                {
                    List<double> examGrades = EnterExamGradesAndTakeExamListBack();
                    student.ExamGrades.Remove(course);
                    student.ExamGrades.Add(course, examGrades);
                    examGradesMap.Remove(student);
                    examGradesMap.Add(student, examGrades);
                    Messages.Success("Modified successfully...");
                }
            }
        }

        public static List<double> EnterExamGradesAndTakeExamListBack()
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
            foreach (List<double> doubleList in examGradesMap.Values)
            {
                if (examGradesMap.Count != 0)
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
                foreach (Student student in examGradesMap.Keys)
                {
                    Console.Write($"{student.StudentNumber} {student.GetFullName()} : ");

                    if (examGradesMap[student].Count == 0)
                    {
                        Messages.Error("No exam result had been entered before\n");
                    }
                    else
                    {
                        doubleList = examGradesMap[student];
                        Console.Write($"Mid1: {doubleList[0]}");
                        Console.Write($", Mid2: {doubleList[1]}");
                        Console.Write($", Final: {doubleList[2]}\n\n");
                    }
                }
            }
        }

        public void PrintStudentInformation()
        {
            if (course.StudentList.Count == 0)
                Messages.Error("No student registered to your course!!!");

            else
            {
                Console.WriteLine("Students List : ");
                foreach (Student student in course.StudentList)
                    Console.Write($"{student.StudentNumber} {student.GetFullName()}\n");
            }
        }

        public void ChangePassword()
        {
            Console.Write("Please enter your current password : ");
            string oldPassword = Console.ReadLine();
            if (password.Equals(oldPassword))
            {
                Console.Write("Please enter new password : ");
                password = Console.ReadLine();
                Messages.Success("Password changed successfully");
            }
            else
                Messages.Error("Wrong Password");
        }

        public static Student FindStudent()
        {
            Console.Write("Please enter student name : ");
            string studentName = Console.ReadLine();
            Console.Write("Please enter student last name : ");
            string studentLastName = Console.ReadLine();

            return Finder.FindandReturn(studentName, studentLastName, school.studentList);
        }

        public Dictionary<Student, List<double>> ExamGradeMap => examGradesMap;

        public string GetName() => name;

        public string GetLastName() => lastName;

        public string GetFullName() => $"{name} {lastName}";
        public void PrintInfoForAdmin()
        {
            Console.WriteLine($"{GetFullName()} : ");
            PrintExamResults();
        }

    }
}
