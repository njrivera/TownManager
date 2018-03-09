using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownManager
{
    public class MonthFunctions
    {
        private static Random rand = new Random();

        public static void EndTurn()
        {
//Globals.notifications.Clear();
            for (int i = Globals.inProgress.Count - 1, j = Globals.builders; i >= 0 && j > 0; i--, j--)
            {
                Globals.inProgress[i].Build(1);
                if (Globals.inProgress[i].getMonths() == 0)
                {
                    Globals.notifications.Add(new Messages(Globals.inProgress[i].getType() + " Complete", "Construction"));
                    Globals.buildings.Add(Globals.inProgress[i]);
                    SwitchBuild(Globals.inProgress[i].getType());
                    Globals.inProgress.Remove(Globals.inProgress[i]);
                }
                if (i == 0)
                    i = Globals.inProgress.Count;
            }

            Globals.month = Globals.month % 12 + 1;
            if (Globals.month == 1)
                Globals.year++;
            switch (Globals.month)
            {
                case 1:
                    Globals.monthString = "January";
                    break;
                case 2:
                    Globals.monthString = "February";
                    break;
                case 3:
                    {
                        Globals.monthString = "March";
                        Globals.season = "Spring";
                    }
                    break;
                case 4:
                    Globals.monthString = "April";
                    break;
                case 5:
                    Globals.monthString = "May";
                    break;
                case 6:
                    {
                        Globals.monthString = "June";
                        Globals.season = "Summer";
                    }
                    break;
                case 7:
                    Globals.monthString = "July";
                    break;
                case 8:
                    Globals.monthString = "August";
                    break;
                case 9:
                    {
                        Globals.monthString = "September";
                        Globals.season = "Autumn";
                    }
                    break;
                case 10:
                    Globals.monthString = "October";
                    break;
                case 11:
                    Globals.monthString = "Novermber";
                    break;
                case 12:
                    {
                        Globals.monthString = "December";
                        Globals.season = "Winter";
                    }
                    break;
            }

            List<Dood> birthList = new List<Dood>();
            List<Dood> deathList = new List<Dood>();

            foreach (var dood in Globals.doods)
            {
//Food
                if (dood.Value.Age < 5)
                    Globals.food -= 1;
                else if (dood.Value.Age < 15)
                    Globals.food -= 2;
                else Globals.food -= 3;

//Collect Food
                if (dood.Value.Gender == 1 && dood.Value.Age >= 15
                    && dood.Value.getChildren().Count == 0 && dood.Value.getPregnant() == 0)
                    Globals.food += 5;

//Age
                if (dood.Value.Month == Globals.month)
                {
                    dood.Value.Age++;
                    if (dood.Value.Age == 15)
                        Globals.notifications.Add(new Messages(dood.Value.FirstName + " "
                            + dood.Value.LastName + " is now an adult.", "Of Age"));
                }

//Have Kids
                if (dood.Value.getPregnant() > 0)
                    dood.Value.setPregnant();
                if (dood.Value.Gender == 1 && dood.Value.getPregnant() == 0 && rand.Next(15) == 1
                    && dood.Value.MaritalStatus && dood.Value.Age < 50
                    && dood.Value.getChildren().Count < 3)
                    dood.Value.setPregnant();
                if (dood.Value.getPregnant() == 9)
                {
                    dood.Value.setPregnant();
                    Dood baby = new Dood(Globals.id);
                    baby.Mother = dood.Value.Id;
                    baby.Father = dood.Value.Spouse;
                    if (!Globals.doods.ContainsKey(dood.Value.Spouse))
                    {
                        dood.Value.MaritalStatus = false;
                        dood.Value.Spouse = -1;
                    }
                    baby.Gender = rand.Next(2);
                    if (baby.Gender == 0)
                        baby.FirstName = Globals.maleNames[rand.Next(Globals.maleNames.Count)];
                    else
                        baby.FirstName = Globals.femaleNames[rand.Next(Globals.femaleNames.Count)];
                    baby.LastName = dood.Value.LastName;
                    dood.Value.gainChild(Globals.id);
                    baby.Month = Globals.month;
                    birthList.Add(baby);
                    Globals.id++;
                    if (Globals.doods.ContainsKey(baby.Father))
                        Globals.notifications.Add(new Messages(Globals.doods[baby.Father].FirstName + " and "
                            + dood.Value.FirstName + " " + baby.LastName + " gave birth to " + baby.FirstName + "!"
                             , "Birth"));
                    else
                        Globals.notifications.Add(new Messages(Globals.cemetary[baby.Father].FirstName + " and "
                            + dood.Value.FirstName + " " + baby.LastName + " gave birth to " + baby.FirstName + "!"
                             , "Birth"));
                }
            }

//Taxes and Wages
            Globals.gold -= Globals.hunters + Globals.lumberjacks + Globals.masons + Globals.miners;
            Globals.gold -= Globals.builders * 2 + Globals.farmers * 2;
            Globals.gold -= Globals.footmen * 2 + Globals.sergeants * 3 + Globals.captains * 4;
            if (Globals.general)
                Globals.gold -= 8;
            Globals.gold += (int)(Globals.population * (float)Globals.taxRate / 100.0);

//Train
            foreach (var dood in Globals.doods)
            {
                if (dood.Value.Gender == 1 || dood.Value.Age < 15 || !dood.Value.WorkStatus)
                    continue;
                if (dood.Value.Job == "Recruit")
                {
                    dood.Value.setTrainTime(-1);
                    if (dood.Value.getTrainTime() == 0)
                    {
                        Globals.recruits--;
                        Globals.footmen++;
                        dood.Value.Job = "Footman";
                        dood.Value.setTrainTime(36);
                        continue;
                    }
                }
                if (dood.Value.Job == "Footman")
                {
                    dood.Value.setTrainTime(-1);
                    if (Globals.month == 10 && dood.Value.getTrainTime() == 0)
                    {
                        if (rand.Next(2) == 1 && Globals.sergeants < Globals.army / 5)
                        {
                            Globals.footmen--;
                            Globals.sergeants++;
                            dood.Value.Job = "Sergeant";
                            dood.Value.setTrainTime(60);
                            Globals.notifications.Add(new Messages(dood.Value.FirstName + " "
                                + dood.Value.LastName + " was promoted to Sergeant.", "Promotion"));
                            continue;
                        }
                    }
                }
                if (dood.Value.Job == "Sergeant")
                {
                    dood.Value.setTrainTime(-1);
                    if (Globals.month == 10 && dood.Value.getTrainTime() == 0)
                    {
                        if (rand.Next(3) == 1 && Globals.captains < Globals.army / 33)
                        {
                            Globals.sergeants--;
                            Globals.captains++;
                            dood.Value.Job = "Captain";
                            dood.Value.setTrainTime(96);
                            Globals.notifications.Add(new Messages(dood.Value.FirstName + " "
                                + dood.Value.LastName + " was promoted to Captain.", "Promotion"));
                            continue;
                        }
                    }
                }
                if (dood.Value.Job == "Captain")
                {
                    dood.Value.setTrainTime(-1);
                    if (Globals.month == 10 && dood.Value.getTrainTime() == 0)
                    {
                        if (rand.Next(5) == 1 && !Globals.general)
                        {
                            Globals.captains--;
                            Globals.general = true;
                            dood.Value.Job = "General";
                            Globals.generalId = dood.Key;
                            Globals.notifications.Add(new Messages(dood.Value.FirstName + " "
                                + dood.Value.LastName + " was promoted to General!", "Promotion"));
                        }
                    }
                }
            }

//Work
            for (int i = 0, j = Globals.huntCamps * 3; i < Globals.hunters; i++, j--)
                if (j > 0)
                    Globals.food += rand.Next(5) + 14;
                else
                    Globals.food += rand.Next(5) + 7;
            for (int i = 0, j = Globals.lumberCamps * 3; i < Globals.lumberjacks; i++, j--)
                if (j > 0)
                    Globals.wood += 10;
                else
                    Globals.wood += 5;
            for (int i = Globals.quarries * 10, j = Globals.masons; i > 0 && j > 0; i--, j--)
                Globals.stone += 3;
            for (int i = Globals.mineshafts * 10, j = Globals.miners, chance; i > 0 && j > 0; i--, j--)
            {
                chance = rand.Next(25);
                switch (chance)
                {
                    case 0:
                    case 1:
                        Globals.gold += rand.Next(21) + 15;
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        Globals.iron += rand.Next(3) + 3;
                        break;
                    default: break;
                }
            }
            if (Globals.drought == 0)
                Globals.drought = AuxFunctions.Drought();
            if (Globals.drought == 0)
                for (int i = Globals.farms * 3, j = Globals.farmers; i > 0 && j > 0; i--, j--)
                    if (Globals.season == "Winter")
                        Globals.food += 10;
                    else
                        Globals.food += 40;
            else
            {
                Globals.drought--;
                if (Globals.drought == 0)
                    Globals.notifications.Add(new Messages("The drought has ended", "Catastrophe"));
            }

//Crime Rate
            int crimeInv = 0;
            if (Globals.population > 0)
            {
                if (Globals.population < 100)
                {
                    crimeInv += (int)((50.0 - Globals.taxRate) * 1.25);
                    if (100 * Globals.houses / Globals.population >= 20)
                        crimeInv += 50;
                    else
                        crimeInv += (int)((100 * Globals.houses / Globals.population) * 2.5);
                }
                else
                {
                    crimeInv += (50 - Globals.taxRate) / 2;
                    if (100 * Globals.houses / Globals.population >= 20)
                        crimeInv += 20;
                    else
                        crimeInv += (100 * Globals.houses / Globals.population);
                    if (400 * (Globals.footmen + Globals.sergeants + Globals.captains) / Globals.population >= 40)
                        crimeInv += 40;
                    else
                        crimeInv += 400 * (Globals.footmen + Globals.sergeants + Globals.captains) / Globals.population;
                    if (Globals.crimeBonus * 1000 / Globals.population >= 20)
                        crimeInv += 20;
                    else
                        crimeInv += Globals.crimeBonus * 1000 / Globals.population;
                }
                Globals.crimeRate = 100 - crimeInv;
            }

//Natural Death
            if (Globals.food > 0)
                foreach (var dead in Globals.doods)
                {
                    if (dead.Value.Age >= 50 && rand.Next(40) == 6)
                        deathList.Add(dead.Value);
                    else if (dead.Value.WorkStatus && rand.Next(1400) == 666)
                        deathList.Add(dead.Value);
                    else if (rand.Next(2000) == 666)
                        deathList.Add(dead.Value);
                }
            else
            {
                int chance;
                foreach (var dead in Globals.doods)
                {
                    if (Globals.population > 5)
                        chance = rand.Next(20);
                    else chance = rand.Next(2);
                    if (chance == 1)
                    {
                        deathList.Add(dead.Value);
                        dead.Value.Reason = "died of natural causes.";
                        Globals.notifications.Add(new Messages(dead.Value.FirstName + " " + dead.Value.LastName
                                                    + " died of natural causes.", "Death"));
                    }
                }
            }

//Give Birth
            foreach (var baby in birthList)
            {
                Globals.population++;
                Globals.doods.Add(baby.Id, baby);
            }

//Crime
            crimeInv = 100 - Globals.crimeRate;
            foreach (var dood in Globals.doods)
            {
                if (dood.Value.Gender == 1 && dood.Value.Age >= 15 && dood.Value.Criminal == 0)
                {
                    if (rand.Next(crimeInv * crimeInv + 100) == 0)
                    {
                        int chance = rand.Next(4);
                        if (chance >= 1)
                            dood.Value.Criminal = 1;
                        else
                            dood.Value.Criminal = 2;
                    }
                }
                if (dood.Value.Gender == 1 && dood.Value.Age >= 15 && dood.Value.Criminal == 0)
                {
                    if (rand.Next(crimeInv * crimeInv * 4 + 100) == 0)
                    {
                        int chance = rand.Next(4);
                        if (chance >= 1)
                            dood.Value.Criminal = 1;
                        else
                            dood.Value.Criminal = 2;
                    }
                }
            }
            int foodStolen = 0, goldStolen = 0;
            foreach (var dood in Globals.doods)
            {
                if (dood.Value.Criminal == 1)
                    if (rand.Next(5) == 1)
                    {
                        if (rand.Next(Globals.population / (Globals.footmen + Globals.sergeants + Globals.captains + 1)) == 0)
                        {
                            dood.Value.Criminal = 3;
                            continue;
                        }
                        foodStolen += rand.Next(30) + 10;
                        goldStolen += rand.Next(30) + 10;
                    }
                if (dood.Value.Criminal == 2)
                    if (rand.Next(8) == 1)
                        foreach (var victim in Globals.doods)
                            if (dood.Value.Id != victim.Value.Id && victim.Value.Job != "Prisoner" && rand.Next(15) == 0)
                            {
                                //if (deathList.Contains(victim.Value))
                                //    continue;
                                Globals.notifications.Add(new Messages(victim.Value.FirstName + " " + victim.Value.LastName
                                                            + " was murdered!", "Death"));
                                victim.Value.Reason = "was murdured.";
                                deathList.Add(victim.Value);
                                if (rand.Next(Globals.population / ((Globals.footmen + Globals.sergeants + Globals.captains) + 1)) == 0)
                                {
                                    dood.Value.Criminal = 4;
                                    Globals.notifications.Add(new Messages(dood.Value.FirstName + " " + dood.Value.LastName
                                        + " was arrested for murder!", "Arrest"));
                                }
                                break;
                            }
            }
            if (foodStolen > 0)
                Globals.notifications.Add(new Messages(foodStolen + " food was stolen from our granary!", "Catastrophe"));
            if (goldStolen > 0)
                Globals.notifications.Add(new Messages(goldStolen + " gold was stolen from our treasury!", "Catastrophe"));
            Globals.food -= foodStolen;
            Globals.gold -= goldStolen;

//Fire
            for (int i = Globals.buildings.Count - 1; i >= 0; i--)
            {
                if (Globals.buildings[i].getCapacity() == 0)
                    continue;
                if ((Globals.season == "Summer" && rand.Next(500) == 66) || (Globals.season != "Summer" && rand.Next(800) == 666))
                {
                    int j = Globals.buildings[i].getCapacity();
                    Globals.notifications.Add(new Messages("A " + Globals.buildings[i].getType() + " was destroyed by a fire!", "Catastrophe"));
                    if (Globals.buildings[i].getType() == "House")
                    {
                        for (int k; j >= 0; j--)
                        {
                            if (rand.Next(7) == 6)
                            {
                                k = rand.Next(Globals.doods.Count);
                                if (deathList.Contains(Globals.doods.ElementAt(k).Value))
                                    continue;
                                Globals.notifications.Add(new Messages(Globals.doods.ElementAt(k).Value.FirstName + " " 
                                        + Globals.doods.ElementAt(k).Value.LastName
                                        + " was killed in the fire.", "Catastrophe"));
                                Globals.doods.ElementAt(k).Value.Reason = "was killed in a fire.";
                                deathList.Add(Globals.doods.ElementAt(k).Value);
                            }
                        }
                    }
                    else
                        foreach (var dood in Globals.doods)
                        {
                            if (j <= 0)
                                break;
                            if (dood.Value.Job == Globals.buildings[i].getJob())
                            {
                                if (rand.Next(7) == 6)
                                {
                                    if (deathList.Contains(dood.Value))
                                        continue;
                                    Globals.notifications.Add(new Messages(dood.Value.FirstName + " " + dood.Value.LastName
                                            + " was killed in the fire.", "Catastrophe"));
                                    dood.Value.Reason = "was killed in a fire.";
                                    deathList.Add(dood.Value);
                                }
                                j--;
                            }
                        }
                    switch(Globals.buildings[i].getType())
                    {
                        case "House": Globals.houses--;
                            break;
                        case "Hunting Camp": Globals.huntCamps--;
                            break;
                        case "Lumberjack Camp": Globals.lumberCamps--;
                            break;
                        case "Quarry": Globals.quarries--;
                            break;
                        case "Mineshaft": Globals.mineshafts--;
                            break;
                        case "Farm": Globals.farms--;
                            break;
                    }
                    Globals.buildings.RemoveAt(i);
                }
            }
            
//Raid
            if (Globals.population >= 50 && Globals.defense < 50 && rand.Next(80) == 66)
            {
                int goldLost = 0, foodLost = 0;
                goldLost = (rand.Next(200) + 50) - Globals.defense;
                foodLost = (rand.Next(100) + 50) - Globals.defense;
                Globals.gold -= goldLost;
                Globals.food -= foodLost;
                Globals.notifications.Add(new Messages("The town has been raided!.\n" + foodLost + " food was lost.\n"
                                                       + goldLost + " gold was lost.", "Catastrophe"));
                foreach(var dood in Globals.doods)
                    if (rand.Next(30) == 6)
                    {
                        if (deathList.Contains(dood.Value))
                            continue;
                        Globals.notifications.Add(new Messages(dood.Value.FirstName + " " + dood.Value.LastName
                                        + " was killed during the raid.", "Catastrophe"));
                        dood.Value.Reason = "was killed during a raid.";
                        deathList.Add(dood.Value);
                    }
            }

//Die
            foreach (var deadDood in deathList)
            {
                deadDood.Deceased = true;
                if (deadDood.Age < 15 && Globals.doods.ContainsKey(deadDood.Mother))
                    Globals.doods[deadDood.Mother].loseChild(deadDood.Id);
                if (deadDood.MaritalStatus)
                    if ((deadDood.Gender == 0 && Globals.doods[deadDood.Spouse].getPregnant() == 0)
                        || deadDood.Gender == 1 && Globals.doods.ContainsKey(deadDood.Spouse))
                    {
                        Globals.doods[deadDood.Spouse].MaritalStatus = false;
                        Globals.doods[deadDood.Spouse].Spouse = -1;
                    }
                if (deadDood.Gender == 0 && deadDood.Age >= 15 && !deadDood.WorkStatus && deadDood.Job != "Prisoner")
                    Globals.unemployed--;
                if (deadDood.WorkStatus)
                    switch (deadDood.Job)
                    {
                        case "Hunter":
                            Globals.hunters--;
                            break;
                        case "Lumberjack":
                            Globals.lumberjacks--;
                            break;
                        case "Mason":
                            Globals.masons--;
                            break;
                        case "Miner":
                            Globals.miners--;
                            break;
                        case "Farmer":
                            Globals.farmers--;
                            break;
                        case "Recruit":
                            {
                                Globals.recruits--;
                                Globals.army--;
                            }
                            break;
                        case "Footman":
                            {
                                Globals.footmen--;
                                Globals.army--;
                            }
                            break;
                        case "Sergeant":
                            {
                                Globals.sergeants--;
                                Globals.army--;
                            }
                            break;
                        case "Captain":
                            {
                                Globals.captains--;
                                Globals.army--;
                            }
                            break;
                        case "General":
                            {
                                Globals.generalId = -1;
                                Globals.general = false;
                            }
                            break;
                    }
                Globals.cemetary.Add(deadDood.Id, deadDood);
                Globals.doods.Remove(deadDood.Id);
                Globals.population--;
            }

//Marry
            List<Dood> singleMen = new List<Dood>();
            List<Dood> singleWomen = new List<Dood>();
            foreach (var dood in Globals.doods)
                if (dood.Value.Age >= 15 && !dood.Value.MaritalStatus)
                    if (dood.Value.Gender == 0)
                        singleMen.Add(dood.Value);
                    else
                        singleWomen.Add(dood.Value);
            foreach (var dood in singleMen)
            {
                if (singleWomen.Count == 0)
                    break;
                if (rand.Next(25) == 1)
                {
                    int i = rand.Next(singleWomen.Count);
                    if (singleWomen[i].Mother != -1)
                    {
                        if (singleWomen[i].Mother == dood.Mother)
                        {
                            i = singleWomen.Count - 1;
                            while (i >= 0)
                            {
                                if (singleWomen[i].Mother != dood.Mother)
                                    break;
                                i--;
                            }
                        }
                        if (i < 0)
                            continue;
                    }
                    dood.MaritalStatus = true;
                    dood.Spouse = singleWomen[i].Id;
                    singleWomen.Remove(Globals.doods[dood.Spouse]);
                    Globals.notifications.Add(new Messages(dood.FirstName + " " + dood.LastName
                        + " and " + Globals.doods[dood.Spouse].FirstName + " "
                        + Globals.doods[dood.Spouse].LastName + " were united in holy matrimony!", "Marriage"));
                    Globals.doods[dood.Spouse].LastName = dood.LastName;
                    Globals.doods[dood.Spouse].MaritalStatus = true;
                    Globals.doods[dood.Spouse].Spouse = dood.Id;
                }
            }
        }

        private static void SwitchBuild(string type)
        {
            switch(type)
            {
                case "House":
                    {
                        Globals.houseInProg--;
                        Globals.houses++;
                    }
                    break;
                case "Hunting Camp":
                    {
                        Globals.huntInProg--;
                        Globals.huntCamps++;
                    }
                    break;
                case "Lumberjack Camp":
                    {
                        Globals.lumberInProg--;
                        Globals.lumberCamps++;
                    }
                    break;
                case "Quarry":
                    {
                        Globals.quarryInProg--;
                        Globals.quarries++;
                    }
                    break;
                case "Mineshaft":
                    {
                        Globals.mineInProg--;
                        Globals.mineshafts++;
                    }
                    break;
                case "Farm":
                    {
                        Globals.farmInProg--;
                        Globals.farms++;
                    }
                    break;
                case "Palisade": Globals.palisade = 1;
                    break;
                case "Wooden Towers": Globals.woodenTowers = 1;
                    break;
                case "Stone Wall": Globals.stoneWall = 1;
                    break;
                case "Stone Towers": Globals.stoneTowers = 1;
                    break;
                case "Keep": Globals.keep = 1;
                    break;
                case "Market": Globals.market = 1;
                    break;
                case "Barracks": Globals.barracks = 1;
                    break;
                case "Prison": Globals.prison = 1;
                    break;
            }
        }
    }
}
