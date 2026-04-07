using StudentApi.Models;
using StudentApi.Repositories;

namespace StudentApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        
         public bool AddStudent(Student student)
        {
           return _studentRepository.AddStudent(student);
        }
        
        public bool UpdateStudent(int id,Student student)
        {
            return _studentRepository.UpdateStudent(id,student);
        }

        public bool DeleteStudent(int id)
        {
           return  _studentRepository.DeleteStudent(id);
        }
        
    }
        
}