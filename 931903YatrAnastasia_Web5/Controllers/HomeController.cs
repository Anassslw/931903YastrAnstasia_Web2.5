using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _YatrAnastasia_Web5.Models;
using _YatrAnastasia_Web5.Data;
using Microsoft.EntityFrameworkCore;

namespace _YatrAnastasia_Web5.Controllers
{
    public class HomeController : Controller
    {
        private HospitalContext db;

        public HomeController(HospitalContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Hospitals.ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
