using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AceSoftServices_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AceSoftServices_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Driver> GetAll()
        {
            using (AceSoftContext db = new AceSoftContext())
            {
                return db.Driver.ToArray();
            }
        }
        [Route("api/[controller/id]")]
        [HttpGet]
        public Driver GetDriverById(int id)
        {
            using (AceSoftContext db = new AceSoftContext())
            {
                return db.Driver.FirstOrDefault(d => d.Id == id);
            }
        }

    }
}