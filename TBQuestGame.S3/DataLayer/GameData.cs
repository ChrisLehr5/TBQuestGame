using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                PlayStyle = Player.PlayThroughDifficulty.Casual,
                Trait = Character.TraitType.Strength,
                Health = 100,
                Lives = 3,
                ExperiencePoints = 0,
                LocationId = 0,
                Inventory = new ObservableCollection<GameItem>()
                {
                    GameItemById(1002),
                    GameItemById(2001)
                }
            };
        }

        private static GameItem GameItemById(int id)
        {
            return StandardGameItems().FirstOrDefault(i => i.Id == id);
        }

        public static GameMapCoordinates InitialGameMapLocation()
        {
            return new GameMapCoordinates() { Row = 0, Column = 0 };
        }

        public static Map GameMap()
        {
            int rows = 4;
            int columns = 4;

            Map gameMap = new Map(rows, columns);
            gameMap.StandardGameItems = StandardGameItems();


            gameMap.MapLocations[0, 0] = new Location()
            {
                Id = 1,
                Name = "Street",
                Description = "You exit the cab, taking a moment to stretch.  " +
               "The trip from school was long and tedious, and you are happy to finally be home.",
                Accessible = true,
                ModifiyExperiencePoints = 10,
                Message = "",
                GameItems = new ObservableCollection<GameItem>()
                {
                    GameItemById(3001),
                    GameItemById(4001),
                    GameItemById(4002)
                }
            };


            gameMap.MapLocations[1, 0] = new Location()
            {
                Id = 1,
                Name = "Entrance",
                Description = "The Family Manor is a stately Victorian, boasting numerous rooms and turrets.  " +
                "The wrought iron gate swings in the breeze, and the door is slightly ajar. " +
                "Home from school, you wonder where your aunt is.",
                Accessible = true,
                ModifiyExperiencePoints = 10,
                Message = "\tYou expected to be greeted at the gate as usual by your Aunt, whom lives in the Manor." +
                "It's very unusual that nobody is in sight- leaving you the options of standing here wondering " +
                "or going inside to see what is going on... "
            };
            gameMap.MapLocations[1, 1] = new Location()
            {
                Id = 2,
                Name = "Front Hallway",
                Description = "The Hallway connected to the entrance. " +
                "To your left is the door to the parlor, to the right the vaulted entrance to the library." + "" +
                "The Hallway itself is padded with thick rugs, the walls covered in knicknacks and curios from all over the world.",
                Accessible = true,
                ModifiyExperiencePoints = 10
            };

            gameMap.MapLocations[0, 1] = new Location()
            {
                Id = 3,
                Name = "Parlor",
                Description = "The rarely used formal Parlor. Inside has a stuffy dusty smell and the furniture is ornate- and uncomfortable." +
                "You notice that the curio cabinet against the far wall has a drawer that is slightly ajar, and there is a hand mirror sitting " +
                "on the small desk between the chairs.",
                Accessible = false,
                RequiredKeyId = 4001,
                ModifiyExperiencePoints = 10
            };

            gameMap.MapLocations[2, 1] = new Location()
            {
                Id = 4,
                Name = "Library",
                Description = "The giant room is stuffed to the brim with books." +
                "Curiously your Aunt's Parrot is perched in the middle of the room, sitting on a globe your grandfather procured." +
                "Noticing you, it looks expectant.",
                Accessible = true,
                ModifiyExperiencePoints = 10,
                Message = "That Parrot is a noisy gossip but it has never liked you. There may be something around to trick it- " +
                "maybe if it thinks you are someone else it'll give you a clue..."
            };

            gameMap.MapLocations[3, 1] = new Location()
            {
                Id = 5,
                Name = "Garden",
                Description = "The air is cool and heavy inside the tropical garden. The outside world melts away between the thick glass walls." +
                "A large water feature dominates the center of the room, of which inside stands a statue of a woman pouring water from a pitcher." +
                "A necklace hangs around her neck, sparkling from the samp mist.",
                Accessible = false,
                ModifiyExperiencePoints = 20,
                ModifyHealth = 50,
                Message = "Something about that necklace looks familiar..."
            };
            gameMap.MapLocations[1, 2] = new Location()
            {
                Id = 6,
                Name = "Hallway Middle",
                Description = "Thick rugs are still under feet in the middle of the Hallway but you can now hear the ticking of a clock. " +
                "Further inspections reveal a large grandfather clock.",
                Accessible = true,
                ModifiyExperiencePoints = 10
            };

            gameMap.MapLocations[1, 3] = new Location()
            {
                Id = 7,
                Name = "Back Hallway",
                Description = "The Hallway ends here, with a door to the left and right. ",
                Accessible = true,
                ModifiyExperiencePoints = 10,
                Message = "You know there is a servants entrance to the upstairs, but which way?"
            };

            return gameMap;
        }
        public static List<GameItem> StandardGameItems()
        {
            return new List<GameItem>()
            {
                new Key(1002, "Phaser", 250, "Phasers are common and versatile phased array pulsed energy projectile weapons.", 10, "This looks like it opens something.", Key.UseActionType.OPENLOCATION),
                new Treasure(2001, "Gold Coin", 10, Treasure.TreasureType.Mirror, "24 karat gold coin", 1),
                new Treasure(2002, "Small Diamond", 50, Treasure.TreasureType.Necklace, "A small pea-sized diamond of various colors.", 1),
                new Treasure(2003, "Kalzonian Manuscript", 10, Treasure.TreasureType.Whistle, "Reportedly stolen during the Zantorian raids of of the 4th dynasty, it is said to contain information about early galactic technologies.", 5),
                new Potion(3001, "Distilled Baladorian Lion Mucus", 5, 40, 1, "Rare potion due to the dangers of procurement. Add 40 points of health.", 5),
                new Key(4001, "Crystal Key", 5, "Conjured by the Forest Wizard, it opens many doors.", 5, "You have opened the Epitoria's Reading Room.", Key.UseActionType.OPENLOCATION),
                new Key(4002, "Stick of Adol", 5, "Long polished wooden rod with sliding silver ribbons..", 5, "Sliding the silver ribbons, you feel a sharp pain in your left temple and quickly die.", Key.UseActionType.KILLPLAYER)
            };
        }
    }
}


//This is working code:
//            gameMap.MapLocations[0, 0] = new Location()
//            {
//                Id = 1,
//                Name = "Entrance",
//                Description = "The Family Manor is a stately Victorian, boasting numerous rooms and turrets.  " +
//                "The wrought iron gate swings in the breeze, and the door is slightly ajar. " +
//                "Home from school, you wonder where your aunt is.",
//                Accessible = true,
//                ModifiyExperiencePoints = 10,
//                Message = "\tYou expected to be greeted at the gate as usual by your Aunt, whom lives in the Manor." +
//                "It's very unusual that nobody is in sight- leaving you the options of standing here wondering " +
//                "or going inside to see what is going on... "
//            };
//            gameMap.MapLocations[0, 1] = new Location()
//            {
//                Id = 2,
//                Name = "Front Hallway",
//                Description = "The Hallway connected to the entrance. " +
//                "To your left is the door to the parlor, to the right the vaulted entrance to the library." + "" +
//                "The Hallway itself is padded with thick rugs, the walls covered in knicknacks and curios from all over the world.",
//                Accessible = true,
//                ModifiyExperiencePoints = 10
//            };

//            //
//            // row 2
//            //
//            gameMap.MapLocations[1, 1] = new Location()
//            {
//                Id = 3,
//                Name = "Parlor",
//                Description = "The rarely used formal Parlor. Inside has a stuffy dusty smell and the furniture is ornate- and uncomfortable." +
//                "You notice that the curio cabinet against the far wall has a drawer that is slightly ajar, and there is a hand mirror sitting " +
//                "on the small desk between the chairs.",
//                Accessible = true,
//                ModifiyExperiencePoints = 10
//            };
//            gameMap.MapLocations[1, 2] = new Location()
//            {
//                Id = 4,
//                Name = "Twilight",
//                Description = "The gray mist envelopes you.",
//                Accessible = false,
//                ModifiyExperiencePoints = 50,
//                ModifyLives = -1,
//                RequiredExperiencePoints = 40
//            };

//            //
//            // row 3
//            //
//            gameMap.MapLocations[2, 0] = new Location()
//            {
//                Id = 5,
//                Name = "Garden",
//                Description = "The air is cool and heavy inside the tropical garden. The outside world melts away between the thick glass walls." +
//                "A large water feature dominates the center of the room, of which inside stands a statue of a woman pouring water from a pitcher." +
//                "A necklace hangs around her neck, sparkling from the samp mist.",
//                Accessible = false,
//                ModifiyExperiencePoints = 20,
//                ModifyHealth = 50,
//                Message = "Something about that necklace looks familiar..."
//            };
//            gameMap.MapLocations[2, 1] = new Location()
//            {
//                Id = 6,
//                Name = "Hallway Middle",
//                Description = "Thick rugs are still under feet in the middle of the Hallway but you can now hear the ticking of a clock. " +
//                "Further inspections " +
//                "recorded information of the galactic history.",
//                Accessible = true,
//                ModifiyExperiencePoints = 10
//            };

//            return gameMap;
//        }
//    }
//}