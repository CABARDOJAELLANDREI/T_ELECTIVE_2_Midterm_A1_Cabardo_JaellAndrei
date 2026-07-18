using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            ViewData["Welcome"] = "Welcome to my Portfolio!";
            ViewData["Name"] = "Hello, I'm Jaell Andrei";
            ViewData["Description"] =
                "Hi! My Name is Jaell Andrei O. Cabardo, 3rd year BSIT student at Lyceum of Alabang. I'm interested in Database, Web Development, Cybersecurity, and Cobot Integration.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About";

            ViewData["Biography"] =
                "I am Jaell Andrei Cabardo, a 3rd-year BSIT student actively building a diverse foundation in software development, databases, cybersecurity, and web technologies.";

            ViewData["Goal"] =
                "My goal is to become a software developer capable of building secure, responsive, and user-friendly web applications.";

            ViewData["Education"] = "Bachelor of Science in Information Technology - Currently Taking";

            return View();
        }

        public IActionResult Skills()
        {
            ViewData["Title"] = "Skills";

            ViewData["Languages"] = "C#, Java, Python, SQL, HTML, CSS, JavaScript";
            ViewData["Framework"] = "ASP.NET Core MVC, Bootstrap 5, REST API";
            ViewData["Database"] = "MS SQL Server, Entity Framework Core";
            ViewData["Developer Tools"] = "Visual Studio, Git, GitHub, Pycharm, Dart Studio, XG5000, XPBuilder";

            return View();
        }

        public IActionResult Projects()
        {
            ViewData["Title"] = "Projects";

            ViewData["Project1"] = "Parking Management System";
            ViewData["Project2"] = "Loan Calculator";
            ViewData["Project3"] = "Parking Management System";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact";

            ViewData["Email"] = "jaellandreic@gmail.com";
            ViewData["Phone"] = "+63 (993) 335-1307";
            ViewData["Github"] = "https://github.com/CABARDOJAELLANDREI";
            ViewData["LinkedIn"] = "https://www.linkedin.com/";
            ViewData["Facebook"] = "https://facebook.com/";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
