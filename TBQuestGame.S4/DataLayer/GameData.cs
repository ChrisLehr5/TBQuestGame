﻿using System;
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
                    new GameItemQuantity(GameItemById(1004), 1),
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
                    new GameItemQuantity(GameItemById(4002), 1),
                },
            };


            gameMap.MapLocations[1, 0] = new Location()
            {
                Id = 1,
                Name = "Entrance",
                Description = "The Family Manor is a stately Victorian, boasting numerous rooms and turrets.  " +
                "The wrought iron gate swings in the breeze, and the door is slightly ajar. " +
                "Home from school, you wonder where your aunt is.",
                Accessible = true,
                Message = "You expected to be greeted at the gate as usual by your Aunt, whom lives in the Manor." +
                " It's very unusual that nobody is in sight- leaving you the options of standing here wondering " +
                "or going inside to see what is going on... "
            };

            gameMap.MapLocations[1, 1] = new Location()
            {
                Id = 2,
                Name = "Front Hallway",
                Description = "The Hallway connected to the entrance. " +
                "To your left is the door to the parlor, to the right the vaulted entrance to the library." + "" +
                "The Hallway itself is padded with thick rugs, the walls covered in knicknacks and curios from all over the world.",
                Accessible = true
            };

            gameMap.MapLocations[0, 2] = new Location()
            {
                Id = 3,
                Name = "Parlor",
                Description = "The rarely used formal Parlor. The furniture is ornate and looks very uncomfortable." +
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
                Description = "The giant room is stuffed to the brim with books and exotic curios. Your family has always liked" +
                "to travel, and centuries of collecting has seen this wing expanded twice. There is a small glass door leading to the garden here.",
                Accessible = true,
                Message = "That Parrot is a noisy gossip but it has never liked you. There may be something around to trick it- " +
                "maybe if it thinks you are someone else it'll give you a clue...",
                GameItems = new ObservableCollection<GameItemQuantity>()
                {
                    new GameItemQuantity(GameItemById(4001), 1),
                    new GameItemQuantity(GameItemById(3002), 2)

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
                RequiredTreasureId = 2003,
                RequiredExperiencePoints = 400,
                Npcs = new ObservableCollection<Npc>()
                {
                    NpcById(2001)
                },
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
                Message = "Nothing of note in this part of the passage, except a large painting of your great-grandfather.",
                GameItems = new ObservableCollection<GameItemQuantity>()
                {
                    new GameItemQuantity(GameItemById(2002), 1)

                }
            };

            gameMap.MapLocations[1, 3] = new Location()
            {
                Id = 7,
                Name = "Back Hallway",
                Description = "The Hallway ends here, with a door to the left and right. They are both locked. ",
                Accessible = true,
                Message = "You know there is a servants entrance to the upstairs, but which way?",
                Npcs = new ObservableCollection<Npc>()
                {
                    NpcById(2002)
                },
                GameItems = new ObservableCollection<GameItemQuantity>()
                {
                    new GameItemQuantity(GameItemById(3003), 1)

                }
            };


            gameMap.MapLocations[2, 3] = new Location()
            {
                Id = 8,
                Name = "Study",
                Description = "The door to the left. Upon opening it you find a small room, someone's study area. It is cluttered.",
                Accessible = false,
                RequiredTreasureId = 4001,
                RequiredExperiencePoints = 400,
                Message = "You feel as if someone...or something is watching you.",
                GameItems = new ObservableCollection<GameItemQuantity>()
                {
                    new GameItemQuantity(GameItemById(2001), 1)

                }
            };

            return gameMap;
        }
        public static List<GameItem> StandardGameItems()
        {
            return new List<GameItem>()
            {
                new Weapon(1002, "Pen Knife", 75, 1, 4, "School issued. Easily concealed within your blazer pocket.",10,"", "This has the logo of your school engraved on the blade."),
                new Weapon(1001, "Top Hat", 25, 10, 15, "Phasers are common and versatile phased array pulsed energy projectile weapons.",10,"", "Razored sharp edges, this is no ordinary hat"),
                new Weapon(1003, "Bat", 125, 1, 5, "A baseball bat carved from solid oak.",10,"","You can feel how well balanced this bat is turning it in your hands."),
                new Weapon(1004, "Whistle", 50, 1,4, "Your favorite whistle with a piercing sound.",5,"","A present from your Aunt, your teachers at school complained of the noise. It is a worn brassy color."),
                new Treasure(2001, "Gold Coin", 10, "24 karat gold coin",1, "You don't know","Old. Odd that it appears so well preserved...", Treasure.UseActionType.OPENLOCATION),
                new Key(2002, "Diamond Lockpick", 50, "A lockpick made of diamond.", 1,"You fall into a trance, oblivious to your body slumping to the ground. You follow the lights as your soul fades...", "Sparkly, you gaze into its depths, mesmorized, calling you to use it, but for what?",  Key.UseActionType.KILLPLAYER),
                new Treasure(2003, "Silver Hand Mirror", 50, "An ornate silver backed hand mirror. Someone vain is missing this item.",5,"You have opened the Garden.","Pretty", Treasure.UseActionType.OPENLOCATION),
                new Potion(3001, "Cinnamon Candy", 5, 40, 1, "Your favorite type of candy.",5,"Yum!","Judging from the strong smell, this is sure to perk you up!"),
                new Potion(3002, "Butterscotch Candy", 5, 40, 1, "Your aunts favorite candy.",5,"Bleh- this tastes terrible!","Small and hard. Probably several years old, if your aunt missed eating it, but still smells okay."),
                new Potion(3003, "Strange Candy", 5, -10, 1, "Never seen this type of candy before.",5,"The world tilts as you eat the candy. You feel pretty sick to your stomach- the taste is off.","Has a weird musty smell and is a weird green color. Eating this may be a bad idea..."),
                new Key(4001, "Parlor Key", 5, "Brassy and well worn, this is the key to the formal parlor.", 5, "You have opened the Parlor.","Pretty", Key.UseActionType.OPENLOCATION),
                new Key(4003, "Study Key", 5, "Large silver key. You haven't seen it before.", 5, "You have opened the Study.","Pretty", Key.UseActionType.OPENLOCATION),
                new Key(4002, "Bent Key", 5, "This must have fallen from someones pocket...", 5,"A strange tingle passes up your arm, as your vision fades, you realize the key was poisoned...", "Seems dangerously sharp.", Key.UseActionType.KILLPLAYER)
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
                },

                new Ghost()
                {
                    Id = 2002,
                    Name = "Butler Smith",
                    Trait = Character.TraitType.Charisma,
                    Description = "You recognize the etheral form of the family butler Smith flickering in the room. A Ghost!?!",
                    Messages = new List<string>()
                    {
                        "You shouldn't be here!",
                        "I am sorry, the lady is out. May I take a message?",
                        "I feel...hungry gazing upon you..."
                    },
                   SkillLevel = 10,
                   CurrentWeapon = GameItemById(1001) as Weapon
                },
            };
        }
    }
}

