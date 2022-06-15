using ArchosServerSide.Helpers;
using ArchosServerSide.Interfaces.IServices;
using ArchosServerSide.Repositories.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArchosServerSide.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly IAccountService _account;

        public AccountController(IAccountService account)
        {
            _account = account;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _account.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        [Helpers.Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _account.GetAll();
            return Ok(users);
        }
    }
}
