using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace Micro
{
    [ApiController]
    [Route("[controller]")]
    public class MicroController : ControllerBase
    {
        private static readonly GameInfo TheInfo = new GameInfo
        {
            new GameInfo { 
                //Id = 1,
                Title = "Snake",
                //Content = "~/js/snake.js",
                Author = "Hillary clinton ",
                DateAdded = "01/01/1942",
                Description = "Look at me im a SNEEEEK",
                HowTo = "Just snek around",
                //Thumbnail = "/images/snake.jpg" //640x360 resolution
            }
        };

        private readonly ILogger<MicroController> _logger;

        public MicroController(ILogger<MicroController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<GameInfo> Get()
        {
            return TheInfo;
        }
    }
}
