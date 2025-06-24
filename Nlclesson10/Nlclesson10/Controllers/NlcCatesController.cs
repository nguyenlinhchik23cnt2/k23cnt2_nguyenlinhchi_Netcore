using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nlclesson10.Models;

namespace Nlclesson10.Controllers
{
    public class NlcCatesController : Controller
    {
        private readonly Nlck23cnt2lesson10dbContext _context;

        public NlcCatesController(Nlck23cnt2lesson10dbContext context)
        {
            _context = context;
        }

        // GET: NlcCates
        public async Task<IActionResult> NlcIndex()
        {
            return View(await _context.NlcCates.ToListAsync());
        }

        // GET: NlcCates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nlcCate = await _context.NlcCates
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (nlcCate == null)
            {
                return NotFound();
            }

            return View(nlcCate);
        }

        // GET: NlcCates/Create
        public IActionResult NlcCreate()
        {
            return View();
        }

        // POST: NlcCates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NlcCreate([Bind("CatId,CateName,CateStatus")] NlcCate nlcCate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nlcCate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nlcCate);
        }

        // GET: NlcCates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nlcCate = await _context.NlcCates.FindAsync(id);
            if (nlcCate == null)
            {
                return NotFound();
            }
            return View(nlcCate);
        }

        // POST: NlcCates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatId,CateName,CateStatus")] NlcCate nlcCate)
        {
            if (id != nlcCate.CatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nlcCate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NlcCateExists(nlcCate.CatId))
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
            return View(nlcCate);
        }

        // GET: NlcCates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nlcCate = await _context.NlcCates
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (nlcCate == null)
            {
                return NotFound();
            }

            return View(nlcCate);
        }

        // POST: NlcCates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nlcCate = await _context.NlcCates.FindAsync(id);
            if (nlcCate != null)
            {
                _context.NlcCates.Remove(nlcCate);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NlcCateExists(int id)
        {
            return _context.NlcCates.Any(e => e.CatId == id);
        }
    }
}
