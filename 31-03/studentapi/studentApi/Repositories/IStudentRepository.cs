using StudentApi.Models;

namespace StudentApi.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
    }
}