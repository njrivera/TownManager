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
    public partial class Militia : Form
    {
        public Militia()
        {
            InitializeComponent();
            captainsLabel.Text = Globals.captains.ToString();
            sergeantsLabel.Text = Globals.sergeants.ToString();
            footmenLabel.Text = Globals.footmen.ToString();
            recruitsLabel.Text = Globals.recruits.ToString();
            troopsLabel.Text = Globals.army.ToString();
            goldLabel.Text = Globals.gold.ToString();
            woodLabel.Text = Globals.wood.ToString();
            ironLabel.Text = Globals.iron.ToString();
            unempLabel.Text = Globals.unemployed.ToString();
            if (Globals.general)
                generalLabel.Text = Globals.doods[Globals.generalId].FirstName + " "
                                  + Globals.doods[Globals.generalId].LastName;
            else
                generalLabel.Text = "(Sine Duce)";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetButton.Show();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            RankInfo infoForm = new RankInfo();
            infoForm.ShowDialog();
        }

        private void recruitButton_Click(object sender, EventArgs e)
        {
            goldLabel.Text = (int.Parse(goldLabel.Text) - recruitNum.Value * 5).ToString();
            woodLabel.Text = (int.Parse(woodLabel.Text) - recruitNum.Value * 10).ToString();
            ironLabel.Text = (int.Parse(ironLabel.Text) - recruitNum.Value * 10).ToString();
            unempLabel.Text = (int.Parse(unempLabel.Text) - recruitNum.Value).ToString();
            troopsLabel.Text = (int.Parse(troopsLabel.Text) + recruitNum.Value).ToString();
            recruitsLabel.Text = (int.Parse(recruitsLabel.Text) + recruitNum.Value).ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(goldLabel.Text) < 0 || int.Parse(woodLabel.Text) < 0
                || int.Parse(ironLabel.Text) < 0 || int.Parse(unempLabel.Text) < 0)
            {
                MessageBox.Show("Not Enough Resources");
                ResetValues();
            }
            else
            {
                int i = int.Parse(recruitsLabel.Text);
                Globals.army = int.Parse(troopsLabel.Text);
                Globals.recruits = int.Parse(recruitsLabel.Text);
                Globals.gold = int.Parse(goldLabel.Text);
                Globals.wood = int.Parse(woodLabel.Text);
                Globals.iron = int.Parse(ironLabel.Text);
                Globals.unemployed = int.Parse(unempLabel.Text);
                foreach (var dood in Globals.doods)
                {
                    if (i <= 0)
                        break;
                    if (!dood.Value.WorkStatus && dood.Value.Age >= 15 && dood.Value.Gender == 0)
                    {
                        dood.Value.WorkStatus = true;
                        dood.Value.Job = "Recruit";
                        dood.Value.setTrainTime(3);
                        i--;
                    }
                }

            }
            recruitNum.Value = 0;
            resetButton.Hide();
        }
        private void ResetValues()
        {
            troopsLabel.Text = Globals.army.ToString();
            recruitsLabel.Text = Globals.recruits.ToString();
            goldLabel.Text = Globals.gold.ToString();
            woodLabel.Text = Globals.wood.ToString();
            ironLabel.Text = Globals.iron.ToString();
            unempLabel.Text = Globals.unemployed.ToString();
            recruitNum.Value = 0;
            resetButton.Hide();
        }
    }
}
