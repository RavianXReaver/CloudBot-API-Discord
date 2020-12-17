using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DiscordBotAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommandListController : ControllerBase
    { 
        [HttpGet]
        public IEnumerable<Provider> Get()
        {
            
        }
    }
}
