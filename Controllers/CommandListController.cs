using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CloudBotAPI.Controllers
{
    [ApiController]
    [Route("api/commandlist/getlist")]
    public class CommandListController : ControllerBase
    { 
        [HttpGet]
        public IEnumerable<Provider> Get()
        {
            List<Provider> list = new List<Provider>();

            return list;
        }
    }
}
