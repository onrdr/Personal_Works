 
namespace NewVersion
{
    public abstract class Person
    {
        public virtual void ChangePassword(IPerson person)
        {
            Console.WriteLine("Please enter your current password : ");
            string oldPassword = Console.ReadLine();
            if (person.Password.Equals(oldPassword))
            {
                Console.WriteLine("Please enter new password : ");
                person.Password = Console.ReadLine();
                Console.WriteLine("Password changed successfully");
            }
            else
                Messages.Error("Wrong Password");
        }  
    }
}
