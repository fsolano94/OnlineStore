﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineStore.Controllers
{
    public class HistoryController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "History";

            return View() ;
        }
    }
}