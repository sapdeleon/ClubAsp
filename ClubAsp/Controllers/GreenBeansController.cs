using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClubAsp.Data;
using ClubAsp.Models;

namespace ClubAsp.Controllers
{
    public class GreenBeansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GreenBeansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GreenBeans
        public async Task<IActionResult> Index()
        {
            return View(await _context.GreenBean.ToListAsync());
        }

        // GET: GreenBeans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var greenBean = await _context.GreenBean
                .FirstOrDefaultAsync(m => m.Id == id);
            if (greenBean == null)
            {
                return NotFound();
            }

            return View(greenBean);
        }

        // GET: GreenBeans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GreenBeans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BinNo,GreenClass,LotNumber,BinLevel")] GreenBean greenBean)
        {
            if (ModelState.IsValid)
            {
                _context.Add(greenBean);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(greenBean);
        }

        // GET: GreenBeans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var greenBean = await _context.GreenBean.FindAsync(id);
            if (greenBean == null)
            {
                return NotFound();
            }
            return View(greenBean);
        }

        // POST: GreenBeans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BinNo,GreenClass,LotNumber,BinLevel")] GreenBean greenBean)
        {
            if (id != greenBean.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(greenBean);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GreenBeanExists(greenBean.Id))
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
            return View(greenBean);
        }

        // GET: GreenBeans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var greenBean = await _context.GreenBean
                .FirstOrDefaultAsync(m => m.Id == id);
            if (greenBean == null)
            {
                return NotFound();
            }

            return View(greenBean);
        }

        // POST: GreenBeans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var greenBean = await _context.GreenBean.FindAsync(id);
            _context.GreenBean.Remove(greenBean);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GreenBeanExists(int id)
        {
            return _context.GreenBean.Any(e => e.Id == id);
        }
    }
}
