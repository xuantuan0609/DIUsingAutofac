using DIUsingAutofac.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DIUsingAutofac.Filters;

namespace DIUsingAutofac.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogRepository _blogRepository;
        public HomeController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetWebsite()
        {
            ViewBag.Website = _blogRepository.GetWebsite();
            return View();
        }
        [InstancePerRequestFilter]
        public ActionResult DemoInstancePerRequest(AbstractInstancePerRequest instance)
        {
            ViewBag.Text = instance.Text;
            return View();
        }
    }
}