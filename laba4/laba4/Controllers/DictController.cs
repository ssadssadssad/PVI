using laba4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace laba4.Controllers
{
    public class DictController : Controller
    {
        // GET: Dict
        DB context = new DB();

        [HttpGet]
        public ActionResult Index()
        {
            return View(context);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Update(User user)
        {
            return View(user);
        }

        [HttpGet]
        public ActionResult Delete(User user)
        {
            return View(user);
        }

        [HttpPost]
        public ActionResult AddSave(User user)
        {
            if (ModelState.IsValid)
            {
                context.AddPhone(user);
                return Redirect("Index");
            }
            else
            {
                return View("Add");
            }
        }

        [HttpPost]
        public ActionResult UpdateSave(User user)
        {
            if (ModelState.IsValid)
            {
                context.UpdatePhone(user);
                return Redirect("Index");
            }
            else
            {
                return View("Update", user);
            }
        }

        [HttpPost]
        public ActionResult DeleteSave(User user)
        {
            context.DeletePhone(user);
            return Redirect("Index");
        }
    }
}