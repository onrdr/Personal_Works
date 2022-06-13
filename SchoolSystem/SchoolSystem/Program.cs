using SchoolSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu(Database.School1());
        }
        public static void MainMenu(School school)
        {
            int choice;
            bool flag = true;
            while (flag)
            {
                Menu.MainScreen();
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            Message.CloseSystem();
                            flag = false;
                            break;
                        case 1:
                            Student.StudentLoginCheckInformation();
                            break;
                        case 2:
                            Teacher.TeacherLoginCheckInformation();
                            break;
                        case 3:
                            school.Principal.AdminLoginCheckInformation();
                            break;
                        default:
                            Message.Error("Not a valid option");
                            break;
                    }
                }
                catch (Exception)
                {
                    Message.Error("Invalid Input");
                }
            }
        }
    }
}
