using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TestyMcTestfaceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class testyController : ControllerBase
    {


        [HttpPost("handler")]
        public async Task<SkillResponse> handler([FromBody] SkillRequest skillRequest)
        {
            return ResponseBuilder.Tell("Hi, I'm Testy McTestFace");
        }



    }
}