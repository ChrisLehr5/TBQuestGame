using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;

namespace TBQuestGame.DataLayer
{
    public static class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                Name = "Bonzo",
                Age = 43,
                JobTitle = Player.JobTitleName.Casual,
                Trait = Character.TraitType.Strength,
                Health = 100,
                Lives = 3,
                ExperiencePoints = 0,
                LocationId = 0
            };
        }

        public static List<string> InitialMessages()
        {
            return new List<string>()
            {
                "\tWelcome.",
                "\tYou will be tested shortly."
            };
        }

        public static Map GameMap()
        {
            Map gameMap = new Map();

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 1,
                    Name = "Entrance",
                    Description = "The family manor is located in the English countryside. " +
                            "Stately, the Victorian home boasts two wings and a small tower that dominates the skyline." +
                            "The ornate wrought iron gate is open; the empty manor beckons you inside...",
                    Accessible = true,
                    ModifiyExperiencePoints = 10,
                    Message = "\tYou have come home from boarding school to your family residence. " +
                            "Looking around you realize that no one appears to be home, as no one comes out to greet you." +
                            "You are left with two options- to stand in front of the door, or to go inside... " +
                            "Perhaps you find some clue as to where your Aunt has gone?"
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 2,
                    Name = "Aion Base Lab",
                    Description = "The Norlon Corporation research facility located in the city of Heraklion on " +
                            "the north coast of Crete and the top secret research lab for the Aion Project.\nThe lab is a large, " + "" +
                            "well lit room, and staffed by a small number of scientists, all wearing light blue uniforms with the hydra-like Norlan Corporation logo.",
                    Accessible = true,
                    ModifiyExperiencePoints = 10,
                    Message = "Traveler, to move from location to location, simply touch the name of the desired location on your forearm."
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 3,
                    Name = "Felandrian Plains",
                    Description = "The Felandrian Plains are a common destination for tourist. Located just north of the " +
                            "equatorial line on the planet of Corlon, they provide excellent habitat for a rich ecosystem of flora and fauna.",
                    Accessible = true,
                    ModifiyExperiencePoints = 10
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 4,
                    Name = "Epitoria's Reading Room",
                    Description = "Queen Epitoria, the Torian Monarh of the 5th Dynasty, was know for her passion for " +
                            "galactic history. The room has a tall vaulted ceiling, open in the middle  with four floors of wrapping " +
                            "balconies filled with scrolls, texts, and infocrystals. As you enter the room a red fog desends from the ceiling " +
                            "and you begin feeling your life energy slip away slowly until you are dead.",
                    Accessible = false,
                    ModifiyExperiencePoints = 50,
                    ModifyLives = -1,
                    RequiredExperiencePoints = 40
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 5,
                    Name = "Xantoria Market",
                    Description = "The Xantoria market, once controlled by the Thorian elite, is now an open market managed " +
                            "by the Xantorian Commerce Coop. It is a place where many races from various systems trade goods." +
                            "You purchase a blue potion in a thin, clear flask, drink it and receive 50 points of health.",
                    Accessible = false,
                    ModifiyExperiencePoints = 20,
                    ModifyHealth = 50,
                    Message = "Traveler, our telemetry places you at the Xantoria Market. We have reports of local health potions."
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 6,
                    Name = "The Tamfasia Galactic Academy",
                    Description = "The Tamfasia Galactic Academy was founded in the early 4th galactic metachron. " +
                            "You are currently in the library, standing next to the protoplasmic encabulator that stores all " +
                            "recorded information of the galactic history.",
                    Accessible = true,
                    ModifiyExperiencePoints = 10
                }
                );

            //
            // set the initial location for the player
            //
            gameMap.CurrentLocation = gameMap.Locations.FirstOrDefault(l => l.Id == 1);

            return gameMap;
        }
    }
}

