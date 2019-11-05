using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApiSQLite.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String School { get; set; }
        public DateTime StartDate { get; set; }

    }
}
