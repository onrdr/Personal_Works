
namespace NewVersion
{
    public interface ISchoolMember : IEntity
    {
        public string LastName { get; set; }
        public School School { get; set; } 
        void PrintAllInfo();
    }
}
