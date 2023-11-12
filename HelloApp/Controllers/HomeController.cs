using HelloApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet(Name = "GetUserData")]
        public IEnumerable<User> Get()
        {
            return default;
        }
    }
}
