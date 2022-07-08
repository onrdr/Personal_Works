
namespace OldVersion
{
    internal class LoginInformation
    {
        public static Student EnterStudentInfo(School school)
        {
            Console.WriteLine("=============== STUDENT LOGIN ===============");
            Console.Write("Please enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Please enter your last name : ");
            string lastName = Console.ReadLine(); 

            Student student = Finder.FindandReturn(name, lastName, school.studentList);

            return student;
        }

        public static string EnterPassword()
        {
            Console.Write("Please enter your password : ");
            string password = Console.ReadLine();
            return password;
        }
    }
}
