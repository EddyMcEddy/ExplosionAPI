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
    public class ReverseController : ControllerBase
    {
        [HttpGet("{ReverseWord}")]
        public string ReverseWord(string ReverseWord)
        {
            //RETURNING a string with .Reverse and then adding it to the new ARRAY
            return new string(ReverseWord.Reverse().ToArray());
        }
    }

}
