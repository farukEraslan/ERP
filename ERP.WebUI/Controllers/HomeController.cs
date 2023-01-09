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
    }
}