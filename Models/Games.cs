using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChristianGomezFinal.Models
{
    public class Game
    {
        public int GameId {get;set;} //Primary Key
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title{get;set;}
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Dev{get;set;}
        

        public List<Character> Characters {get;set;} // Navigation Property
    }
}