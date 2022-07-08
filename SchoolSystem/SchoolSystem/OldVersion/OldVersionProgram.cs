namespace OldVersion
{
    public class OldVersionProgram
    {
        public static void Process()
        {
            School school = SchoolDatabases.School1();

            Options.MainMenuOptions(school);

        }
    }
}
