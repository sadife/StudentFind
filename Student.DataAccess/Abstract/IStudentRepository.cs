using System;
using System.Collections.Generic;
using System.Text;
using Student.DataAccess;

namespace Student.DataAccess.Abstract
{
  public interface IStudentRepository
    {

        List<StudentFind.Entities.Student> GetAllStudents();
        StudentFind.Entities.Student GetStudentById(int id);
        StudentFind.Entities.Student CreateStudent(StudentFind.Entities.Student student);
        StudentFind.Entities.Student UpdateStudent(StudentFind.Entities.Student student);

        void DeleteStudent(int id); 


    }
}
