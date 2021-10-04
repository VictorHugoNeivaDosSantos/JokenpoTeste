using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectJokenpo.Model;
using ProjectJokenpo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectJokenpo.Controllers
{
    [ApiController]
    [Route("Jokenpo/Player")]
    public class PlayerController : ControllerBase
    {

        private readonly IPlayerService _service;

        public PlayerController(IPlayerService service)
        {
            _service = service;
        }
        [HttpPost]
        public long AddPlayer([FromBody] Player player)
        {
            return _service.AddPlayer(player);
        }
    }
}
