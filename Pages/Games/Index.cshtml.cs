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

        [BindProperty(SupportsGet = true)]
        public int PageNum {get;set;} =1;
        public int PageSize {get;set;} =10;

        [BindProperty (SupportsGet = true)]
        public string CurrentSort {get;set;}
        public async Task OnGetAsync()
        {
            var query = _context.Games.Select(g => g);

            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(g => g.Title);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(g => g.Title);
                    break;
            }

            switch (CurrentSort)
            {
                case "dev_asc":
                    query = query.OrderBy(g => g.Dev);
                    break;
                case "dev_desc":
                    query = query.OrderByDescending(g => g.Dev);
                    break;
            }


            Game = await query.Skip((PageNum-1)*PageSize).ToListAsync();
        }
    }
}
