
namespace NewVersion
{
    public static class SchoolDatabase
    {
        public static School School1()
        {
            int counter = 0;
            School school = new()
            {
                Name = "Anatolian High School",
            };

            school.CourseList.Add(new Course { Name = "Math", LastName = "101", School = school });
            school.CourseList.Add(new Course { Name = "Phys", LastName = "101", School = school });
            school.CourseList.Add(new Course { Name = "Chem", LastName = "101", School = school });
            school.CourseList.Add(new Course { Name = "Comp", LastName = "101", School = school });
            school.CourseList.Add(new Course { Name = "Sci", LastName = "101", School = school });

            school.StudentList.Add(new Student() { Name = "s1", LastName = "ss1", Password = "1s", School = school });
            school.StudentList.Add(new Student() { Name = "s2", LastName = "ss2", Password = "2s", School = school });
            school.StudentList.Add(new Student() { Name = "s3", LastName = "ss3", Password = "3s", School = school });
            school.StudentList.Add(new Student() { Name = "s4", LastName = "ss4", Password = "4s", School = school });
            school.StudentList.Add(new Student() { Name = "s5", LastName = "ss5", Password = "5s", School = school });


            school.TeacherList.Add(new Teacher()
            {
                Name = "t1",
                LastName = "tt1",
                Password = "1t",
                School = school,
                Course = (Course)school.CourseList[counter++]
            });
            Course c = (Course)school.CourseList[counter - 1];
            c.Teacher = (Teacher)school.TeacherList[counter - 1];

            school.TeacherList.Add(new Teacher()
            {
                Name = "t2",
                LastName = "tt2",
                Password = "2t",
                School = school,
                Course = (Course)school.CourseList[counter++]
            });
            Course c2 = (Course)school.CourseList[counter - 1];
            c2.Teacher = (Teacher)school.TeacherList[counter - 1];

            school.TeacherList.Add(new Teacher()
            {
                Name = "t3",
                LastName = "tt3",
                Password = "3t",
                School = school,
                Course = (Course)school.CourseList[counter++]
            });
            Course c3 = (Course)school.CourseList[counter - 1];
            c3.Teacher = (Teacher)school.TeacherList[counter - 1];

            school.TeacherList.Add(new Teacher()
            {
                Name = "t4",
                LastName = "tt4",
                Password = "4t",
                School = school,
                Course = (Course)school.CourseList[counter++]
            });
            Course c4 = (Course)school.CourseList[counter - 1];
            c4.Teacher = (Teacher)school.TeacherList[counter - 1];

            school.TeacherList.Add(new Teacher()
            {
                Name = "t5",
                LastName = "tt5",
                Password = "5t",
                School = school,
                Course = (Course)school.CourseList[counter++]
            });
            Course c5 = (Course)school.CourseList[counter - 1];
            c5.Teacher = (Teacher)school.TeacherList[counter - 1];

            school.PrincipleList.Add(new Principal
            {
                Name = "p1",
                LastName = "pp1",
                Password = "1p",
                School= school
            });

            return school;
        }

    }
}
