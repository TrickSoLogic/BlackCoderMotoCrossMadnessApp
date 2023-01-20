﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BlackCoderMotoCrossMadnessApp.Motekar;

namespace BlackCoderMotoCrossMadnessApp.Areas.security.Controllers
{
    [Area("security")]
    [Authorize(Roles = SecurityModules.Dashboards)]
    public class DashboardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}