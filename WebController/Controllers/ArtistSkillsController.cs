using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebController.Entities;

namespace WebController.Controllers
{
    public class ArtistSkillsController : Controller
    {
        private readonly ArtistContext _context;

        public ArtistSkillsController(ArtistContext context)
        {
            _context = context;
        }

        // GET: ArtistSkills
        public async Task<IActionResult> Index()
        {
            return View(await _context.ArtistSkill.ToListAsync());
        }

        // GET: ArtistSkills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artistSkill = await _context.ArtistSkill
                .SingleOrDefaultAsync(m => m.Id == id);
            if (artistSkill == null)
            {
                return NotFound();
            }

            return View(artistSkill);
        }

        // GET: ArtistSkills/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArtistSkills/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArtistSkillId,TalentName,SkillLevel,Details,Styles")] ArtistSkill artistSkill)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artistSkill);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artistSkill);
        }

        // GET: ArtistSkills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artistSkill = await _context.ArtistSkill.SingleOrDefaultAsync(m => m.Id == id);
            if (artistSkill == null)
            {
                return NotFound();
            }
            return View(artistSkill);
        }

        // POST: ArtistSkills/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArtistSkillId,TalentName,SkillLevel,Details,Styles")] ArtistSkill artistSkill)
        {
            if (id != artistSkill.ArtistId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artistSkill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtistSkillExists(artistSkill.Id))
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
            return View(artistSkill);
        }

        // GET: ArtistSkills/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artistSkill = await _context.ArtistSkill
                .SingleOrDefaultAsync(m => m.Id == id);
            if (artistSkill == null)
            {
                return NotFound();
            }

            return View(artistSkill);
        }

        // POST: ArtistSkills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artistSkill = await _context.ArtistSkill.SingleOrDefaultAsync(m => m.Id == id);
            _context.ArtistSkill.Remove(artistSkill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtistSkillExists(int id)
        {
            return _context.ArtistSkill.Any(e => e.Id == id);
        }
    }
}
