 
namespace NewVersion
{
    public static class MenuScreens
    {
        public static void MainScreen()
        {
            string menu =
            "===================================\n" +
            "Menu : Choose an option\n" +
            "0 - Close Application\n" +
            "1 - Student Login Menu\n" +
            "2 - Teacher Login Menu\n" +
            "3 - Admin Login Menu\n" +
            "===================================";
            Console.WriteLine(menu);
        } 
        public static void PrincipalScreen()
        {
            string menu =
            "=============================================" +
            "\nMenu : Choose an option" +
            "\n0 - Close Application" +
            "\n1 - Print all student information" +
            "\n2 - Print all teacher information" +
            "\n3 - Print all course information" +
            "\n4 - Log Out" +
            "\n=============================================";
            Console.WriteLine(menu);
        }
        public static void StudentScreen()
        {
            string menu =
                    "==============================================" +
                    "\nMenu : Choose an option" +
                    "\n0 - Close Application" +
                    "\n1 - Add a course to your course list" +
                    "\n2 - Remove a course from your course list" +
                    "\n3 - Print your exam results" +
                    "\n4 - Print your course list" +
                    "\n5 - Change Password" +
                    "\n6 - Log Out" +
                    "\n============================================";
            Console.WriteLine(menu);
        }

        public static void TeacherScreen()
        { 
            string menu = "=====================================" +
                    "\nMenu : Choose an option" +
                    "\n0 - Close Application" +
                    "\n1 - Enter exam results" +
                    "\n2 - Modify exam results" +
                    "\n3 - Print exam results" +
                    "\n4 - Print student list" +
                    "\n5 - Change Password" +
                    "\n6 - Log Out" +
                    "\n=====================================";
            Console.WriteLine(menu);
        }
    }
}
