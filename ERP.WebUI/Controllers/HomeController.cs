using ERP.Core.Abstract;
using ERP.Entities.Concrete;
using ERP.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ERP.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICoreService<UserEntity> _userService;

        public HomeController(ILogger<HomeController> logger, ICoreService<UserEntity> userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Missionvision()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult OurTeam()
        {
            return View();
        }

        public IActionResult References()
        {
            return View();
        }

        public IActionResult Quote()
        {
            return View();
        }
    }
}