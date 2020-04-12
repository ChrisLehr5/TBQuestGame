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
                Name = "Violet",
                Age = 13,
                PlayStyle = Player.PlayThroughDifficulty.Casual,
                Trait = Character.TraitType.Charisma,
                Health = 100,
                Lives = 3,
                ExperiencePoints = 0,
                SkillLevel = 5,
                Inventory = new ObservableCollection<GameItemQuantity>()
                {
                    new GameItemQuantity(GameItemById(1002), 1),
                    new GameItemQuantity(GameItemById(1003), 1),
                    new GameItemQuantity(GameItemById(2001), 5),
                }
            };
        }

        public static GameItem GameItemById(int id)
        {
            return StandardGameItems().FirstOrDefault(i => i.Id == id);
        }

        public static GameMapCoordinates InitialGameMapLocation()
        {
            return new GameMapCoordinates() { Row = 0, Column = 0 };
        }

        private static Npc NpcById(int id)
        {
            return Npcs().FirstOrDefault(i => i.Id == id);
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
                ModifiyExperiencePoints = 0,
                Message = "",
                GameItems = new ObservableCollection<GameItemQuantity>()
                {
                    new GameItemQuantity(GameItemById(2001), 1),
                    new GameItemQuantity(GameItemById(4001), 1),
                }
            };


            gameMap.MapLocations[1, 0] = new Location()
            {
                Id = 1,
                Name = "Entrance",
                Description = "The Family Manor is a stately Victorian, boasting numerous rooms and turrets.  " +
                "The wrought iron gate swings in the breeze, and the door is slightly ajar. " +
                "Home from school, you wonder where your aunt is.",
                Message = "You expected to be greeted at the gate as usual by your Aunt, whom lives in the Manor." +
                " It's very unusual that nobody is in sight- leaving you the options of standing here wondering " +
                "or going inside to see what is going on... ",
                Accessible = true,
                //ModifiyExperiencePoints = 10,               

            };


            gameMap.MapLocations[1, 1] = new Location()
            {
                Id = 2,
                Name = "Front Hallway",
                Description = "The Hallway connected to the entrance. " +
                "To your left is the door to the parlor, to the right the vaulted entrance to the library." + "" +
                "The Hallway itself is padded with thick rugs, the walls covered in knicknacks and curios from all over the world.",
                Accessible = true,
                //ModifiyExperiencePoints = 0
            };

            gameMap.MapLocations[0, 2] = new Location()
            {
                Id = 3,
                Name = "Parlor",
                Description = "The rarely used formal Parlor. Inside has a stuffy dusty smell and the furniture is ornate- and uncomfortable." +
                "You notice that the curio cabinet against the far wall has a drawer that is slightly ajar, and there is a hand mirror sitting " +
                "on the small desk between the chairs.",
                Accessible = false,
                RequiredKeyId = 4001,
                RequiredExperiencePoints = 40,
                //the required key id is only firing when the required xp overrides
                Message = "The air in this room is musty, and the chairs look overstuffed and uncomfortable." +
                "You don't think your Aunt has ever used this room. She is much too informal!",
                GameItems = new ObservableCollection<GameItemQuantity>()
                {
                    new GameItemQuantity(GameItemById(2003), 2),
                    new GameItemQuantity(GameItemById(3001), 1)
                }
            };

            gameMap.MapLocations[2, 1] = new Location()
            {
                Id = 4,
                Name = "Library",
                Description = "The giant room is stuffed to the brim with books." +
                "Curiously your Aunt's Parrot is perched in the middle of the room, sitting on a globe your grandfather procured." +
                "Noticing you, it looks expectant.",
                Accessible = false,
                //ModifiyExperiencePoints = 10,
                Message = "That Parrot is a noisy gossip but it has never liked you. There may be something around to trick it- " +
                "maybe if it thinks you are someone else it'll give you a clue...",
                GameItems = new ObservableCollection<GameItemQuantity>()
                {
                    new GameItemQuantity(GameItemById(4001), 1)

                },
                Npcs = new ObservableCollection<Npc>()
                {
                    NpcById(2001)
                }
            };

            gameMap.MapLocations[3, 1] = new Location()
            {
                Id = 5,
                Name = "Garden",
                Description = "The air is cool and heavy inside the tropical garden. The outside world melts away between the thick glass walls." +
                "A large water feature dominates the center of the room, of which inside stands a statue of a woman pouring water from a pitcher." +
                "A necklace hangs around her neck, sparkling from the samp mist.",
                Accessible = false,
                RequiredKeyId = 4002,
                RequiredExperiencePoints = 400,
                //ModifiyExperiencePoints = 20,
                Message = "Something about that necklace looks familiar..."
            };
            gameMap.MapLocations[1, 2] = new Location()
            {
                Id = 6,
                Name = "Hallway Middle",
                Description = "Thick rugs are still under feet in the middle of the Hallway but you can now hear the ticking of a clock. " +
                "Further inspections reveal a large grandfather clock.",
                Accessible = true,
                //ModifiyExperiencePoints = 10
            };

            gameMap.MapLocations[1, 3] = new Location()
            {
                Id = 7,
                Name = "Back Hallway",
                Description = "The Hallway ends here, with a door to the left and right. ",
                Accessible = true,
                // ModifiyExperiencePoints = 10,
                Message = "You know there is a servants entrance to the upstairs, but which way?"
            };


            gameMap.MapLocations[2, 3] = new Location()
            {
                Id = 8,
                Name = "Study",
                Description = "The sturdy door is locked.",
                Accessible = false,
                //ModifiyExperiencePoints = 10,
                Message = "There is something odd about this door.",
                RequiredExperiencePoints = 400
            };

            return gameMap;
        }
        public static List<GameItem> StandardGameItems()
        {
            return new List<GameItem>()
            {
                new Weapon(1002, "Pen Knife", 75, 1, 4, "School issued. Easily concealed within your blazer pocket.", 10),
                //new Weapon(1002, "Phaser", 250, 1, 9, "Phasers are common and versatile phased array pulsed energy projectile weapons.", 10),
                new Weapon(1003, "Tommy Gun", 125, 1, 5, "Tommy guns are an old fashioned, hand carry machine gun popularized by the gangsters of the 1940s.", 10),
                new Weapon(1004, "Whistle", 50, 1,4, "Your favorite whistle. A present from your Aunt, your teachers at school complained it would deafen your fellow students.", 5),
                new Treasure(2001, "Gold Coin", 10, Treasure.TreasureType.Mirror, "24 karat gold coin", 1),
                new Treasure(2002, "Small Diamond", 50, Treasure.TreasureType.Necklace, "A small pea-sized diamond of various colors.", 1),
                new Treasure(2003, "Silver Hand Mirror", 50, Treasure.TreasureType.Mirror, "An ornate silver backed hand mirror. Someone vain is missing this item.", 1),
                new Potion(3001, "Cinnamon Candy", 5, 40, 1, "Your favorite type of candy- sure to perk you up!", 5),
                new Key(4001, "Parlor Key", 5, "Brassy and well worn, this is the key to the formal parlor.", 5, "You have opened the Parlor.", Key.UseActionType.OPENLOCATION),
                new Key(4002, "Bent Key", 5, "This must have fallen from someones pocket...", 5, "The key breaks completely, jabbing you in the palm. A strange tingle passes up your arm, as your vision fades...", Key.UseActionType.KILLPLAYER)
            };
        }

        public static List<Npc> Npcs()
        {
            return new List<Npc>()
            {
                new Ghost()
                {
                    Id = 2001,
                    Name = "Parrot",
                    Trait = Character.TraitType.Strength,
                    Description = "A striking red parrot. Its cold flat eyes follow you around the room, like it is waiting for something.",
                    Messages = new List<string>()
                    {
                        "Pretty Bird!",
                        "Give me the shiny!",
                        "SQUAWK"
                    },
                   SkillLevel = 50,
                   CurrentWeapon = GameItemById(1001) as Weapon
                },

                new Ghost()
                {
                    Id = 2002,
                    Name = "Private Smith",
                    Trait = Character.TraitType.Charisma,
                    Description = "A slight, edgy man who looks straight off the farm..",
                    Messages = new List<string>()
                    {
                        "Who are you?",
                        "Why are you here?",
                        "Have I told you about my family?"
                    },
                   SkillLevel = 1,
                   CurrentWeapon = GameItemById(1002) as Weapon
                },
            };
        }
    }
}

