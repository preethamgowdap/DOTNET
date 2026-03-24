using System;
using StudentApp.Models;
using StudentApp.Services;

namespace StudentApp
{
    class Program
    {
        static void Main()
        {
            var service = new StudentService();

            
            service.Initialize();
            Console.WriteLine("Initial Student List:");
            service.DisplayAll();

            
            var newStudent = new Student { Id = 4, Name = "Divya", Marks = 85 };
            service.AddStudent(newStudent);
            Console.WriteLine("\nAfter Adding a Student (Id=4):");
            service.DisplayAll();

            
            bool removed = service.DeleteStudentById(3);
            Console.WriteLine("\nAfter Deleting Student with Id = 3:");
            service.DisplayAll();

    
            Console.WriteLine();
            service.DisplayFirstStudent();

        
            bool edited = service.EditStudentById(2, "Bala Kumar", 82);
            Console.WriteLine("\nAfter Editing Student with Id = 2:");
            service.DisplayAll();

            
        }
    }
}
