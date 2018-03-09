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
    public partial class Employment : Form
    {
        public Employment()
        {
            InitializeComponent();
            clearJobs();
        }

        private void UpdateResources()
        {
            Globals.hunters = int.Parse(huntersLabel.Text);
            Globals.lumberjacks = int.Parse(lumberjacksLabel.Text);
            Globals.masons = int.Parse(masonsLabel.Text);
            Globals.miners = int.Parse(minersLabel.Text);
            Globals.builders = int.Parse(buildersLabel.Text);
            Globals.farmers = int.Parse(farmersLabel.Text);
            Globals.unemployed = int.Parse(unempLabel.Text);
            Globals.wood = int.Parse(woodLabel.Text);
            Globals.iron = int.Parse(ironLabel.Text);
        }

        private void hireButton_Click(object sender, EventArgs e)
        {
            huntersLabel.Text = (hunterHire.Value + int.Parse(huntersLabel.Text)).ToString();
            lumberjacksLabel.Text = (lumberjackHire.Value + int.Parse(lumberjacksLabel.Text)).ToString();
            masonsLabel.Text = (masonHire.Value + int.Parse(masonsLabel.Text)).ToString();
            minersLabel.Text = (minerHire.Value + int.Parse(minersLabel.Text)).ToString();
            buildersLabel.Text = (builderHire.Value + int.Parse(buildersLabel.Text)).ToString();
            farmersLabel.Text = (farmerHire.Value + int.Parse(farmersLabel.Text)).ToString();
            unempLabel.Text = (int.Parse(unempLabel.Text) - (hunterHire.Value + lumberjackHire.Value 
                                + masonHire.Value + minerHire.Value + builderHire.Value 
                                + farmerHire.Value)).ToString();
            woodLabel.Text = (int.Parse(woodLabel.Text) - (hunterHire.Value * 6 + lumberjackHire.Value * 2
                                + masonHire.Value * 3 + minerHire.Value * 6 + builderHire.Value * 6
                                + farmerHire.Value * 8)).ToString();
            ironLabel.Text = (int.Parse(ironLabel.Text) - (hunterHire.Value * 4 + lumberjackHire.Value * 4
                                + masonHire.Value * 4 + minerHire.Value * 6 + builderHire.Value * 8
                                + farmerHire.Value * 5)).ToString();
            clearHire();
        }        

        private void fireButton_Click(object sender, EventArgs e)
        {
            huntersLabel.Text = (int.Parse(huntersLabel.Text) - hunterFire.Value).ToString();
            lumberjacksLabel.Text = (int.Parse(lumberjacksLabel.Text) - lumberjackFire.Value).ToString();
            masonsLabel.Text = (int.Parse(masonsLabel.Text) - masonFire.Value).ToString();
            minersLabel.Text = (int.Parse(minersLabel.Text) - minerFire.Value).ToString();
            buildersLabel.Text = (int.Parse(buildersLabel.Text) - builderFire.Value).ToString();
            farmersLabel.Text = (int.Parse(farmersLabel.Text) - farmerFire.Value).ToString();
            unempLabel.Text = (int.Parse(unempLabel.Text) + (hunterFire.Value + lumberjackFire.Value
                                + masonFire.Value + minerFire.Value + builderFire.Value
                                + farmerFire.Value)).ToString();
            clearFire();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void applyButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(woodLabel.Text) < 0 || int.Parse(ironLabel.Text) < 0 || int.Parse(unempLabel.Text) < 0)
                MessageBox.Show("Not Enough Resources");
            else if (int.Parse(huntersLabel.Text) < 0 || int.Parse(lumberjacksLabel.Text) < 0 ||
                int.Parse(masonsLabel.Text) < 0 || int.Parse(minersLabel.Text) < 0 ||
                int.Parse(buildersLabel.Text) < 0 || int.Parse(farmersLabel.Text) < 0)
                MessageBox.Show("Not Enough Workers to Fire");
            else
            {
                Fire();
                Hire();
                UpdateResources();
            }
            clearHire();
            clearFire();
            clearJobs();
            resetButton.Hide();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            WorkerInfo info = new WorkerInfo();
            info.ShowDialog();
        }

        private void clearHire()
        {
            hunterHire.Value = 0;
            lumberjackHire.Value = 0;
            masonHire.Value = 0;
            minerHire.Value = 0;
            builderHire.Value = 0;
            farmerHire.Value = 0;
        }

        private void clearFire()
        {
            hunterFire.Value = 0;
            lumberjackFire.Value = 0;
            masonFire.Value = 0;
            minerFire.Value = 0;
            builderFire.Value = 0;
            farmerFire.Value = 0;
        }
        private void clearJobs()
        {
            goldLabel.Text = Globals.gold.ToString();
            woodLabel.Text = Globals.wood.ToString();
            ironLabel.Text = Globals.iron.ToString();
            unempLabel.Text = Globals.unemployed.ToString();
            huntersLabel.Text = Globals.hunters.ToString();
            lumberjacksLabel.Text = Globals.lumberjacks.ToString();
            masonsLabel.Text = Globals.masons.ToString();
            minersLabel.Text = Globals.miners.ToString();
            buildersLabel.Text = Globals.builders.ToString();
            farmersLabel.Text = Globals.farmers.ToString();
        }

        private void jobBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (jobBox.Text)
            {
                case "Hunter":
                    {
                        goldCost.Text = "1";
                        woodCost.Text = "6";
                        ironCost.Text = "4";
                    }
                    break;
                case "Lumberjack":
                    {
                        goldCost.Text = "1";
                        woodCost.Text = "2";
                        ironCost.Text = "4";
                    }
                    break;
                case "Mason":
                    {
                        goldCost.Text = "1";
                        woodCost.Text = "3";
                        ironCost.Text = "4";
                    }
                    break;
                case "Miner":
                    {
                        goldCost.Text = "1";
                        woodCost.Text = "6";
                        ironCost.Text = "6";
                    }
                    break;
                case "Builder":
                    {
                        goldCost.Text = "2";
                        woodCost.Text = "6";
                        ironCost.Text = "8";
                    }
                    break;
                case "Farmer":
                    {
                        goldCost.Text = "2";
                        woodCost.Text = "8";
                        ironCost.Text = "5";
                    }
                    break;
            }
        }

        private void Hire()
        {
            int i, j;
            List<Dood> newWorkers = new List<Dood>();
            foreach (var dood in Globals.doods)
                if (dood.Value.Gender == 0 &&
                    dood.Value.Age >= 15 &&
                    !dood.Value.WorkStatus)
                    newWorkers.Add(dood.Value);

            for (i = Globals.hunters, j = 0; i < int.Parse(huntersLabel.Text); i++, j++)
            {
                Globals.doods[newWorkers[j].Id].WorkStatus = true;
                Globals.doods[newWorkers[j].Id].Job = "Hunter";
            }
            for (i = Globals.lumberjacks; i < int.Parse(lumberjacksLabel.Text); i++, j++)
            {
                Globals.doods[newWorkers[j].Id].WorkStatus = true;
                Globals.doods[newWorkers[j].Id].Job = "Lumberjack";
            }
            for (i = Globals.masons; i < int.Parse(masonsLabel.Text); i++, j++)
            {
                Globals.doods[newWorkers[j].Id].WorkStatus = true;
                Globals.doods[newWorkers[j].Id].Job = "Mason";
            }
            for (i = Globals.miners; i < int.Parse(minersLabel.Text); i++, j++)
            {
                Globals.doods[newWorkers[j].Id].WorkStatus = true;
                Globals.doods[newWorkers[j].Id].Job = "Miner";
            }
            for (i = Globals.builders; i < int.Parse(buildersLabel.Text); i++, j++)
            {
                Globals.doods[newWorkers[j].Id].WorkStatus = true;
                Globals.doods[newWorkers[j].Id].Job = "Builder";
            }
            for (i = Globals.farmers; i < int.Parse(farmersLabel.Text); i++, j++)
            {
                Globals.doods[newWorkers[j].Id].WorkStatus = true;
                Globals.doods[newWorkers[j].Id].Job = "Farmer";
            }
        }

        private void Fire()
        {
            int i;

            i = Globals.hunters - int.Parse(huntersLabel.Text);
            foreach (var dood in Globals.doods)
            {
                if (i <= 0)
                    break;
                if(dood.Value.Job == "Hunter")
                {
                    dood.Value.WorkStatus = false;
                    dood.Value.Job = null;
                    i--;
                }
            }
            i = Globals.lumberjacks - int.Parse(lumberjacksLabel.Text);
            foreach (var dood in Globals.doods)
            {
                if (i <= 0)
                    break;
                if (dood.Value.Job == "Lumberjack")
                {
                    dood.Value.WorkStatus = false;
                    dood.Value.Job = null;
                    i--;
                }
            }
            i = Globals.masons - int.Parse(masonsLabel.Text);
            foreach (var dood in Globals.doods)
            {
                if (i <= 0)
                    break;
                if (dood.Value.Job == "Mason")
                {
                    dood.Value.WorkStatus = false;
                    dood.Value.Job = null;
                    i--;
                }
            }
            i = Globals.miners - int.Parse(minersLabel.Text);
            foreach (var dood in Globals.doods)
            {
                if (i <= 0)
                    break;
                if (dood.Value.Job == "Miner")
                {
                    dood.Value.WorkStatus = false;
                    dood.Value.Job = null;
                    i--;
                }
            }
            i = Globals.builders - int.Parse(buildersLabel.Text);
            foreach (var dood in Globals.doods)
            {
                if (i <= 0)
                    break;
                if (dood.Value.Job == "Builder")
                {
                    dood.Value.WorkStatus = false;
                    dood.Value.Job = null;
                    i--;
                }
            }
            i = Globals.farmers - int.Parse(farmersLabel.Text);
            foreach (var dood in Globals.doods)
            {
                if (i <= 0)
                    break;
                if (dood.Value.Job == "Farmer")
                {
                    dood.Value.WorkStatus = false;
                    dood.Value.Job = null;
                    i--;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            clearHire();
            clearFire();
            clearJobs();
            resetButton.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetButton.Show();
        }
    }
}
