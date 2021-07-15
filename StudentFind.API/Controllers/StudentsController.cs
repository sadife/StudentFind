using Microsoft.AspNetCore.Mvc;
using StudentFind.Business.Abstract;
using StudentFind.DataAccess;

using System.Collections.Generic;


namespace StudentFind.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public List<StudentFind.Entities.Student> Get()
        {
           return _studentService.GetAllStudents();
        }
        [HttpGet("{id}")]
        public StudentFind.Entities.Student GetStudentById(int id)
        {
            return _studentService.GetStudentById(id);
        }
        [HttpPost]
        public StudentFind.Entities.Student Post([FromBody]StudentFind.Entities.Student student)
        {

            return _studentService.CreateStudent(student);
        }
        [HttpPut]
        public StudentFind.Entities.Student Put([FromBody] StudentFind.Entities.Student student)
        {
            using (var StudentDbContext = new StudentDbContext())
            {

                StudentDbContext.students.Update(student);
                StudentDbContext.SaveChanges();
                return student;
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

             _studentService.DeleteStudent(id);
        }

    }
}
