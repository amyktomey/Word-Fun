using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace WordFun.Controllers
{
    public class StoryBController : Controller
    {
        private readonly Context _context;

        public StoryBController(Context context)
        {
            _context = context;
        }

        // GET: StoryB
        public async Task<IActionResult> Index()
        {
              return _context.StoryB != null ? 
                          View(await _context.StoryB.ToListAsync()) :
                          Problem("Entity set 'Context.StoryB'  is null.");
        }

        // GET: StoryB/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StoryB == null)
            {
                return NotFound();
            }

            var storyB = await _context.StoryB
                .FirstOrDefaultAsync(m => m.ID == id);
            if (storyB == null)
            {
                return NotFound();
            }

            return View(storyB);
        }

        // GET: StoryB/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StoryB/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Noun1,Noun2,Noun3,Noun4,Noun5,Noun6,Noun7,Adjective1,Adjective2,Adjective3,Verb1,Verb2,Verb3,Verb4,Verb5,Verb6,Interjection")] StoryB storyB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(storyB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(storyB);
        }

        // GET: StoryB/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StoryB == null)
            {
                return NotFound();
            }

            var storyB = await _context.StoryB.FindAsync(id);
            if (storyB == null)
            {
                return NotFound();
            }
            return View(storyB);
        }

        // POST: StoryB/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Noun1,Noun2,Noun3,Noun4,Noun5,Noun6,Noun7,Adjective1,Adjective2,Adjective3,Verb1,Verb2,Verb3,Verb4,Verb5,Verb6,Interjection")] StoryB storyB)
        {
            if (id != storyB.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(storyB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoryBExists(storyB.ID))
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
            return View(storyB);
        }

        // GET: StoryB/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StoryB == null)
            {
                return NotFound();
            }

            var storyB = await _context.StoryB
                .FirstOrDefaultAsync(m => m.ID == id);
            if (storyB == null)
            {
                return NotFound();
            }

            return View(storyB);
        }

        // POST: StoryB/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StoryB == null)
            {
                return Problem("Entity set 'Context.StoryB'  is null.");
            }
            var storyB = await _context.StoryB.FindAsync(id);
            if (storyB != null)
            {
                _context.StoryB.Remove(storyB);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoryBExists(int id)
        {
          return (_context.StoryB?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
