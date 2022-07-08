
namespace NewVersion
{
    public class MainMenuServiceManager : IMainMenuService
    {
        readonly ILoginService _loginCheckService;
        public MainMenuServiceManager(ILoginService loginCheckService)
        {
            _loginCheckService = loginCheckService;
        }
        public void MainMenuOptions(School school)
        {
            while (true)
            {
                MenuScreens.MainScreen();
                int choice = Option.GetValidChoice(3);
                switch (choice)
                {
                    case 0:
                        Messages.CloseSystem();
                        return;
                    case 1:
                        Messages.Login("STUDENT");
                        _loginCheckService.GetLoginInfo(school, school.StudentList);
                        break;
                    case 2:
                        Messages.Login("TEACHER");
                        _loginCheckService.GetLoginInfo(school, school.TeacherList);
                        break;
                    case 3:
                        Messages.Login("PRINCIPLE");
                        _loginCheckService.GetLoginInfo(school, school.PrincipleList);
                        break;
                }
            }
        }
    } 
}

