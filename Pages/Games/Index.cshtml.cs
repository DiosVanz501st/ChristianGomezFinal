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
    public class IndexModel : PageModel
    {
        private readonly ChristianGomezFinal.Models.GameDbContext _context;

        public IndexModel(ChristianGomezFinal.Models.GameDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Games.ToListAsync();
        }
    }
}
