using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholManagementSystem
{
    internal class SchoolPrincipal
    {
        private readonly string userName;
        private readonly string password;
        private static School school;


        public SchoolPrincipal(string userName, string password, School school)
        {
            this.userName = userName;
            this.password = password;
            SchoolPrincipal.school = school;
        }

        public void AdminLoginCheckInformation()
        {
            Console.WriteLine("=============== ADMIN LOGIN ===============");
            Console.Write("Please enter username : ");
            string userName = Console.ReadLine();
            Console.Write("Please enter password : ");
            string password = Console.ReadLine();

            bool userNameCheck = userName.Equals(this.userName, StringComparison.OrdinalIgnoreCase);
            bool passwordCheck = password.Equals(this.password);

            if (!userNameCheck)
            {
                Console.WriteLine("Wrong username.");
            }
            else if (!passwordCheck)
            {
                Console.WriteLine("Wrong Password");
            }
            else
            {
                Console.WriteLine("Login successful... WELCOME");
                AdminLoginMenu();
            }
        }
        public void AdminLoginMenu()
        {
            int choice;
            bool flag = true;
            while (flag)
            {
                MenuScreen();
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("Application closed");
                            Environment.Exit(0);
                            break;
                        case 1:
                            foreach (var student in School.studentList)
                            {

                                student.PrintInfoForAdmin();
                            }
                            break;
                        case 2:
                            foreach (var teacher in School.teacherList)
                            {
                                teacher.PrintInfoForAdmin();
                            }
                            break;
                        case 3:
                            foreach (var course in School.courseList)
                            {
                                course.PrintInfoForAdmin();
                            }
                            break;
                        case 4:
                            Console.WriteLine("Logged out successfully ");
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Not a valid option");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public void MenuScreen()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Menu : Choose an option");
            Console.WriteLine("0 - Close Application");
            Console.WriteLine("1 - Print all student information");
            Console.WriteLine("2 - Print all teacher information");
            Console.WriteLine("3 - Print all course information");
            Console.WriteLine("4 - Log Out");
            Console.WriteLine("=============================================");
        }

        public School School { get { return school; } }
    }
}
