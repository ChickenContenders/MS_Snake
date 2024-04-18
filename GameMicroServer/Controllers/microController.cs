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
        /// <summary>
        /// This is an editted version of the original monolithic microservice to only contain the Snake object inside the array.
        /// Instead of reconfiguring the architecture to instead only pass one object it is more efficient to keep the same structure and return a one item list since we are'nt worried about
        /// peak performance at this moment.
        /// </summary>
        private static readonly List<GameInfo> TheInfo = new List<GameInfo>
        {
            new GameInfo { 
                Id = 1,
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
