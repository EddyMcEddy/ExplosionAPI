using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class explosionController : ControllerBase
    {

        [HttpGet("{explosion}")]
        public string Explosion(string explosion)
        {
            //Joining in strings and selecting the VALUE and creating a new string of VALUES
            return string.Join("", explosion.Select(value => new String(value, int.Parse(value.ToString()))));
        }


    }
}
