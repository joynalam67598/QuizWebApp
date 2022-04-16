using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QuizWebApp.Controllers
{
    public class TestController : Controller
    {
        public  IActionResult StartTest()
        {

            return View();
        }
    }
}
