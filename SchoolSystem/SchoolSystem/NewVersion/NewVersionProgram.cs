 
namespace NewVersion
{
    public class NewVersionProgram
    {
        public static void Process()
        { 
            School school = SchoolDatabase.School1(); 

            MainMenuServiceManager option =  new(new LoginServiceManager());
            option.MainMenuOptions(school);


            Console.ReadLine();
        }
    }
}

