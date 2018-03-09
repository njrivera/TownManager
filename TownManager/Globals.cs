using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownManager
{
    public class Globals
    {
        public static int gold = 0, food = 0, wood = 0, stone = 0, iron = 0;
        public static int population = 0, houses = 0, buildInProg = 0, id = 0;
        public static int unemployed = 0, taxRate = 30, crimeRate = 0, crimeBonus = 0;
        public static int year = 0, month = 1, drought = 0, defense = 0;
        public static string season = "Winter", monthString = "January";
        public static int huntCamps = 0, lumberCamps = 0, quarries = 0, mineshafts = 0, farms = 0;
        public static int palisade = -1, woodenTowers = -1, stoneWall = -1, stoneTowers = -1, keep = -1;
        public static int market = -1, barracks = -1, prison = -1;
        public static int hunters = 0, lumberjacks = 0, masons = 0;
        public static int miners = 0, builders = 0, farmers = 0;
        public static List<Messages> notifications = new List<Messages>();
        public static Dictionary<int, Dood> doods = new Dictionary<int, Dood>();
        public static Dictionary<int, Dood> cemetary = new Dictionary<int, Dood>();
        public static int army = 0, recruits = 0, footmen = 0, sergeants = 0, captains = 0;
        public static bool general = false;
        public static int generalId = -1;
        public static List<string> maleNames = new List<string>();
        public static List<string> femaleNames = new List<string>();
        public static List<string> lastNames = new List<string>();
        public static List<Building> buildings = new List<Building>();
        public static List<Building> inProgress = new List<Building>();
        public static int houseInProg = 0, huntInProg = 0, lumberInProg = 0, quarryInProg = 0;
        public static int mineInProg = 0, farmInProg = 0;

        public static void Reset()
        {
            gold = 0; food = 0; wood = 0; stone = 0; iron = 0; population = 0; houses = 0; buildInProg = 0; id = 0;
            unemployed = 0; taxRate = 30; crimeRate = 0; crimeBonus = 0; year = 0; month = 1; drought = 0; defense = 0;
            season = "Winter"; monthString = "January"; huntCamps = 0; lumberCamps = 0; quarries = 0; mineshafts = 0; farms = 0;
            palisade = -1; woodenTowers = -1; stoneWall = -1; stoneTowers = -1; keep = -1; market = -1; barracks = -1; prison = -1;
            hunters = 0; lumberjacks = 0; masons = 0; miners = 0; builders = 0; farmers = 0;
            notifications.Clear();
            doods.Clear();
            cemetary.Clear();
            army = 0; recruits = 0; footmen = 0; sergeants = 0; captains = 0;
            general = false;
            generalId = -1;
            //maleNames.Clear();
            //femaleNames.Clear();
            //lastNames.Clear();
            buildings.Clear();
            inProgress.Clear();
            houseInProg = 0; huntInProg = 0; lumberInProg = 0; quarryInProg = 0;
            mineInProg = 0; farmInProg = 0;
        }
    }
}
