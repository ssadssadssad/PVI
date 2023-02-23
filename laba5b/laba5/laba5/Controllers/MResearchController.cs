using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace laba5.Controllers
{
    [RoutePrefix("it")]
    public class MResearchController : Controller
    {
        // GET: MResearch
        [HttpGet]
        [Route("{n:int}/{str}")]
        public void M01(int n, string str)
        {
            Response.Write($"GET:M01: /{n}/{str}");
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        [Route("{b:bool}/{letters:alpha}")]
        public void M02(bool b, string letters)
        {
            Response.Write($"{Request.HttpMethod}:M02: /{b}/{letters}");
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Delete)]
        //Delete
        [Route("{f:float}/{str:length(2,5)}")]
        public void M03(float f, string str)
        {
            Response.Write($"{Request.HttpMethod}:M03: /{f}/{str}");
        }

        [HttpPut]
        //[AcceptVerbs(HttpVerbs.Get | HttpVerbs.Put | HttpVerbs.Post)]
        ///put
        [Route("{letters:length(3,4)}/{n:range(100,200)}")]
        public void M04(string letters, int n)
        {
            Response.Write($"{Request.HttpMethod}:M04: /{letters}/{n}");
        }

        [HttpPost]
        [Route(@"{mail:regex(^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$)}")]
        public void M04(string mail)
        {
            Response.Write($"POST: {mail}");
        }
    }
}