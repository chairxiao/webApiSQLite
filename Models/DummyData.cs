using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiSQLite.Data;

namespace webApiSQLite.Models
{
    public class DummyData
    {
        public static void Initialize(ApplicationDbContext db)
        {
            if (!db.Students.Any())
            {
                db.Students.Add(new Student
                {
                    FirstName = "Bob",
                    LastName = "Doe",
                    School = "Engineering",
                    StartDate = Convert.ToDateTime("2015/09/09")
                });
                db.Students.Add(new Student
                {
                    FirstName = "apple",
                    LastName = "Doe",
                    School = "Art",
                    StartDate = Convert.ToDateTime("2017/09/09")
                });
                db.Students.Add(new Student
                {
                    FirstName = "cat",
                    LastName = "Doe",
                    School = "Tecnic",
                    StartDate = Convert.ToDateTime("2019/09/09")
                });
                db.SaveChanges();
            }
        }
    }
}
