using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AutoPartsStore.Controllers
{
    [Route ("[controller]")]
    // [ApiController]
    public class MainController : Controller
    {
        private IUserRepository userRepository;
        public MainController (IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet ("Index")]
        public ActionResult Index ()
        {

            return View ();
        }

        [HttpGet ("Test")]
        public ActionResult Test ()
        {
            return Json (userRepository.GetList ());
        }
    }
}