using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WrenchIt.Data;
using WrenchIt.Models;

namespace WrenchIt.Controllers
{
    public class CarController : Controller
    {

        private readonly ApplicationDbContext _context;



        public CarController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //var data 
            return View();
        }


    }
}
