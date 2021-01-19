using Microsoft.AspNetCore.Mvc;
namespace HelloASP
{
    public class HomeController : Controller
    {
        // localhost:5000/
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        // Other code
        [HttpGet("{name}")]
        public string Index(string name)
        {
            return $"Hello {name}!";
        }

        [HttpGet("pizza/{topping}")]
        public string PizzaParty(string topping)
        {
            return $"Who's ready for a {topping} Pizza!";
        }

        [HttpGet("user/{name}/{location}/{age}")]
        public string UserInfo(string name, string location, int age)
        {
            return $"{name}, aged {age}, is from {location}";
        }
    }
}