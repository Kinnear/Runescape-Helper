using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunescapeHelper
{
    public class HighscoreData
    {
        public enum SKILLS_LISTING
        {
            RANK = 0,
            LEVEL,
            XP
        };

        public enum SKILLS
        {
            TOTAL_LEVEL = 0,
            ATTACK,
            DEFENCE,
            STRENGTH,
            CONSTITUTION,
            RANGED,
            PRAYER,
            MAGIC,
            COOKING,
            WOODCUTTING,
            FLETCHING,
            FISHING,
            FIREMAKING,
            CRAFTING,
            SMITHING,
            MINING,
            HERBLORE,
            AGILITY,
            THIEVING,
            SLAYER,
            FARMING,
            RUNECRAFTING,
            HUNTER,
            CONSTRUCTION,
            SUMMONING,
            DUNGEONEEREING,
            DIVINATION
        };

        //double index array to store all of our skills details
        public int[,] skills =
            new int[Enum.GetNames(typeof(SKILLS)).Length,
                Enum.GetNames(typeof(SKILLS_LISTING)).Length];
    }
}
