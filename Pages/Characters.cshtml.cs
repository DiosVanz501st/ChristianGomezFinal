using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ChristianGomezFinal.Models;

namespace ChristianGomezFinal.Pages
{
    public class CharacterModel : PageModel
    {
        private readonly GameDbContext _context;
        private readonly ILogger<CharacterModel> _logger;
        public List<Character> Characters {get;set;}

        public CharacterModel(GameDbContext context,ILogger<CharacterModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
                Characters = _context.Characters.ToList();
        }
    }
}
