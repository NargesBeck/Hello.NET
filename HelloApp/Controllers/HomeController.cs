using HelloApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("GetUserData")]
        [ProducesResponseType(200)]
        public IEnumerable<User> Get()
        {
            return default;
        }
    }
}
