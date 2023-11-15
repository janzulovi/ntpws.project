using Microsoft.AspNetCore.Mvc;
using ntpws.project.Model;
using ntpws.project.Service;
using System.Collections.Generic;

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

        public ActionResult<List<User>> getUsers()
        {
            return _userService.getUsers();
        }

        [HttpPost]
        [Route("/user/new")]
        public ActionResult<User> createNewUser([FromBody] User user)
        {
            return _userService.saveNewUser(user);
        }

        [HttpPut]
        [Route("/user/update")]
        public ActionResult<User> updateUser([FromBody] User user)
        {
            return _userService.updateUser(user);
        }

        [HttpDelete]
        [Route("/user/delete")]
        public void deleteUser([FromBody] User user)
        {
            _userService.deleteUser(user);
        }
    }
}
