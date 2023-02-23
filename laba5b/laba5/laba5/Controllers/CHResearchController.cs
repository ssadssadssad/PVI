using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace laba5.Controllers
{
    public class CHResearchController : Controller
    {
        // GET: CHResearch
        static int test = 1;

        [OutputCache(Duration = 5)]
        [HttpGet]
        public string AD()
        {
            test++;
            return $"Вывод AD: {test}";
        }

        [OutputCache(Duration = 7, VaryByParam = "x;y")]
        [HttpPost]
        public string AP(int x = 0, int y = 0)
        {
            test++;
            return $"Вывод AP: x = {x}, y = {y}: {test} {DateTime.Now.ToString()}";
        }
    }
}