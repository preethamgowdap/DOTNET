using StudentApi.Models;

namespace StudentApi.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        bool AddStudent(Student student);
        bool UpdateStudent(int id, Student student);
        bool DeleteStudent(int id);
    }
}