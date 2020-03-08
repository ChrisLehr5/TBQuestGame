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
                            "....."
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 2,
                    Name = "Hallway",
                    Description = "The long hallway streches further into the manor. It is cluttered with family heirlooms and knicknacks picked up on travels. " +
                            "A plush rug pads the hall, leaving your footsteps muffled. Keronsene lamps are spread down the passage, giving off a flickering light " + "" +
                            "and the smell that you have associated with home. The faint ticking of multiple clocks can be heard.",
                    Accessible = true,
                    ModifiyExperiencePoints = 10,
                    Message = "From this location you can travel further down the hallway, or into the Parlor on the left, or the library on the right."
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 3,
                    Name = "Parlor",
                    Description = "The formal parlor smells of dust and disuse. Your family isn't one for formalities- the informal parlor is used more often." +
                            "The furniture within this room is stiff and uncomfortable looking- hard chairs and highly decorative overstuffed pillows." +
                            "You see something sparkle for a moment on top of a gaudy looking desk near the window. ",
                    Accessible = true,
                    ModifiyExperiencePoints = 10
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 4,
                    Name = "Twilight",
                    Description = "Sinking to the ground you hear the sound of running water " +
                            "and smell the sharpness of citrus. Blinking your eyes you realize that you have entered a vision from a long ago picnic " +
                            "and you feel the prescene of your aunt calling your name." +
                            "Content to stay here your energy slips away unoticed until you are dead.",
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
                    Name = "Garden",
                    Description = "You step into a lush tropical garden inside of sturdy glass walls. The air in here is cool and soothing. " +
                            " A seperate realm from the rest of the house you feel at ease and your energy returns as you wander the peaceful setting." +
                            "You notice a statue inside the main water feature wearing a necklace.",
                    Accessible = false,
                    ModifiyExperiencePoints = 20,
                    ModifyHealth = 50,
                    Message = "This area is currently locked."
                }
                );

            gameMap.Locations.Add
                (new Location()
                {
                    Id = 6,
                    Name = "Middle Hallway",
                    Description = "Further down the hallway you can see one of the clocks. A tall grandfather clock stands along the right wall." +
                            "Placing your hand against it you realize it isn't showing the correct time- rather it is 3 hours behind." +
                            "Placeholder",
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

