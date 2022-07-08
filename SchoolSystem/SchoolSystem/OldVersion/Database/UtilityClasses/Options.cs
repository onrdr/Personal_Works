

namespace OldVersion
{
    internal class Options
    {
        public static void StudentMenuOptions(Student student)
        {
            int choice;
            bool flag = true;
            while (flag)
            {
                try
                {
                    MenuScreens.StudentScreen();
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            Messages.CloseSystem();
                            Environment.Exit(0);
                            break;
                        case 1:
                            student.AddCourse(student);
                            break;
                        case 2:
                            student.RemoveCourse(student);
                            break;
                        case 3:
                            student.PrintExamResults();
                            break;
                        case 4:
                            student.PrintCourseList();
                            break;
                        case 5:
                            student.ChangePassword();
                            break;
                        case 6:
                            Messages.Success("Logged out successfully");
                            flag = false;
                            break;
                        default:
                            Messages.Error("Not a Valid Option!!!");
                            break;
                    }
                }
                catch (Exception)
                {
                    Messages.Error("Invalid Input");
                }
            }
        }

        public static void MainMenuOptions(School school)
        {
            int choice;
            bool flag = true;

            while (flag)
            {
                MenuScreens.MainScreen();
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            Messages.CloseSystem();
                            flag = false;
                            break;
                        case 1:
                            Student.Login();
                            break;
                        case 2:
                            Teacher.TeacherLoginCheckInformation();
                            break;
                        case 3:
                            school.Principal.AdminLoginCheckInformation();
                            break;
                        default:
                            Messages.Error("Not a valid option");
                            break;
                    }
                }
                catch (Exception)
                {
                    Messages.Error("Invalid Input");
                }
            }
        }
    }
}
