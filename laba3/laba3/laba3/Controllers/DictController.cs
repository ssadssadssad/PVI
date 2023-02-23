using laba3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace laba3.Controllers
{
    public class DictController : Controller
    {
        // GET: Dict
        [HttpGet]
        public ActionResult Index()
        {
            Methods context = new Methods();
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
            Methods context = new Methods();
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
            Methods context = new Methods();
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
            Methods context = new Methods();
            context.DeletePhone(user);
            return Redirect("Index");
        }
    }
}