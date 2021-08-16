using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetEjercicio.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace NetEjercicio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var jsonUsers = JsonConvert.SerializeObject(UserAction.GetAll());
            return Json(jsonUsers);
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            UserAction.Add(user);
            var jsonUser = JsonConvert.SerializeObject(user);
            return Json(jsonUser);
        }

        public IActionResult GetById(int UserId)
        {
            var foundUser = UserAction.GetById(UserId);
            var jsonUser = JsonConvert.SerializeObject(foundUser);
            return Json(jsonUser);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
