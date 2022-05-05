using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ChristianGomezFinal.Models;

namespace ChristianGomezFinal.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly ChristianGomezFinal.Models.GameDbContext _context;

        public DetailsModel(ChristianGomezFinal.Models.GameDbContext context)
        {
            _context = context;
        }

        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.Games.Include(g =>g.Characters).FirstOrDefaultAsync(m => m.GameId == id);

            if (Game == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
