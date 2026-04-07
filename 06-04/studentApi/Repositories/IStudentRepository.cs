using StudentApi.Models;

namespace StudentApi.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        bool AddStudent(Student student);
        bool UpdateStudent(int id, Student student);
        bool DeleteStudent(int id);
    }

}