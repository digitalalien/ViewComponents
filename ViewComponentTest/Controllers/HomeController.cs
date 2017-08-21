using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewComponentTest.Models;
using ViewComponents.Models;

namespace ViewComponentTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var SideNavItems = new List<MenuItemViewModel>();

            SideNavItems.Add(new MenuItemViewModel("Home", "Home"));
            SideNavItems.Add(new MenuItemViewModel("Email", "#"));
            SideNavItems.Add(new MenuItemViewModel("Something", "#"));
            SideNavItems.Add(new MenuItemViewModel("Something Else", "#"));

            var searchBar = new SearchBarViewModel("Home", "Get", "post");
            return View(searchBar);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
