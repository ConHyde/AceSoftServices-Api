using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AceSoftServices_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AceSoftServices_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            using (AceSoftContext db = new AceSoftContext())
            {
                return db.Employee.ToArray();
            }
        }
    }
}