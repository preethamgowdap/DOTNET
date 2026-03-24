using System;
using StudentApp.Models;

namespace StudentApp.Services
{
    public class StudentService
    {
        private  List<Student> students = new List<Student>();

        
        public void Initialize()
        {
            students.Clear();
            students.Add(new Student { Id = 1, Name = "Arun",  Marks = 80 });
            students.Add(new Student { Id = 2, Name = "Bala",  Marks = 75 });
            students.Add(new Student { Id = 3, Name = "Chitra",Marks = 90 });
        }

        
        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        
        public bool DeleteStudentById(int id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    students.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        
        public void DisplayFirstStudent()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students to display.");
                return;
            }

            Student first = students[0];
            Console.WriteLine("First Student:");
            Console.WriteLine("Id: " + first.Id);
            Console.WriteLine("Name: " + first.Name);
            Console.WriteLine("Marks: " + first.Marks);
        }

        
        public bool EditStudentById(int id, string newName, int newMarks)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    students[i].Name = newName;
                    students[i].Marks = newMarks;
                    return true;
                }
            }
            return false;
        }

        
        public void DisplayAll()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("(empty)");
                return;
            }

            foreach (Student s in students)
            {
                Console.WriteLine("Id: " + s.Id + ", Name: " + s.Name + ", Marks: " + s.Marks);
            }
        }
    }
}
