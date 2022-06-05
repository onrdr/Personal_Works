using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholManagementSystem
{
    internal class Database

    {
        public School SchoolInformation1()
        {

            School school1 = new School("Anatolian High School"); 

            new Student("s1", "ss1", "1s", school1);
            new Student("s2", "ss2", "2s", school1);
            new Student("s3", "ss3", "3s", school1);
            new Student("s4", "ss4", "4s", school1);
            new Student("s5", "ss5", "5s", school1);

            new Teacher("t1", "tt1", "1t",
                    new Course("Math", "101", school1), school1);
            new Teacher("t2", "tt2", "2t",
                    new Course("Phys", "101", school1), school1);
            new Teacher("t3", "tt3", "3t",
                    new Course("Chem", "101", school1), school1);
            new Teacher("t4", "tt4", "4t",
                    new Course("Comp", "101", school1), school1);
            new Teacher("t5", "tt5", "5t",
                    new Course("Sci", "101", school1), school1);

            return school1;
        }


    }
}
