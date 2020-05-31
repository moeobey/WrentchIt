using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WrenchIt.Data;
using WrenchIt.Data.RepositoryBase.IRepository;
using WrenchIt.Models;

namespace WrenchIt.Controllers
{
    public class ServiceRequest : Controller
    {
        private static string baseurl = "localhost:5000/api";
        private static HttpClient client = new HttpClient();

        public ServiceRequest(IRepoWrapper context, IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
            _context = context;
        }
        public IActionResult Index()
        {
            var uri = baseUrl + "GetAll";
            object data = null;
            try
            {
                var responseTask = client.GetAsync(uri).Result;
                var result = responseTask.Content.ReadAsStringAsync().Result;
                return result;
            }
            catch (Exception ex)
            {
                data = ex;
            }
            var ServiceRequestViewModel = new ServiceRequestViewModel()
            {

            };

            return View(data);
        }

        public IActionResult Edit(int? id)
        {
            var car = new Car();


            if (id != null)
            {
                car = _context.Car.Get(id.GetValueOrDefault());
            }
            return View(car);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _hostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                if (car.Id == 0)
                {
                    //new service service type
                    car.CustomerId = 5;
                    _context.Car.Add(car);
                }
                else
                {
                    //edit service

                    _context.Car.Update(car);
                }
                _context.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(car);
            }
        }

    }
}
