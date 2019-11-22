using Microsoft.AspNetCore.Mvc;

namespace MicroQuiz.Services.Operations.Api.Controllers
{
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("MicroQuiz Operations Service");
    }
}