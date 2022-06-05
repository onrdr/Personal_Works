using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu(SchoolInformation());
        }


        public static void MainMenu(School school)
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

        private static void MenuScreen()
        {
            string menu = "=============================================\n" +
            "Menu : Choose an option\n" +
            "0 - Close Application\n" +
            "1 - Student Login Menu\n" +
            "2 - Teacher Login Menu\n" +
            "3 - Admin Login Menu\n" +
            "=============================================";
            Console.WriteLine(menu);
        }

        public static School SchoolInformation()
        {
            Database db = new();
            return db.SchoolInformation1();
        }
    }
}
