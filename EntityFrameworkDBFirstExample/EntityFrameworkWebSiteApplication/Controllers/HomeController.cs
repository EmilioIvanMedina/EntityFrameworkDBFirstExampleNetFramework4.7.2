using EntityFrameworkApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkWebSiteApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public HomeController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var contacts = _contactRepository.GetAll();
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}