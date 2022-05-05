using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChristianGomezFinal.Models
{
    public class Character
    {
        public int ID {get;set;} //Primary Key
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name {get;set;}
        [Range(1,2000)]
        [Required]
        public int Age {get;set;}
        [Required]
        public bool isplayable {get;set;}
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Description{get; set;}
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string VoiceActor{get;set;}

        [Display(Name = "Game")]
        [Required]
        public int GameId{get;set;}  // Foreign Key
        public Game Game {get;set;}  // Navigation Property


    }
}