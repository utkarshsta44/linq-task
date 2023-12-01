using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace linq_test
{
    class Question9
    {
        public class Student
        {
            int StudentID { get; set; }
            string StudentName { get; set; }
            int Age { get; set; }
            int courseId { get; set; }
        }
        public class Course
        {
            int courseId { get; set; }
             string courseName { get; set; }

        }
        public static void Method()
        {
            List<Student> stud = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "Ajay", Age = 18,courseId=101 } ,
                new Student() { StudentID = 2, StudentName = "Akshsy",  Age = 15,courseId=102 } ,
                new Student() { StudentID = 5, StudentName = "Prince" , Age = 25,courseId=103 },

                new Student() { StudentID = 3, StudentName = "Govind",  Age = 25 ,courseId=104} ,
                new Student() { StudentID = 4, StudentName = "Utkarsh" , Age = 20,courseId=105 } ,
                new Student() { StudentID = 5, StudentName = "Prince" , Age = 19,courseId=106 }
            };

            List<Course> course = new List<Course>()
            {
                new Course(){courseId=101,courseName="MCA"},
                new Course(){courseId=102,courseName="Btech"}
            };

            var joinResult = stud.Join(course,
                                        student => student.courseId, c => c.courseId,
                                        (student, c) => new
                                        {
                                            studentName = student.StudentName,
                                            course = c.courseName
                                        }
                                       );

        }
    }
}
