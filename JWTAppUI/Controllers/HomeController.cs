using JWTAppUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace JWTAppUI.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "Admin, Member")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult AdminPage()
        {
            return View();
        }

        [Authorize(Roles = "Member")]
        public IActionResult MemberPage()
        {
            return View();
        }
        //[Authorize] Login zorunlu
        public IActionResult AboutPage()
        {
            return View();
        }
    }
}