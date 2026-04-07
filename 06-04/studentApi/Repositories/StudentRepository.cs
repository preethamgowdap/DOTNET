using StudentApi.Models;

namespace StudentApi.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        
        private static List<Student> students = new()
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

        
         public bool AddStudent(Student student)
        {
             int nextId=students.Count > 0 ?students.Max(s => s.Id)+1:1;
             student.Id = nextId;
             
             students.Add(student);
             return true;
        }

        public bool UpdateStudent(int id,Student updateStudent)
        {
            var existingStudent = students.FirstOrDefault(s =>s.Id == id);

            if(existingStudent != null)
            {
                existingStudent.Name = updateStudent.Name;
                existingStudent.Age = updateStudent.Age;
                existingStudent.Department = updateStudent.Department;
                return true;
            }  
               throw new  KeyNotFoundException($"Student with ID {id} was not Found."); 
        }
          

        public bool  DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if(student != null)
            {
               
                students.Remove(student);
                return true;
            }
              throw new  KeyNotFoundException($"Student with ID {id} was not Found.");   
        }
    }
}