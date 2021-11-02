using InClassLab.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InClassLab.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class NameController : Controller
    {

        [HttpGet]

        public NameContent Get()
        {
            return new NameContent
            {
                FirstName = "David",
                LastName = "Draginoff"
            };
        }
        
    }
}
