using System.Collections.Generic;
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
            PersonRepository.AddPerson(person);

            return RedirectToAction("ShowMeAList", "Home");
        }

        public ActionResult ShowMeAList()
        {
            return View("ShowMeAList", PersonRepository.GetAllPersons());
        }

        public static class PersonRepository
        {
            private static List<Person> list = new List<Person>()
            {
                new Person() {FirstName = "Luke", LastName = "Skywalker"},
                new Person() {FirstName = "Leia", LastName = "Organa"},
                new Person() {FirstName = "Han", LastName = "Solo"}
            };

            public static List<Person> GetAllPersons()
            {
                return list;
            }

            public static void AddPerson(Person p)
            {
                list.Add(p);
            }
        }
    }
}