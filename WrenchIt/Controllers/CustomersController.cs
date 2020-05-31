using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WrenchIt.Data;
using WrenchIt.Models;
using Newtonsoft.Json;
using System.Net.Http;
using WrenchIt.Data.RepositoryBase.IRepository;
using Microsoft.AspNetCore.Hosting;

namespace WrenchIt.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private static string baseurl = "https://localhost:44361/api";
        private static HttpClient client = new HttpClient();
        private readonly IRepoWrapper _newContext;
        private readonly IWebHostEnvironment _hostEnvironment;

        public CustomersController(IRepoWrapper newContext, IWebHostEnvironment hostEnvironment, ApplicationDbContext context)
        {
            _context = context;
            _newContext = newContext;
            _hostEnvironment = hostEnvironment;
        }
      

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Customers.Include(c => c.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }


        public IActionResult ServiceRequests(int? id)
        {
            var uri = baseurl + "/services/GetServiceRequestByCustomerId/" + id;
            object data = null;
            try
            {
                var responseTask = client.GetAsync(uri).Result;
                data = responseTask.Content.ReadAsStringAsync().Result;

            }
            catch (Exception ex)
            {
                data = ex;
            }

            dynamic response = JsonConvert.DeserializeObject(data.ToString());
            List<ServiceRequest> results = response.ToObject<List<ServiceRequest>>();
            var viewModel = new List<ServiceRequestViewModel>();

            foreach (var item in results)
            {
                var model = viewModel.FirstOrDefault();
                if (model == null) //the transaction is unique
                {
                    model = new ServiceRequestViewModel
                    {
                        Id = item.ServiceId,
                        Name = _newContext.Service.Get(item.ServiceId).Name,
                        Customer = _newContext.Customer.Get(item.CustomerId).FirstName,
                        Quote = item.PriceQuotation,
                        IsCompleted = item.IsCompleted,
                        CreatedAt = item.CreatedAt
                    };
                    viewModel.Add(model);
                }
            }






            return View(viewModel);
        }
        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Address,City,State,ZipCode,Car,IdentityUserId")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
