using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_corecontainers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public object Get([FromServices] IConfiguration configuration)
        {
            return new
            {
                Local = Environment.MachineName,
                Mensagem = configuration["MENSAGEM"]
            };
        }
    }
}
