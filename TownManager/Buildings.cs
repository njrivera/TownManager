using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TownManager
{
    public partial class Buildings : Form
    {
        public Buildings()
        {
            InitializeComponent();
            update();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void update()
        {
            woodLabel.Text = Globals.wood.ToString();
            stoneLabel.Text = Globals.stone.ToString();
            ironLabel.Text = Globals.iron.ToString();

            housesLabel.Text = Globals.houses.ToString();
            huntCampLabel.Text = Globals.huntCamps.ToString();
            lumberCampLabel.Text = Globals.lumberCamps.ToString();
            quarryLabel.Text = Globals.quarries.ToString();
            mineLabel.Text = Globals.mineshafts.ToString();
            farmLabel.Text = Globals.farms.ToString();

            if (int.Parse(popVac.Text = Globals.population.ToString()) >
                int.Parse(houseVac.Text = (Globals.houses * 5).ToString()))
                popVac.ForeColor = Color.Red;
            else popVac.ForeColor = Color.Black;
            if (int.Parse(hunterVac.Text = Globals.hunters.ToString()) >
                int.Parse(huntCampVac.Text = (Globals.huntCamps * 3).ToString()))
                hunterVac.ForeColor = Color.Red;
            else hunterVac.ForeColor = Color.Black;
            if (int.Parse(lumberjackVac.Text = Globals.lumberjacks.ToString()) >
                int.Parse(lumberCampVac.Text = (Globals.lumberCamps * 3).ToString()))
                lumberjackVac.ForeColor = Color.Red;
            else lumberjackVac.ForeColor = Color.Black;
            if (int.Parse(masonVac.Text = Globals.masons.ToString()) >
                int.Parse(quarryVac.Text = (Globals.quarries * 10).ToString()))
                masonVac.ForeColor = Color.Red;
            else masonVac.ForeColor = Color.Black;
            if (int.Parse(minerVac.Text = Globals.miners.ToString()) >
                int.Parse(mineVac.Text = (Globals.mineshafts * 10).ToString()))
                minerVac.ForeColor = Color.Red;
            else minerVac.ForeColor = Color.Black;
            if (int.Parse(farmerVac.Text = Globals.farmers.ToString()) >
                int.Parse(farmVac.Text = (Globals.farms * 3).ToString()))
                farmerVac.ForeColor = Color.Red;
            else farmerVac.ForeColor = Color.Black;

            if (int.Parse(houseProg.Text = Globals.houseInProg.ToString()) > 0)
                housePlus.Text = "+";
            else
            {
                houseProg.Hide();
                housePlus.Text = "";
            }
            if (int.Parse(huntProg.Text = Globals.huntInProg.ToString()) > 0)
                huntPlus.Text = "+";
            else
            {
                huntProg.Hide();
                huntPlus.Text = "";
            }
            if (int.Parse(lumberProg.Text = Globals.lumberInProg.ToString()) > 0)
                lumberPlus.Text = "+";
            else
            {
                lumberProg.Hide();
                lumberPlus.Text = "";
            }
            if (int.Parse(quarryProg.Text = Globals.quarryInProg.ToString()) > 0)
                quarryPlus.Text = "+";
            else
            {
                quarryProg.Hide();
                quarryPlus.Text = "";
            }
            if (int.Parse(mineProg.Text = Globals.mineInProg.ToString()) > 0)
                minePlus.Text = "+";
            else
            {
                mineProg.Hide();
                minePlus.Text = "";
            }
            if (int.Parse(farmProg.Text = Globals.farmInProg.ToString()) > 0)
                farmPlus.Text = "+";
            else
            {
                farmProg.Hide();
                farmPlus.Text = "";
            }

            if (Globals.palisade == -1)
                palisadeLabel.Text = "-";
            else if (Globals.palisade == 0)
                palisadeLabel.Text = "In Progress";
            else palisadeLabel.Text = "Built";

            if (Globals.woodenTowers == -1)
                woodTowersLabel.Text = "-";
            else if (Globals.woodenTowers == 0)
                woodTowersLabel.Text = "In Progress";
            else woodTowersLabel.Text = "Built";

            if (Globals.stoneWall == -1)
                stoneWallLabel.Text = "-";
            else if (Globals.stoneWall == 0)
                stoneWallLabel.Text = "In Progress";
            else stoneWallLabel.Text = "Built";

            if (Globals.stoneTowers == -1)
                stoneTowersLabel.Text = "-";
            else if (Globals.stoneTowers == 0)
                stoneTowersLabel.Text = "In Progress";
            else stoneTowersLabel.Text = "Built";

            if (Globals.keep == -1)
                keepLabel.Text = "-";
            else if (Globals.keep == 0)
                keepLabel.Text = "In Progress";
            else keepLabel.Text = "Built";

            if (Globals.market == -1)
                marketLabel.Text = "-";
            else if (Globals.market == 0)
                marketLabel.Text = "In Progress";
            else marketLabel.Text = "Built";

            if (Globals.barracks == -1)
                barracksLabel.Text = "-";
            else if (Globals.barracks == 0)
                barracksLabel.Text = "In Progress";
            else barracksLabel.Text = "Built";

            if (Globals.prison == -1)
                prisonLabel.Text = "-";
            else if (Globals.prison == 0)
                prisonLabel.Text = "In Progress";
            else prisonLabel.Text = "Built";
        }

        private void buildBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (buildBox.Text)
            {
                case "House":
                    {
                        woodCost.Text = "50";
                        stoneCost.Text = "0";
                        ironCost.Text = "0";
                        bonusLabel.Text = "5 doods per house";
                        monthLabel.Text = "1";
                    }
                    break;
                case "Hunting Camp":
                    {
                        woodCost.Text = "150";
                        stoneCost.Text = "0";
                        ironCost.Text = "0";
                        bonusLabel.Text = "+100% food gathering\n3 hunters per camp";
                        monthLabel.Text = "2";
                    }
                    break;
                case "Lumberjack Camp":
                    {
                        woodCost.Text = "150";
                        stoneCost.Text = "0";
                        ironCost.Text = "0";
                        bonusLabel.Text = "+100% wood gathering\n3 lumberjacks per camp";
                        monthLabel.Text = "2";
                    }
                    break;
                case "Quarry":
                    {
                        woodCost.Text = "350";
                        stoneCost.Text = "0";
                        ironCost.Text = "0";
                        bonusLabel.Text = "Allows Masonry\n10 masons per quarry";
                        monthLabel.Text = "8";
                    }
                    break;
                case "Mineshaft":
                    {
                        woodCost.Text = "400";
                        stoneCost.Text = "0";
                        ironCost.Text = "0";
                        bonusLabel.Text = "Allows Mining\n10 miners per mineshaft";
                        monthLabel.Text = "8";
                    }
                    break;
                case "Farm":
                    {
                        woodCost.Text = "500";
                        stoneCost.Text = "30";
                        ironCost.Text = "10";
                        bonusLabel.Text = "Allows Farming\n3 farmers per farm";
                        monthLabel.Text = "10";
                    }
                    break;
                case "Palisade":
                    {
                        woodCost.Text = "5000";
                        stoneCost.Text = "0";
                        ironCost.Text = "0";
                        bonusLabel.Text = "+??? Defense";
                        monthLabel.Text = "12";
                    }
                    break;
                case "Wooden Towers":
                    {
                        woodCost.Text = "1500";
                        stoneCost.Text = "0";
                        ironCost.Text = "50";
                        bonusLabel.Text = "+??? Defense";
                        monthLabel.Text = "8";
                    }
                    break;
                case "Stone Wall":
                    {
                        woodCost.Text = "0";
                        stoneCost.Text = "10000";
                        ironCost.Text = "0";
                        bonusLabel.Text = "+??? Defense";
                        monthLabel.Text = "24";
                    }
                    break;
                case "Stone Towers":
                    {
                        woodCost.Text = "0";
                        stoneCost.Text = "3000";
                        ironCost.Text = "50";
                        bonusLabel.Text = "+??? Defense";
                        monthLabel.Text = "18";
                    }
                    break;
                case "Keep":
                    {
                        woodCost.Text = "2000";
                        stoneCost.Text = "8000";
                        ironCost.Text = "600";
                        bonusLabel.Text = "+??? Defense";
                        monthLabel.Text = "24";
                    }
                    break;
                case "Market":
                    {
                        woodCost.Text = "2000";
                        stoneCost.Text = "300";
                        ironCost.Text = "100";
                        bonusLabel.Text = "Allows Trading";
                        monthLabel.Text = "18";
                    }
                    break;
                case "Barracks":
                    {
                        woodCost.Text = "500";
                        stoneCost.Text = "1000";
                        ironCost.Text = "200";
                        bonusLabel.Text = "Allows Training of Militia";
                        monthLabel.Text = "18";
                    }
                    break;
                case "Prison":
                    {
                        woodCost.Text = "200";
                        stoneCost.Text = "2500";
                        ironCost.Text = "1000";
                        bonusLabel.Text = "Allows Incarceration of Criminals";
                        monthLabel.Text = "18";
                    }
                    break;
            }
        }

        private void SubResources()
        {
            woodLabel.Text = (int.Parse(woodLabel.Text) - int.Parse(woodCost.Text)).ToString();
            stoneLabel.Text = (int.Parse(stoneLabel.Text) - int.Parse(stoneCost.Text)).ToString();
            ironLabel.Text = (int.Parse(ironLabel.Text) - int.Parse(ironCost.Text)).ToString();
            resetButton.Show();
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            switch (buildBox.Text)
            {
                case "House":
                    {
                        housePlus.Text = "+";
                        houseProg.Show();
                        houseProg.Text = (int.Parse(houseProg.Text) + 1).ToString();
                        if (int.Parse(popVac.Text) <= (int.Parse(houseVac.Text) + int.Parse(houseProg.Text) * 5))
                            popVac.ForeColor = Color.Black;
                        SubResources();
                    }
                    break;
                case "Hunting Camp":
                    {
                        huntPlus.Text = "+";
                        huntProg.Show();
                        huntProg.Text = (int.Parse(huntProg.Text) + 1).ToString();
                        if (int.Parse(hunterVac.Text) <= (int.Parse(huntCampVac.Text) + int.Parse(huntProg.Text) * 3))
                            hunterVac.ForeColor = Color.Black;
                        SubResources();
                    }
                    break;
                case "Lumberjack Camp":
                    {
                        lumberPlus.Text = "+";
                        lumberProg.Show();
                        lumberProg.Text = (int.Parse(lumberProg.Text) + 1).ToString();
                        if (int.Parse(lumberjackVac.Text) <= (int.Parse(lumberCampVac.Text) + int.Parse(lumberProg.Text) * 3))
                            lumberjackVac.ForeColor = Color.Black;
                        SubResources();
                    }
                    break;
                case "Quarry":
                    {
                        quarryPlus.Text = "+";
                        quarryProg.Show();
                        quarryProg.Text = (int.Parse(quarryProg.Text) + 1).ToString();
                        if (int.Parse(masonVac.Text) <= (int.Parse(quarryVac.Text) + int.Parse(quarryProg.Text) * 10))
                            masonVac.ForeColor = Color.Black;
                        SubResources();
                    }
                    break;
                case "Mineshaft":
                    {
                        minePlus.Text = "+";
                        mineProg.Show();
                        mineProg.Text = (int.Parse(mineProg.Text) + 1).ToString();
                        if (int.Parse(minerVac.Text) <= (int.Parse(mineVac.Text) + int.Parse(mineProg.Text) * 10))
                            minerVac.ForeColor = Color.Black;
                        SubResources();
                    }
                    break;
                case "Farm":
                    {
                        farmPlus.Text = "+";
                        farmProg.Show();
                        farmProg.Text = (int.Parse(farmProg.Text) + 1).ToString();
                        if (int.Parse(farmerVac.Text) <= (int.Parse(farmVac.Text) + int.Parse(farmProg.Text) * 3))
                            farmerVac.ForeColor = Color.Black;
                        SubResources();
                    }
                    break;
                case "Palisade":
                    if (palisadeLabel.Text == "-")
                    {
                        palisadeLabel.Text = "In Progress";
                        SubResources();
                    }
                    break;
                case "Wooden Towers":
                    if (woodTowersLabel.Text == "-" && palisadeLabel.Text == "Built")
                    {
                        woodTowersLabel.Text = "In Progress";
                        SubResources();
                    }
                    break;
                case "Stone Wall":
                    if (stoneWallLabel.Text == "-" && woodTowersLabel.Text == "Built")
                    {
                        stoneWallLabel.Text = "In Progress";
                        SubResources();
                    }
                    break;
                case "Stone Towers":
                    if (stoneTowersLabel.Text == "-" && stoneWallLabel.Text == "Built")
                    {
                        stoneTowersLabel.Text = "In Progress";
                        SubResources();
                    }
                    break;
                case "Keep":
                    if (keepLabel.Text == "-" && stoneTowersLabel.Text == "Built")
                    {
                        keepLabel.Text = "In Progress";
                        SubResources();
                    }
                    break;
                case "Market":
                    if (marketLabel.Text == "-")
                    {
                        marketLabel.Text = "In Progress";
                        SubResources();
                    }
                    break;
                case "Barracks":
                    if (barracksLabel.Text == "-")
                    {
                        barracksLabel.Text = "In Progress";
                        SubResources();
                    }
                    break;
                case "Prison":
                    if (prisonLabel.Text == "-")
                    {
                        prisonLabel.Text = "In Progress";
                        SubResources();
                    }
                    break;
            }
        }

        private void AddResources()
        {
            woodLabel.Text = (int.Parse(woodLabel.Text) + int.Parse(woodGain.Text)).ToString();
            stoneLabel.Text = (int.Parse(stoneLabel.Text) + int.Parse(stoneGain.Text)).ToString();
            ironLabel.Text = (int.Parse(ironLabel.Text) + int.Parse(ironGain.Text)).ToString();
            resetButton.Show();
        }

        private void demolishButton_Click(object sender, EventArgs e)
        {
            switch (demolishBox.Text)
            {
                case "House":
                    if (int.Parse(housesLabel.Text) > 0)
                    {
                        housesLabel.Text = (int.Parse(housesLabel.Text) - 1).ToString();
                        houseVac.Text = (int.Parse(houseVac.Text) - 5).ToString();
                        if (int.Parse(houseVac.Text) < int.Parse(popVac.Text))
                            popVac.ForeColor = Color.Red;
                        AddResources();
                    }
                    break;
                case "Hunting Camp":
                    if (int.Parse(huntCampLabel.Text) > 0)
                    {
                        huntCampLabel.Text = (int.Parse(huntCampLabel.Text) - 1).ToString();
                        huntCampVac.Text = (int.Parse(huntCampVac.Text) - 3).ToString();
                        if (int.Parse(huntCampVac.Text) < int.Parse(hunterVac.Text))
                            hunterVac.ForeColor = Color.Red;
                        AddResources();
                    }
                    break;
                case "Lumberjack Camp":
                    if (int.Parse(lumberCampLabel.Text) > 0)
                    {
                        lumberCampLabel.Text = (int.Parse(lumberCampLabel.Text) - 1).ToString();
                        lumberCampVac.Text = (int.Parse(lumberCampVac.Text) - 3).ToString();
                        if (int.Parse(lumberCampVac.Text) < int.Parse(lumberjackVac.Text))
                            lumberjackVac.ForeColor = Color.Red;
                        AddResources();
                    }
                    break;
                case "Quarry":
                    if (int.Parse(quarryLabel.Text) > 0)
                    {
                        quarryLabel.Text = (int.Parse(quarryLabel.Text) - 1).ToString();
                        quarryVac.Text = (int.Parse(quarryVac.Text) - 3).ToString();
                        if (int.Parse(quarryVac.Text) < int.Parse(masonVac.Text))
                            masonVac.ForeColor = Color.Red;
                        AddResources();
                    }
                    break;
                case "Mineshaft":
                    if (int.Parse(mineLabel.Text) > 0)
                    {
                        mineLabel.Text = (int.Parse(mineLabel.Text) - 1).ToString();
                        mineVac.Text = (int.Parse(mineVac.Text) - 3).ToString();
                        if (int.Parse(mineVac.Text) < int.Parse(minerVac.Text))
                            minerVac.ForeColor = Color.Red;
                        AddResources();
                    }
                    break;
                case "Farm":
                    if (int.Parse(farmLabel.Text) > 0)
                    {
                        farmLabel.Text = (int.Parse(farmLabel.Text) - 1).ToString();
                        farmVac.Text = (int.Parse(farmVac.Text) - 3).ToString();
                        if (int.Parse(farmVac.Text) < int.Parse(farmerVac.Text))
                            farmerVac.ForeColor = Color.Red;
                        AddResources();
                    }
                    break;
            }
        }

        private void demolishBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (demolishBox.Text)
            {
                case "House":
                    {
                        woodGain.Text = "15";
                        stoneGain.Text = "0";
                        ironGain.Text = "0";
                    }
                    break;
                case "Hunting Camp":
                    {
                        woodGain.Text = "45";
                        stoneGain.Text = "0";
                        ironGain.Text = "0";
                    }
                    break;
                case "Lumberjack Camp":
                    {
                        woodGain.Text = "45";
                        stoneGain.Text = "0";
                        ironGain.Text = "0";
                    }
                    break;
                case "Quarry":
                    {
                        woodGain.Text = "105";
                        stoneGain.Text = "3";
                        ironGain.Text = "0";
                    }
                    break;
                case "Mineshaft":
                    {
                        woodGain.Text = "120";
                        stoneGain.Text = "0";
                        ironGain.Text = "0";
                    }
                    break;
                case "Farm":
                    {
                        woodGain.Text = "150";
                        stoneGain.Text = "9";
                        ironGain.Text = "3";
                    }
                    break;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            update();
            resetButton.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetButton.Show();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(woodLabel.Text) < 0 ||
                int.Parse(stoneLabel.Text) < 0 ||
                int.Parse(ironLabel.Text) < 0)
            {
                update();
                resetButton.Hide();
                return;
            }
            resetButton.Hide();
            Globals.wood = int.Parse(woodLabel.Text);
            Globals.stone = int.Parse(stoneLabel.Text);
            Globals.iron = int.Parse(ironLabel.Text);

            List<int> demolishList = new List<int>();
            int i;

            if (int.Parse(housesLabel.Text) < Globals.houses)
            {
                i = Globals.houses - int.Parse(housesLabel.Text);
                foreach (var building in Globals.buildings)
                {
                    if (i <= 0)
                        break;
                    if (building.getType() == "House")
                    {
                        demolishList.Add(Globals.buildings.IndexOf(building));
                        i--;
                    }
                }
                foreach (var index in demolishList)
                    Globals.buildings.RemoveAt(index);
                demolishList.Clear();
            }
            if (int.Parse(huntCampLabel.Text) < Globals.huntCamps)
            {
                i = Globals.huntCamps - int.Parse(huntCampLabel.Text);
                foreach (var building in Globals.buildings)
                {
                    if (i <= 0)
                        break;
                    if (building.getType() == "Hunting Camp")
                    {
                        demolishList.Add(Globals.buildings.IndexOf(building));
                        i--;
                    }
                }
                foreach (var index in demolishList)
                    Globals.buildings.RemoveAt(index);
                demolishList.Clear();
            }
            if (int.Parse(lumberCampLabel.Text) < Globals.lumberCamps)
            {
                i = Globals.lumberCamps - int.Parse(lumberCampLabel.Text);
                foreach (var building in Globals.buildings)
                {
                    if (i <= 0)
                        break;
                    if (building.getType() == "Lumberjack Camp")
                    {
                        demolishList.Add(Globals.buildings.IndexOf(building));
                        i--;
                    }
                }
                foreach (var index in demolishList)
                    Globals.buildings.RemoveAt(index);
                demolishList.Clear();
            }
            if (int.Parse(quarryLabel.Text) < Globals.quarries)
            {
                i = Globals.quarries - int.Parse(quarryLabel.Text);
                foreach (var building in Globals.buildings)
                {
                    if (i <= 0)
                        break;
                    if (building.getType() == "Quarry")
                    {
                        demolishList.Add(Globals.buildings.IndexOf(building));
                        i--;
                    }
                }
                foreach (var index in demolishList)
                    Globals.buildings.RemoveAt(index);
                demolishList.Clear();
            }
            if (int.Parse(mineLabel.Text) < Globals.mineshafts)
            {
                i = Globals.mineshafts - int.Parse(mineLabel.Text);
                foreach (var building in Globals.buildings)
                {
                    if (i <= 0)
                        break;
                    if (building.getType() == "Mineshaft")
                    {
                        demolishList.Add(Globals.buildings.IndexOf(building));
                        i--;
                    }
                }
                foreach (var index in demolishList)
                    Globals.buildings.RemoveAt(index);
                demolishList.Clear();
            }
            if (int.Parse(farmLabel.Text) < Globals.farms)
            {
                i = Globals.farms - int.Parse(farmLabel.Text);
                foreach (var building in Globals.buildings)
                {
                    if (i <= 0)
                        break;
                    if (building.getType() == "Farm")
                    {
                        demolishList.Add(Globals.buildings.IndexOf(building));
                        i--;
                    }
                }
                foreach (var index in demolishList)
                    Globals.buildings.RemoveAt(index);
                demolishList.Clear();
            }

            Globals.houses = int.Parse(housesLabel.Text);
            Globals.huntCamps = int.Parse(huntCampLabel.Text);
            Globals.lumberCamps = int.Parse(lumberCampLabel.Text);
            Globals.quarries = int.Parse(quarryLabel.Text);
            Globals.mineshafts = int.Parse(mineLabel.Text);
            Globals.farms = int.Parse(farmLabel.Text);

            if (int.Parse(houseProg.Text) > Globals.houseInProg)
                CreateBuildings("House", int.Parse(houseProg.Text) - Globals.houseInProg);
            if (int.Parse(huntProg.Text) > Globals.huntInProg)
                CreateBuildings("Hunting Camp", int.Parse(huntProg.Text) - Globals.huntInProg);
            if (int.Parse(lumberProg.Text) > Globals.lumberInProg)
                CreateBuildings("Lumberjack Camp", int.Parse(lumberProg.Text) - Globals.lumberInProg);
            if (int.Parse(quarryProg.Text) > Globals.quarryInProg)
                CreateBuildings("Quarry", int.Parse(quarryProg.Text) - Globals.quarryInProg);
            if (int.Parse(mineProg.Text) > Globals.mineInProg)
                CreateBuildings("Mineshaft", int.Parse(mineProg.Text) - Globals.mineInProg);
            if (int.Parse(farmProg.Text) > Globals.farmInProg)
                CreateBuildings("Farm", int.Parse(farmProg.Text) - Globals.farmInProg);

            if (Globals.palisade == -1 && palisadeLabel.Text == "In Progress")
                CreateBuildings("Palisade");
            if (Globals.woodenTowers == -1 && woodTowersLabel.Text == "In Progress")
                CreateBuildings("Wooden Towers");
            if (Globals.stoneWall == -1 && stoneWallLabel.Text == "In Progress")
                CreateBuildings("Stone Wall");
            if (Globals.stoneTowers == -1 && stoneTowersLabel.Text == "In Progress")
                CreateBuildings("Stone Towers");
            if (Globals.keep == -1 && keepLabel.Text == "In Progress")
                CreateBuildings("Keep");

            if (Globals.market == -1 && marketLabel.Text == "In Progress")
                CreateBuildings("Market");
            if (Globals.barracks == -1 && barracksLabel.Text == "In Progress")
                CreateBuildings("Barracks");
            if (Globals.prison == -1 && prisonLabel.Text == "In Progress")
                CreateBuildings("Prison");
        }

        private void CreateBuildings(string type, int n)
        {
            switch (type)
            {
                case "House":
                    for (int i = 0; i < n; i++)
                    {
                        Globals.inProgress.Add(new Building(type, 1, "", 5));
                        Globals.houseInProg++;
                    }
                    break;
                case "Hunting Camp":
                    for (int i = 0; i < n; i++)
                    {
                        Globals.inProgress.Add(new Building(type, 2, "Hunter", 3));
                        Globals.huntInProg++;
                    }
                    break;
                case "Lumberjack Camp":
                    for (int i = 0; i < n; i++)
                    {
                        Globals.inProgress.Add(new Building(type, 2, "Lumberjack", 3));
                        Globals.lumberInProg++;
                    }
                    break;
                case "Quarry":
                    for (int i = 0; i < n; i++)
                    {
                        Globals.inProgress.Add(new Building(type, 8, "Mason", 10));
                        Globals.quarryInProg++;
                    }
                    break;
                case "Mineshaft":
                    for (int i = 0; i < n; i++)
                    {
                        Globals.inProgress.Add(new Building(type, 8, "Miner", 10));
                        Globals.mineInProg++;
                    }
                    break;
                case "Farm":
                    for (int i = 0; i < n; i++)
                    {
                        Globals.inProgress.Add(new Building(type, 10, "Farmer", 3));
                        Globals.farmInProg++;
                    }
                    break;
            }
        }

        private void progressButton_Click(object sender, EventArgs e)
        {
            InProgress progressForm = new InProgress();
            progressForm.ShowDialog();
        }


        private void CreateBuildings(string type)
        {
            switch (type)
            {
                case "Palisade":
                    {
                        Globals.inProgress.Add(new Building(type, 12));
                        Globals.palisade = 0;
                    }
                    break;
                case "Wooden Towers":
                    {
                        Globals.inProgress.Add(new Building(type, 8));
                        Globals.woodenTowers = 0;
                    }
                    break;
                case "Stone Wall":
                    {
                        Globals.inProgress.Add(new Building(type, 24));
                        Globals.stoneWall = 0;
                    }
                    break;
                case "Stone Towers":
                    {
                        Globals.inProgress.Add(new Building(type, 18));
                        Globals.stoneTowers = 0;
                    }
                    break;
                case "Keep":
                    {
                        Globals.inProgress.Add(new Building(type, 24));
                        Globals.keep = 0;
                    }
                    break;
                case "Market":
                    {
                        Globals.inProgress.Add(new Building(type, 18));
                        Globals.market = 0;
                    }
                    break;
                case "Barracks":
                    {
                        Globals.inProgress.Add(new Building(type, 18));
                        Globals.barracks = 0;
                    }
                    break;
                case "Prison":
                    {
                        Globals.inProgress.Add(new Building(type, 18));
                        Globals.prison = 0;
                    }
                    break;
            }
        }
    }
}
