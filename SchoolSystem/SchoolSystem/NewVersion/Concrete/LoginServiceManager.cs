
namespace NewVersion
{
    public class LoginServiceManager : ILoginService
    { 
        public void GetLoginInfo(School school, List<ISchoolMember> list)
        {
            Console.Write("Please enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Please enter your last name : ");
            string lastName = Console.ReadLine();
            Console.Write("Please enter your password : ");
            string password = Console.ReadLine();

            IPerson person = (IPerson)school.Find(name, lastName, list);

            CheckLoginInfo(list, person, password);
        }

        private void CheckLoginInfo(List<ISchoolMember> list, IPerson person, string password)
        {   
            if (person == null)
                Messages.Error($"{list[0].GetType().Name} not found.");

            else if (!person.Password.Equals(password))
                Messages.Error("Wrong Password");

            else
            {
                Messages.Welcome(person);
                person.LoginMenu();
            }
        } 

       
    }
}
