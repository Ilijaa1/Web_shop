using Microsoft.AspNetCore.Mvc;

namespace webshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        private readonly ILogger<InfoController> _logger;

        public InfoController(ILogger<InfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Version()
        {
            return "Web shop is working! var 1.0";
        }
    }
}