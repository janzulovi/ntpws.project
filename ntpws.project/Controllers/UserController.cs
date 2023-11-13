using Microsoft.AspNetCore.Mvc;
using ntpws.project.Service;

namespace ntpws.project.Web.Controllers
{
    [ApiController]
    [Route("/user")]
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
                _userService = userService;
        }
    }
}
