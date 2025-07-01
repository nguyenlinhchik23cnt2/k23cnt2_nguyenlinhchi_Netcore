using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nlc_2310900014.Models;

namespace Nlc_2310900014.Controllers
{
    public class NlcEmployeesController : Controller
    {
        private readonly Nguyenlinhchi2310900014Context _context;

        public NlcEmployeesController(Nguyenlinhchi2310900014Context context)
        {
            _context = context;
        }

        // GET: NlcEmployees
        public async Task<IActionResult> NlcIndex()
        {
            return View(await _context.NlcEmployees.ToListAsync());
        }

        // GET: NlcEmployees/Details/5
        public async Task<IActionResult> NlcDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nlcEmployee = await _context.NlcEmployees
                .FirstOrDefaultAsync(m => m.NlcEmpId == id);
            if (nlcEmployee == null)
            {
                return NotFound();
            }

            return View(nlcEmployee);
        }

        // GET: NlcEmployees/Create
        public IActionResult NlcCreate()
        {
            return View();
        }

        // POST: NlcEmployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NlcCreate([Bind("NlcEmpId,NlcEmpName,NlcEmpLevel,NlcEmpStartDate,NlcEmpStatus")] NlcEmployee nlcEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nlcEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NlcIndex));
            }
            return View(nlcEmployee);
        }

        // GET: NlcEmployees/Edit/5
        public async Task<IActionResult> NlcEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nlcEmployee = await _context.NlcEmployees.FindAsync(id);
            if (nlcEmployee == null)
            {
                return NotFound();
            }
            return View(nlcEmployee);
        }

        // POST: NlcEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NlcEdit(int id, [Bind("NlcEmpId,NlcEmpName,NlcEmpLevel,NlcEmpStartDate,NlcEmpStatus")] NlcEmployee nlcEmployee)
        {
            if (id != nlcEmployee.NlcEmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nlcEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NlcEmployeeExists(nlcEmployee.NlcEmpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(NlcIndex));
            }
            return View(nlcEmployee);
        }

        // GET: NlcEmployees/Delete/5
        public async Task<IActionResult> NlcDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nlcEmployee = await _context.NlcEmployees
                .FirstOrDefaultAsync(m => m.NlcEmpId == id);
            if (nlcEmployee == null)
            {
                return NotFound();
            }

            return View(nlcEmployee);
        }

        // POST: NlcEmployees/Delete/5
        [HttpPost, ActionName("NlcDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nlcEmployee = await _context.NlcEmployees.FindAsync(id);
            if (nlcEmployee != null)
            {
                _context.NlcEmployees.Remove(nlcEmployee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NlcIndex));
        }

        private bool NlcEmployeeExists(int id)
        {
            return _context.NlcEmployees.Any(e => e.NlcEmpId == id);
        }
    }
}
