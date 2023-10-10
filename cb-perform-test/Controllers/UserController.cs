using cb_perform_test.Models;
using cb_perform_test.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace cb_perform_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ITestService<User> _userService;

        public UserController(ITestService<User> userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string email)
        {
            var result = await _userService.GetUserByEmail(email);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Set([FromBody] User user)
        {
            var result = await _userService.InsertUser(user);

            return Ok(result);
        }
    }
}
