using CalculatorAPI.Model;
using CalculatorAPI.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IJWTValidationService _jWTValidationService;

        public AccountController(IJWTValidationService jWTValidationService)
        {
            _jWTValidationService = jWTValidationService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            if (model.Username == "user" && model.Password == "password")
            {
                var token = _jWTValidationService.GenerateJwtToken(model.Username);
                 
                return Ok(new { token });
            }
            else
            {
                return BadRequest("Invalid Username or Password");
            }
        }

        
    }

   
}
