using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineStore.Controllers
{
    public class HistoryController : Controller
    {
        [Route("/History")]
        public IActionResult Index()
        {
            ViewData["Message"] = "History";

            return View() ;
        }
    }
}