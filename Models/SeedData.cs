using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ChristianGomezFinal.Models
{

    public static class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new GameDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<GameDbContext>>()))
            {
                if(context.Games.Any())
                {
                    return;
                }

                context.Games.AddRange(
                    new Game
                    {
                        Title = "Assassin's Creed Valhalla",
                        Dev = "Ubisoft",
                        Characters = new List<Character>{
                            new Character{
                                Name = "Male Eivor",
                                Age = 26,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Magnus Bruun"
                        },
                            new Character{
                                Name = "Basim",
                                Age = 30,
                                isplayable = false,
                                Description = "Antagonist",
                                VoiceActor = "Carlo Rota"
                            }
                        }
                    },
                    new Game
                    {
                        Title = "Red Dead Redemption 2",
                        Dev = "Rockstar",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Authur Morgan",
                                Age = 40,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Roger Clark"
                            },
                            new Character{
                                Name = "John Marston",
                                Age = 26,
                                isplayable = true,
                                Description = "Supporting Character",
                                VoiceActor = "Rob Wiethoff"
                            }
                        }
                    },
                    new Game
                    {
                        Title = "Grand Theft Auto V",
                        Dev = "Rockstar",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Trevor Philips",
                                Age = 46,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Steven Ogg"
                            },
                            new Character{
                                Name = "Michael De Santa",
                                Age = 48,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Ned Luke"
                            },
                            new Character{
                                Name = "Franklin Clinton",
                                Age = 25,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Shawn Darnell Fonteno"
                            }
                        }
                    },
                    new Game
                    {
                        Title = "Borderlands 3",
                        Dev = "Gearbox",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Zane Flynt",
                                Age = 50,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Cian Barry"
                            },
                            new Character{
                                Name = "Maya",
                                Age = 30,
                                isplayable = false,
                                Description = "Supporting Character",
                                VoiceActor = "Martha Harms"
                            }
                        }
                    },
                    new Game
                    {
                        Title = "Batman Arkham Knight",
                        Dev = "Rocksteady",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Bruce Wayne",
                                Age = 38,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Kevin Conroy"
                            },
                            new Character{
                                Name = "Scarecrow",
                                Age = 40,
                                isplayable = false,
                                Description = "Antagonist",
                                VoiceActor = "John Noble"
                            }
                        }
                    },
                    new Game
                    {
                        Title = "Legend of Zelda Breath of the Wild",
                        Dev = "Nintendo",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Zelda",
                                Age = 117,
                                isplayable = false,
                                Description = "Supporting Character",
                                VoiceActor = "Patricia Summersett"
                            }
                        }
                    },
                    new Game
                    {
                        Title = "Halo Infinite",
                        Dev = "343 Industries",
                        Characters = new List<Character> {
                            new Character {
                                Name = "Master Chief",
                                Age = 49,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Steve Downes"
                            },
                            new Character {
                                Name = "Fernando Esparza",
                                Age = 35,
                                isplayable = false,
                                Description = "Supporting Character",
                                VoiceActor = "Nicolas Roye"
                            }
                        }

                    },
                    new Game
                    {
                        Title = "Fallout 4",
                        Dev = "Bethesda",
                        Characters = new List<Character> {
                            new Character{
                                Name = "The Sole Survivor",
                                Age = 247,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Briant T. Delaney"
                            }
                        }
                    },
                    new Game
                    {
                        Title = "Elder Scrolls V Skyrim",
                        Dev = "Bethesda",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Dragonborn",
                                Age = 30,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "NA"
                            }
                        }
                    },
                    new Game{
                        Title = "Elden Ring",
                        Dev = "FromSoftware Inc.",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Melina",
                                Age = 30,
                                isplayable = false,
                                Description = "Supproting Character",
                                VoiceActor = "Martha Mackintosh"
                            }
                        }
                    },
                    new Game{
                        Title = "Star Wars Battlefront 2 2017",
                        Dev = "DICE",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Darth Vader",
                                Age = 52,
                                isplayable = true,
                                Description = "Playable Character",
                                VoiceActor = "Matt Sloan"

                            },
                            new Character{
                                Name = "Boba Fett",
                                Age = 38,
                                isplayable = true,
                                Description = "Playable Character",
                                VoiceActor = "Temuera Morrison"

                            }
                        }
                    },
                    new Game{
                        Title = "Call of Duty Black Ops",
                        Dev = "Treyarch",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Tank Dempsey",
                                Age = 40,
                                isplayable = true,
                                Description = "Playable Character",
                                VoiceActor = "Steven Blum"

                            },
                            new Character{
                                Name = "Edward Richtofen",
                                Age = 58,
                                isplayable = true,
                                Description = "Playable Character",
                                VoiceActor = "Nolan North"
                            }

                        }
                    },
                    new Game{
                        Title = "Call of Duty Modern Warfare 2019",
                        Dev = "Infinity Ward",
                         Characters = new List<Character> {
                            new Character{
                                Name = "John Price",
                                Age = 35,
                                isplayable = true,
                                Description = "Supproting Character",
                                VoiceActor = "Barry Sloane"
                            }
                        }
                    },
                    new Game{
                        Title = "Star Wars Jedi Fallen Order",
                        Dev = "Respawn Entertainment",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Cal Kestis",
                                Age = 20,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Cameron Monaghan"
                            }
                        }
                    },
                    new Game{
                        Title = "Watch Dogs 2",
                        Dev = "Ubisoft",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Marcus Halloway",
                                Age = 25,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Ruffin Prentiss"
                            }
                        }
                    },
                    new Game{
                        Title = "God of War",
                        Dev = "Santa Monica Studio",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Kratos",
                                Age = 1050,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Christopher Judge"
                            }
                        }
                    },
                    new Game{
                        Title = "Far Cry 4",
                        Dev = "Ubisoft",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Pagan Min",
                                Age = 58,
                                isplayable = false,
                                Description = "Antagonist",
                                VoiceActor = "Troy Baker"
                            }
                        }
                    },
                    new Game{
                        Title = "Doom Eternal",
                        Dev = "id Software",
                        Characters = new List<Character> {
                            new Character{
                                Name = "The Doom Slayer",
                                Age = 35,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "NA"
                            }
                        }
                    },
                    new Game{
                        Title = "Witcher 3",
                        Dev = "CD Project Red",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Geralt of Rivia",
                                Age = 98,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Doug Cockle"
                            }
                        }
                    },
                    new Game{
                        Title = "Cyberpunk 2077",
                        Dev = "CD Project Red",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Male V",
                                Age = 26,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Gavin Drea"
                            }
                        }
                    },
                    new Game{
                        Title = "Marvel's Avengers",
                        Dev = "Square Enix",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Captain America",
                                Age = 183,
                                isplayable = true,
                                Description = "Playable Character",
                                VoiceActor = "Jeff Schine"
                            }
                        }
                    },
                    new Game{
                        Title = "Resident Evil Village",
                        Dev = "Capcom",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Chris Redfield",
                                Age = 48,
                                isplayable = true,
                                Description = "Supporting Character",
                                VoiceActor = "Jeff Schine"
                            }
                        }
                    },
                    new Game{
                        Title = "Mafia 3",
                        Dev = "Hanger 13",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Lincoln Clay",
                                Age = 27,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Alex Hernadez"
                            }
                        }
                    },
                    new Game{
                        Title = "Death Stranding",
                        Dev = "Kojima Productions",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Sam Porter Bridges",
                                Age = 36,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Normon Reedus"
                            }
                        }
                    },
                    new Game{
                        Title = "Days Gone",
                        Dev = "Bend Studio",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Deacon St John",
                                Age = 34,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Sam Witwer"
                            }
                        }
                    },
                    new Game{
                        Title = "Ghosts of Tsuchima",
                        Dev = "Sucker Punch",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Jin Sakai",
                                Age = 25,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Daisuke Tsuji"
                            }
                        }
                    },
                    new Game{
                        Title = "Marvel's Spider-man",
                        Dev = "Insomiac",
                        Characters = new List<Character> {
                            new Character{
                                Name = "Miles Morales",
                                Age = 16,
                                isplayable = false,
                                Description = "Suporting Character",
                                VoiceActor = "Nadji Jeter"
                            },
                            new Character{
                                Name = "Peter Parker",
                                Age = 25,
                                isplayable = true,
                                Description = "Protaganist",
                                VoiceActor = "Yuri Lowenthal"
                            }
                        }
                    }
                );

                context.SaveChanges();




            }
            



        }




    }



}