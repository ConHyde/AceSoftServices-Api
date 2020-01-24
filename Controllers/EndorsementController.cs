﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AceSoftServices_Api.Data;
using AceSoftServices_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AceSoftServices_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndorsementController : ControllerBase
    {
        public IEnumerable<Endorsement> GetAll()
        {
            using (AceSoftContext db = new AceSoftContext())
            {
                return db.Endorsement.ToArray();
            }
        }
    }
}