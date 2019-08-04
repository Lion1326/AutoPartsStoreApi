using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AutoPartsStoreApi.Controllers
{
    [Route ("[controller]")]
    // [ApiController]
    public class MainController : Controller
    {
        [HttpGet ("Index")]
        public ActionResult Index ()
        {
            return View ();
        }

        [HttpGet ("Test")]
        public ActionResult Test ()
        {
            return Json (new { Name = "Test response" });
        }
    }
}