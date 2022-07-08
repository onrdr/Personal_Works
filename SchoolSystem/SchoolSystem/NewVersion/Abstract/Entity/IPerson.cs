
namespace NewVersion
{
    public interface IPerson : ISchoolMember
    {
        public string Password { get; set; }
        void ChangePassword(IPerson person);
        void LoginMenu(); 
    }
}
