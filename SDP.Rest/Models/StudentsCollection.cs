using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDP.Rest.Models
{
    public class StudentsCollection : List<Student>
    {
        public StudentsCollection()
        {
            var students = new Student[]
            {
                new Student { Id = 0, FirstName = "Roch", Lastname = "Kowalski"},
                new Student { Id = 1, FirstName = "Anna", Lastname = "Nowak" },
                new Student { Id = 2, FirstName = "Martyna", Lastname = "Nowaczyk" },
                new Student { Id = 3, FirstName = "Bazyli", Lastname = "Zapolski" },
            };
            this.AddRange(students);
        }
    }
}