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
    public class mumblingController : ControllerBase
    {

        [HttpGet("{mumble}")]

        public string Mumble(string mumble)
        {
            return string.Join("", mumble.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        }
    }
}
