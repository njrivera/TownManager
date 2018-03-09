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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            UpdateResources();
            if(Globals.market == 2)
                militiaButton.Enabled = true;

        }

        private void notifyButton_Click(object sender, EventArgs e)
        {
            Notifications noteForm = new Notifications();
            noteForm.ShowDialog();
        }

        private void employButton_Click(object sender, EventArgs e)
        {
            Employment employForm = new Employment();
            employForm.ShowDialog();
            UpdateResources();
        }

        private void turnButton_Click(object sender, EventArgs e)
        {
            MonthFunctions.EndTurn();
            UpdateResources();
            if (Globals.barracks == 1)
                militiaButton.Enabled = true;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Globals.Reset();
            Close();
        }

        private void UpdateResources()
        {
            yearLabel.Text = Globals.year.ToString();
            monthLabel.Text = Globals.monthString;
            seasonLabel.Text = Globals.season;
            popLabel.Text = Globals.population.ToString();
            unempLabel.Text = Globals.unemployed.ToString();
            taxLabel.Text = Globals.taxRate.ToString() + "%";
            crimeLabel.Text = Globals.crimeRate.ToString();
            goldLabel.Text = Globals.gold.ToString();
            foodLabel.Text = Globals.food > 0 ? Globals.food.ToString() : "0";
            woodLabel.Text = Globals.wood.ToString();
            stoneLabel.Text = Globals.stone.ToString();
            ironLabel.Text = Globals.iron.ToString();
            if (Globals.population == 0)
            {
                GameMessage gameOver = new GameMessage("Game Over");
                Globals.Reset();
                gameOver.ShowDialog();
                Close();
            }
        }

        private void militiaButton_Click(object sender, EventArgs e)
        {
            Militia militiaForm = new Militia();
            militiaForm.ShowDialog();
            UpdateResources();
        }

        private void taxButton_Click(object sender, EventArgs e)
        {
            Tax taxForm = new Tax();
            taxForm.ShowDialog();
            taxLabel.Text = Globals.taxRate.ToString() + "%";
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            DoodInfo infoForm = new DoodInfo();
            infoForm.ShowDialog();
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            Buildings buildMenu = new Buildings();
            buildMenu.ShowDialog();
            UpdateResources();
        }
    }

}
