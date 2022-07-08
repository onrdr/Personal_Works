
namespace OldVersion
{
    internal class SchoolDatabases
    {
        public static School School1()
        {
            School school = new("Anatolian High School");

            new Student("s1", "ss1", "1s", school);
            new Student("s2", "ss2", "2s", school);
            new Student("s3", "ss3", "3s", school);
            new Student("s4", "ss4", "4s", school);
            new Student("s5", "ss5", "5s", school);

            new Teacher("t1", "tt1", "1t",
                        new Course("Math", "101", school), school);
            new Teacher("t2", "tt2", "2t",
                    new Course("Phys", "101", school), school);
            new Teacher("t3", "tt3", "3t",
                    new Course("Chem", "101", school), school);
            new Teacher("t4", "tt4", "4t",
                    new Course("Comp", "101", school), school);
            new Teacher("t5", "tt5", "5t",
                    new Course("Sci", "101", school), school);

            return school;
        }
    }
}
