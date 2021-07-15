using Student.DataAccess.Abstract;
using StudentFind.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Student.DataAccess.Concrete
{
    public class StudentRepository : IStudentRepository
    {
        private IStudentRepository _StudentRepository;
        public void StudentManager()
        {
            _StudentRepository = new StudentRepository();
           
        }
        public StudentFind.Entities.Student CreateStudent(StudentFind.Entities.Student student)
        {
            using (var studentDbContext = new StudentDbContext())
            {

                studentDbContext.students.Add(student);
                studentDbContext.SaveChanges();
                return student;
            }
        }

        public void DeleteStudent(int id)
        {

            using (var studentDbContext = new StudentDbContext()) { 
                var deleteStudent = GetStudentById(id);
                studentDbContext.students.Remove(deleteStudent);
                studentDbContext.SaveChanges();
        }
        }
        public List<StudentFind.Entities.Student> GetAllStudents()
        {
            using (var studentDbContext = new StudentDbContext())
            {

                return studentDbContext.students.ToList();
            }
        }

        public StudentFind.Entities.Student GetStudentById(int id)
        {
            using (var studentDbContext = new StudentDbContext())
            {

                return studentDbContext.students.Find(id);
            }
        }

        public StudentFind.Entities.Student UpdateStudent(StudentFind.Entities.Student student)
        {
            using (var studentDbContext = new StudentDbContext())
            {

                studentDbContext.students.Update(student);
                return student;
            }
        }
    }
}

