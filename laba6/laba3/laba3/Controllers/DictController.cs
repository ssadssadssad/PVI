using System.Web.Mvc;
//using SQLTelephoneDictionary;
using TelephoneDictionaryDLL;

namespace laba3.Controllers
{
    public class DictController : Controller
    {
        IPhoneDictionary context;
        public DictController(IPhoneDictionary context)
        {
            this.context = context;
        }

        public ActionResult PartialViewPhone()
        {
            return PartialView();
        }

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
        public ActionResult Update(Person person)
        {
            return View(person);
        }

        [HttpGet]
        public ActionResult Delete(Person person)
        {
            return View(person);
        }

        [HttpPost]
        public ActionResult AddSave(Person person)
        {
            if (ModelState.IsValid)
            {
                context.AddPhone(person);
                return Redirect("Index");
            }
            else
            {
                return View("Add");
            }
        }

        [HttpPost]
        public ActionResult UpdateSave(Person person)
        {
            if (ModelState.IsValid)
            {
                context.UpdatePhone(person);
                return Redirect("Index");
            }
            else
            {
                return View("Update", person);
            }
        }

        [HttpPost]
        public ActionResult DeleteSave(Person person)
        {
            context.DeletePhone(person);
            return Redirect("Index");
        }
    }
}