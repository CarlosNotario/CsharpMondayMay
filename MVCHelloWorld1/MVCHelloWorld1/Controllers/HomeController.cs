using MVCHelloWorld1.Models;
using System.Web.Mvc;

namespace MVCHelloWorld1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Person person = new Person { FirstName = "", LastName = "Wyatt" };


            return View(person);
        }

        public ActionResult SayHello(Person person)
        {
            person.FirstName = person.FirstName.ToUpper();
            person.LastName = person.LastName.ToUpper();

            return View(person);
        }
    }
}