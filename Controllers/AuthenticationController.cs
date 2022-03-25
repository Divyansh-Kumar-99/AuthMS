using AuthenticationApi.Models;
using AuthenticationApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AuthenticationApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IAuthenticateService _authenticateService;
        private readonly ILogger _logger;
        public AuthenticationController(IAuthenticateService authenticateService, ILogger<AuthenticationController> logger)
        {
            _logger = logger;
            _authenticateService = authenticateService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] User model)
        {
            _logger.LogInformation("Welcome to Return Order Management");
            var users = _authenticateService.Authenticate(model.UserName, model.Password);
            if (User == null)
                return BadRequest(new { message = "Username or Password is incorrect" });
            return Ok(users);
        }
    }
}
