﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WrenchIt.Data;
using WrenchIt.Data.Repository.IRepository;
using WrenchIt.Models;

namespace WrenchIt.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IRepoWrapper  _context;
        private readonly IWebHostEnvironment  _hostEnvironment;

        public ServicesController(IRepoWrapper context,IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Category
        public async Task<IActionResult> Index()
        {
            return View();
        }

        //make api call for category.js 
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _context.Services.GetAll(includeProperties:"Category") });
        }
       
        //edit update insert category
        public IActionResult UpdateInsert(int? id)
        {
            Category category = new Category();
            if(id == null)
            {
                return View(category);
            }
            category = _context.Category.Get(id.GetValueOrDefault());
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateInsert(Category category)
        {
            if (ModelState.IsValid)
            {
                if(category.Id == 0)
                {
                    _context.Category.Add(category);
                }
                else
                {
                    _context.Category.Update(category);
                }
                _context.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objectFromDb = _context.Category.Get(id);
            if (objectFromDb == null)
            {
                return Json(new { success = false, message = "Unable to delete." });
            }
            _context.Category.Remove(objectFromDb);
            _context.Save();
            return Json(new { success = true, message = "Delete successfull." });
        }

        // GET: Category/Details/5
        //        public async Task<IActionResult> Details(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return NotFound();
        //            }

        //            var category = await _context.Category
        //                .FirstOrDefaultAsync(m => m.Id == id);
        //            if (category == null)
        //            {
        //                return NotFound();
        //            }

        //            return View(category);
        //        }

        //        // GET: Category/Create
        //        public IActionResult Create()
        //        {
        //            return View();
        //        }

        //        // POST: Category/Create
        //        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> Create([Bind("Id,Name,DisplayOrder")] Category category)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                _context.Add(category);
        //                await _context.SaveChangesAsync();
        //                return RedirectToAction(nameof(Index));
        //            }
        //            return View(category);
        //        }

        //        // GET: Category/Edit/5
        //        public async Task<IActionResult> Edit(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return NotFound();
        //            }

        //            var category = await _context.Category.FindAsync(id);
        //            if (category == null)
        //            {
        //                return NotFound();
        //            }
        //            return View(category);
        //        }

        //        // POST: Category/Edit/5
        //        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,DisplayOrder")] Category category)
        //        {
        //            if (id != category.Id)
        //            {
        //                return NotFound();
        //            }

        //            if (ModelState.IsValid)
        //            {
        //                try
        //                {
        //                    _context.Update(category);
        //                    await _context.SaveChangesAsync();
        //                }
        //                catch (DbUpdateConcurrencyException)
        //                {
        //                    if (!CategoryExists(category.Id))
        //                    {
        //                        return NotFound();
        //                    }
        //                    else
        //                    {
        //                        throw;
        //                    }
        //                }
        //                return RedirectToAction(nameof(Index));
        //            }
        //            return View(category);
        //        }

        //        // GET: Category/Delete/5
        //        public async Task<IActionResult> Delete(int? id)
        //        {
        //            if (id == null)
        //            {
        //                return NotFound();
        //            }

        //            var category = await _context.Category.FirstOrDefaultAsync(m => m.Id == id);
        //            if (category == null)
        //            {
        //                return NotFound();
        //            }

        //            return View(category);
        //        }

        //        // POST: Category/Delete/5
        //        [HttpPost, ActionName("Delete")]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> DeleteConfirmed(int id)
        //        {
        //            var category = await _context.Category.FindAsync(id);
        //            _context.Category.Remove(category);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }

        //        private bool CategoryExists(int id)
        //        {
        //            return _context.Category.Any(e => e.Id == id);
        //        }
    }
}