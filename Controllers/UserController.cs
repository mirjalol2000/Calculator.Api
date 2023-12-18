using Calculator.Api.Models.Users;
using Calculator.Api.Services.Foundations.Users;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
>>>>>>> 18bde343e770de1c858f36429d5089abe2f4b058

namespace Calculator.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<User>> PostUserAsync(User user)
        {
            return await this.userService.AddUserAsync(user);
        }
    }
}
