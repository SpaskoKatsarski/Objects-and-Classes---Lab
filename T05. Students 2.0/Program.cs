using System;
using System.Collections.Generic;

namespace T05._Students_2._0
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { set; get; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Student currentStudentInfo = new Student();

                currentStudentInfo.FirstName = cmdArgs[0];
                currentStudentInfo.LastName = cmdArgs[1];
                currentStudentInfo.Age = int.Parse(cmdArgs[2]);
                currentStudentInfo.HomeTown = cmdArgs[3];

                if (DoesStudentExist(students, currentStudentInfo.FirstName, currentStudentInfo.LastName))
                {
                    Student student = GetStudent(students, currentStudentInfo.FirstName, currentStudentInfo.LastName);

                    student.Age = currentStudentInfo.Age;
                    student.HomeTown = currentStudentInfo.HomeTown;
                }
                else
                {
                    students.Add(currentStudentInfo);
                }

                command = Console.ReadLine();
            }

            string city = Console.ReadLine();

            List<Student> orderedList = students.FindAll(student => student.HomeTown == city);

            foreach (var student in orderedList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        static bool DoesStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }
}
