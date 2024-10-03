using EntityFrameworkApplication.Interfaces;
using EntityFrameworkWebSiteApplication.ViewModels;
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
            var vm = new ContactViewModel
            {
                Contacts = contacts,
                Message = "Your contact page.",
                Title = "Contacts",
            };

            return View(vm);
        }
    }
}