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
        // GET: api/Student/5
        public string Get(int id)
        {
            return "value";
        }
        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }
        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }
        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
