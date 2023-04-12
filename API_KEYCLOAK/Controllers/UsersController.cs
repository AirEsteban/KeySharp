using Microsoft.AspNetCore.Mvc;
using API_KEYCLOAK.Models;
namespace API_KEYCLOAK.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        [Route("[controller]/getUsers")]
        public IActionResult getAllUsers()
        {
            var users = new List<User>();
            var user1 = new User { FirstName = "Juan", Id = 2 , LastName = "Airasca" };
            var user2 = new User { FirstName = "Esteban", Id = 1, LastName = "Airasca"};
            users.Add(user1);
            users.Add(user2);

            return Ok(users);
        }
    }
}
