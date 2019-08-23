using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WitcherKendoEFDemo.Models;

namespace WitcherKendoEFDemo.Controllers
{
    public class CharactersController : Controller
    {
        private readonly WitcherKendoEFDemoContext _context;

        public CharactersController(WitcherKendoEFDemoContext context)
        {
            _context = context;
        }

        // GET: Characters
        public async Task<IActionResult> Index()
        {
            var witcherKendoEFDemoContext = _context.Character.Include(c => c.Weapon);
            return View(await witcherKendoEFDemoContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Character
                .Include(c => c.Weapon)
                .FirstOrDefaultAsync(m => m.CharacterID == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // GET: Characters/Create
        public IActionResult Create()
        {
            ViewData["WeaponID"] = new SelectList(_context.Set<Weapon>(), "WeaponID", "Name");
            return View();
        }

        // POST: Characters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CharacterID,Name,AttackPower,DefensePower,WeaponID")] Character character)
        {
            if (ModelState.IsValid)
            {
                _context.Add(character);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["WeaponID"] = new SelectList(_context.Set<Weapon>(), "WeaponID", "Name", character.WeaponID);
            return View(character);
        }

        // GET: Characters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Character.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }
            ViewData["WeaponID"] = new SelectList(_context.Set<Weapon>(), "WeaponID", "Name", character.WeaponID);
            return View(character);
        }

        // POST: Characters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CharacterID,Name,AttackPower,DefensePower,WeaponID")] Character character)
        {
            if (id != character.CharacterID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(character);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacterExists(character.CharacterID))
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
            ViewData["WeaponID"] = new SelectList(_context.Set<Weapon>(), "WeaponID", "Name", character.WeaponID);
            return View(character);
        }

        // GET: Characters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Character
                .Include(c => c.Weapon)
                .FirstOrDefaultAsync(m => m.CharacterID == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // POST: Characters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var character = await _context.Character.FindAsync(id);
            _context.Character.Remove(character);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        /// <summary>
        /// Boolean that determines if a character exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool CharacterExists(int id)
        {
            return _context.Character.Any(e => e.CharacterID == id);
        }
        /// <summary>
        /// Routes to the battle page as well as showing a "Big" View Model in order to bring in more than one model.
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Battle()
        {
            // Two models wrapped in a "Big" View model.
            BigCharacterWeaponModel bigCharacterWeaponModel = new BigCharacterWeaponModel();
            bigCharacterWeaponModel.Characters = await _context.Character.ToListAsync();
            bigCharacterWeaponModel.Weapons = await _context.Weapon.ToListAsync();
            return View(bigCharacterWeaponModel);
        }
        /// <summary>
        /// Once a battle is submitted, logic is done to determine the winner.
        /// </summary>
        /// <param name="ddlCharacters1"></param>
        /// <param name="ddlCharacters2"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/Results", Name = "BattleSubmit")]
        public async Task<IActionResult> Results( int ddlCharacters1, int ddlCharacters2)
        {
            if(ddlCharacters1 == ddlCharacters2)
            {
                ViewBag.BattleResults = "You can't battle yourself.. Can you?";
                return View();
            }

            var char1 = await _context.Character.Include(c => c.Weapon)
                .FirstOrDefaultAsync(m => m.CharacterID == ddlCharacters1);
            var char2 = await _context.Character.Include(c => c.Weapon)
                .FirstOrDefaultAsync(m => m.CharacterID == ddlCharacters2);

            if (char1.Weapon.AttackPower + char1.AttackPower > char2.DefensePower)
                ViewBag.BattleResults = $"{char1.Name} has defeated {char2.Name} with the mighty weapon, {char1.Weapon.Name}!";
            return View();
        }

        /// <summary>
        /// Returns a JSON object with all the Characters.
        /// </summary>
        /// <returns></returns>
        public JsonResult Characters_Read()
        {
            return Json(_context.Character.ToList());
        }
    }
}
