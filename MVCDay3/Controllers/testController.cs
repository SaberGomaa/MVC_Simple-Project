using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay3.Controllers
{
    public class testController : Controller
    {
        // GET: test
        [Route("tests/{id}/{name}")]
        public ActionResult Index(int id , string name)
        {
            return View();
        }
    }
}