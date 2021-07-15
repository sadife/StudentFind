using StudentFind.Business.Abstract;
using System.Collections.Generic;
using Student.DataAccess.Abstract;



namespace Student.DataAccess.Concrete
{
    public class StudentManager : IStudentService
    {
       private IStudentRepository _studentRepository;
        public StudentManager(IStudentRepository studentRepository)
        {
             _studentRepository  = studentRepository;

        }

        public StudentFind.Entities.Student CreateStudent(StudentFind.Entities.Student student)
        {
            return _studentRepository.CreateStudent(student);
        }

        public void DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
        }

        public List<StudentFind.Entities.Student> GetAllStudents()
        {
           return _studentRepository.GetAllStudents();
        }

        public StudentFind.Entities.Student GetStudentById(int id)
        {
          return  _studentRepository.GetStudentById(id);
        }

        public StudentFind.Entities.Student UpdateStudent(StudentFind.Entities.Student student)
        {
          return  _studentRepository.UpdateStudent(student);
        }
    }


}
