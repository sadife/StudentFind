using StudentFind.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace StudentFind.Business.Abstract
{
   public interface IStudentService
    {
        List<StudentFind.Entities.Student> GetAllStudents();
        StudentFind.Entities.Student GetStudentById(int id);
        StudentFind.Entities.Student CreateStudent(StudentFind.Entities.Student student);
        StudentFind.Entities.Student UpdateStudent(StudentFind.Entities.Student student);

        void DeleteStudent(int id);
    }
}
