
namespace NewVersion
{
    public interface ILoginService : ISchoolService
    {
        void GetLoginInfo(School school, List<ISchoolMember> list); 
    }
}
