using StudentApi.Models;

namespace StudentApi.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        
        private readonly List<Student> students = new()
        {
            new Student { Id = 1, Name = "Preetham", Age = 22, Department = "IT" },
            new Student { Id = 2, Name = "Rahul", Age = 21, Department = "CSE" },
            new Student { Id = 3, Name = "Ananya", Age = 23, Department = "ECE" },
            new Student { Id = 4, Name = "prajwal", Age = 20, Department = "IS" }
        };

        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}