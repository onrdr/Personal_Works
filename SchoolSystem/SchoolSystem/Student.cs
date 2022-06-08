using SchoolSystem.Utils;
using System;
using System.Collections.Generic;

namespace SchoolSystem
{
    internal class Student : IListedObjects<Student>
    {
        private readonly string name;
        private readonly string lastName;
        private string password;
        private int studentNumber;
        private static int counter = 1;
        private static School school;
        private readonly Dictionary<Course, List<double>> examGrades = new();
        private readonly List<Course> studentCourseList = new();
        public Student(string name, string lastName, string password, School school)
        {
            this.name = name;
            this.lastName = lastName;
            this.password = password;
            Student.school = school;
            this.studentNumber = counter++;
            school.studentList.Add(this);
        }
        public static void StudentLoginCheckInformation()
        {
            Console.WriteLine("=============== STUDENT LOGIN ===============");
            Console.Write("Please enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Please enter your last name : ");
            string lastName = Console.ReadLine();
            Console.Write("Please enter your password : ");
            string password = Console.ReadLine();
            Student student = (Student)school.FindandReturn(name, lastName, school.studentList);

            if (student == null)
            {
                Message.Error("Student not found.\n");
            }
            else if (!student.password.Equals(password))
            {
                Message.Error("Wrong Password\n");
            }
            else
            {
                Message.Success($"WELCOME {student.GetFullName()}. Student Number : {student.studentNumber}\n");
                StudentLoginMenu(student);
            }
        }

        public static void StudentLoginMenu(Student student)
        {
            int choice;
            bool flag = true;
            while (flag)
            {
                try
                {
                    MenuScreen();
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            Message.CloseSystem();
                            Environment.Exit(0);
                            break;
                        case 1:
                            student.AddCourse(student);
                            break;
                        case 2:
                            student.RemoveCourse(student);
                            break;
                        case 3:
                            student.PrintExamResults();
                            break;
                        case 4:
                            student.PrintCourseList();
                            break;
                        case 5:
                            student.ChangePassword();
                            break;
                        case 6:
                            Message.Success("Logged out successfully");
                            flag = false;
                            break;
                        default:
                            Message.Error("Not a Valid Option!!!");
                            break;
                    }
                }
                catch (Exception)
                {
                    Message.Error("Invalid Input");
                }
            }
        }

        public void PrintExamResults()
        {
            if (examGrades.Count == 0)
            {
                Message.Error("No course has been added before\n");
            }
            foreach (Course course in examGrades.Keys)
            {
                Console.Write($"{course.GetFullName()} : ");
                if (examGrades[course].Count == 0)
                {
                    Message.Error("No exam result found for this course!!!\n");
                }
                else
                {
                    List<double> doubleList = examGrades[course];
                    Console.Write($"Mid1: {doubleList[0]}");
                    Console.Write($", Mid2: {doubleList[1]}");
                    Console.Write($", Final: {doubleList[2]}\n\n");
                }
            }

        }

        public void AddCourse(Student student)
        {
            Course c = FindCourse();

            if (c == null)
            {
                Message.Error("Course doesn't exists");
            }
            else if (studentCourseList.Contains(c))
            {
                Message.Error("Course is already on the list");
            }
            else
            {
                studentCourseList.Add(c);
                Message.Success("Course has been added successfully\n");
                examGrades.Add(c, new List<double>());
                c.StudentList.Add(student);
                c.Teacher.ExamGradeMap.Add(this, new List<double>());
            }
        }

        public void RemoveCourse(Student student)
        {
            if (studentCourseList.Count == 0)
            {
                Message.Error("You don't have any course in your list. Please add a course");
            }
            else
            {

                Course c = FindCourse();

                if (c == null)
                {
                    Message.Error("Course doesn't exists");
                }
                else if (!studentCourseList.Contains(c))
                {
                    Message.Error("Course is not on the list");
                }
                else
                {
                    studentCourseList.Remove(c);
                    Message.Success("Course has been removed successfully");
                    examGrades.Remove(c);
                    c.StudentList.Remove(student);
                    c.Teacher.ExamGradeMap.Remove(student);
                }
            }
        }

        public void PrintCourseList()
        {
            int counter = 0;
            if (studentCourseList.Count == 0)
            {
                Message.Error("No Course Found!!!");
            }
            else
            {
                Console.WriteLine("Course List : ");
                foreach (Course c in studentCourseList)
                {
                    counter++;
                    Console.WriteLine($"{counter} - {c.GetFullName()}");
                }
            }
        }

        public void PrintInfoForAdmin()
        {
            Console.WriteLine($"{StudentNumber} - {this.GetFullName()} : ");
            PrintExamResults();
        }

        public void ChangePassword()
        {
            Console.WriteLine("Please enter your current password : ");
            string oldPassword = Console.ReadLine();
            if (password.Equals(oldPassword))
            {
                Console.WriteLine("Please enter new password : ");
                this.password = Console.ReadLine();
                Console.WriteLine("Password changed successfully");
            }
            else
            {
                Message.Error("Wrong Password");
            }
        }

        static Course FindCourse()
        {
            Console.Write("Please enter the course name : ");
            string name = Console.ReadLine();
            Console.Write("Please enter the course code : ");
            string code = Console.ReadLine();
            Course c = (Course)school.FindandReturn(name, code, school.courseList);
            return c;
        }

        public static void MenuScreen()
        {
            String menu = "=====================================" +
                    "\nMenu : Choose an option" +
                    "\n0 - Close Application" +
                    "\n1 - Add a course to your course list" +
                    "\n2 - Remove a course from your course list" +
                    "\n3 - Print your exam results" +
                    "\n4 - Print your course list" +
                    "\n5 - Change Password" +
                    "\n6 - Log Out" +
                    "\n=====================================";
            Console.WriteLine(menu);
        }

        public Dictionary<Course, List<double>> ExamGrades { get { return examGrades; } }
        public int StudentNumber
        {
            get { return studentNumber; }
            set
            {
                studentNumber++;
                studentNumber = value;
            }
        }
        public string GetName()
        {
            return name;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public string GetFullName()
        {
            return this.name + " " + this.lastName;
        }

    }
}
