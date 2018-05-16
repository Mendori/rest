using SDP.Rest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SDP.Rest.Controllers
{
    public class StudentController : ApiController
    {
        private List<Student> students = new StudentsCollection();

        // GET: api/Student
        public IEnumerable<Student> Get()
        {
            return students;
        }

        //// GET: api/Student/5
        //public string Get(int id)
        //{
        //    return "value";
        //}
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();
            else
                return Ok(student);
        }
        [Route("{name}")]
        public IHttpActionResult Get(string name)
        {
            var student = students.FirstOrDefault(s => s.FirstName.Contains(name));
            if (student == null)
                return NotFound();
            else
                return Ok(student);
        }
        [Route("{name}")]
        [HttpGet]
        public IHttpActionResult FindStudentByName(string name)
        {
            var student = students.FirstOrDefault(s => s.FirstName.Contains(name));
            if (student == null)
                return NotFound();
            else
                return Ok(student);
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }
        // POST: api/Student
        [Route("")]
        public IHttpActionResult Post([FromBody]Student newStudent)
        {
            newStudent.Id = students.Count();
            students.Add(newStudent);
            return Ok(students);
        }
        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }
        // DELETE: api/Student/5
        public void Delete()//ind id inside
        {
        }
        // DELETE: api/Student/5
        [Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                return Ok(students);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
