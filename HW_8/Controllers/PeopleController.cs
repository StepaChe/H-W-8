using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HW_8.Models;

namespace HW_8.Controllers
{
    public class PeopleController : ApiController
    {
        Employee[] peoples = new Employee[]
        {
        new Employee { Id = 1, Name = "Иван", Age = "20", Stage = "2", Salary = 100 },
        new Employee { Id = 2, Name = "Василий", Age = "24", Stage = "2", Salary = 1000 },
        new Employee { Id = 3, Name = "Петр", Age = "37", Stage = "15", Salary = 3000 },
        new Employee { Id = 4, Name = "Семён", Age = "32", Stage = "10", Salary = 5000 },
        new Employee { Id = 3, Name = "Владимир", Age = "44", Stage = "20", Salary = 7000 }
        };
        public IEnumerable<Employee> GetAllEmployee()
        {
            return peoples;
        }
        public IHttpActionResult GetEmployee(int id)
        {
            var people = peoples.FirstOrDefault((p) => p.Id == id);
            if (people == null)
            {
                return NotFound();
            }
            return Ok(people);
        }
    }
}
