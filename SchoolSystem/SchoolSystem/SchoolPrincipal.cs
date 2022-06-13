using SchoolSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
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
                Message.Error("Wrong username.");
            
            else if (!passwordCheck)            
                Message.Error("Wrong Password");
            
            else
            {
                Message.Success("Login successful... WELCOME");
                AdminLoginMenu();
            }
        }
        public void AdminLoginMenu()
        {
            int choice;
            bool flag = true;
            while (flag)
            {
                Menu.PrincipalScreen();
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            Message.CloseSystem();
                            Environment.Exit(0);
                            break;
                        case 1:
                            School.studentList.ForEach(s => s.PrintInfoForAdmin()); 
                            break;
                        case 2:
                            School.teacherList.ForEach(t => t.PrintInfoForAdmin());
                            break;
                        case 3:
                            School.courseList.ForEach(c => c.PrintInfoForAdmin());
                            break;
                        case 4:
                            Message.Success("Logged out successfully ");
                            flag = false;
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
        public School School=> school;
    }
}
