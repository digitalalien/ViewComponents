using Microsoft.AspNetCore.Mvc;
using ViewComponents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents
{
    public class SideNav : ViewComponent
    {
        //This is where wew would get nav items from the DB for now we just pretend
        public async Task<IViewComponentResult> InvokeAsync(MenuViewModel menu)
        {;   
            return View(menu);
        }

    }
}
