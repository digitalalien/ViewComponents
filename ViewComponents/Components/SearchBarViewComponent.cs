﻿using Microsoft.AspNetCore.Mvc;
using ViewComponents.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ViewComponents
{
    public class SearchBar : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
