using EmployeeApiDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApiDemo.Controllers
{
    [ApiController]

    [Route("api/[controller]")]

    public class EmployeeController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Kamal",
                    Salary = 50000
                },

                new Employee
                {
                    Id = 2,
                    Name = "Rahul",
                    Salary = 60000
                }
            };

            return Ok(employees);
        }
    }
}
