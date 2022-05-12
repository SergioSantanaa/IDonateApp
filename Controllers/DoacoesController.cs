using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IDonateApp.Models;

namespace IDonateApp.Controllers
{
    public class DoacoesController : Controller
    {
        private readonly IdonateApp _context;

        public DoacoesController(IdonateApp context)
        {
            _context = context;
        }

        // GET: Doacoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Doacao.ToListAsync());
        }

        // GET: Doacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacao = await _context.Doacao
                .FirstOrDefaultAsync(m => m.DoacaoId == id);
            if (doacao == null)
            {
                return NotFound();
            }

            return View(doacao);
        }

        // GET: Doacoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Doacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DoacaoId,OngId,Produto")] Doacao doacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doacao);
        }

        // GET: Doacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacao = await _context.Doacao.FindAsync(id);
            if (doacao == null)
            {
                return NotFound();
            }
            return View(doacao);
        }

        // POST: Doacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DoacaoId,OngId,Produto")] Doacao doacao)
        {
            if (id != doacao.DoacaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoacaoExists(doacao.DoacaoId))
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
            return View(doacao);
        }

        // GET: Doacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacao = await _context.Doacao
                .FirstOrDefaultAsync(m => m.DoacaoId == id);
            if (doacao == null)
            {
                return NotFound();
            }

            return View(doacao);
        }

        // POST: Doacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doacao = await _context.Doacao.FindAsync(id);
            _context.Doacao.Remove(doacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoacaoExists(int id)
        {
            return _context.Doacao.Any(e => e.DoacaoId == id);
        }
    }
}
