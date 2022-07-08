
namespace NewVersion
{
    public class Principal : Person, IPerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public School School { get; set; }

        public void LoginMenu()
        { 
            while (true)
            {
                MenuScreens.PrincipalScreen();
                int choice = Option.GetValidChoice(5);
                switch (choice)
                {
                    case 0:
                        Messages.CloseSystem();
                        Environment.Exit(0);
                        break;
                    case 1:
                        School.StudentList.ForEach(s => s.PrintAllInfo());
                        break;
                    case 2:
                        School.TeacherList.ForEach(t => t.PrintAllInfo());
                        break;
                    case 3:
                        School.CourseList.ForEach(c => c.PrintAllInfo());
                        break;
                    case 4:
                        base.ChangePassword(this);
                        break;
                    case 5:
                        Messages.Success("Logged out successfully "); 
                        return;
                }
            }
        }

        public void PrintAllInfo()
        {
            Console.WriteLine($"Principle : {Name} {LastName} - School Name : {School.Name}");
        }
    }
}