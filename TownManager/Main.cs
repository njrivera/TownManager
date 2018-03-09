using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TownManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            try
            {
                StreamReader nameFile;

                nameFile = File.OpenText("M firstNames.txt");
                while (!nameFile.EndOfStream)
                    Globals.maleNames.Add(nameFile.ReadLine());

                nameFile = File.OpenText("F firstNames.txt");
                while (!nameFile.EndOfStream)
                    Globals.femaleNames.Add(nameFile.ReadLine());

                nameFile = File.OpenText("lastNames.txt");
                while (!nameFile.EndOfStream)
                    Globals.lastNames.Add(nameFile.ReadLine());

                nameFile.Close();
            }
            catch
            {
                MessageBox.Show("Files Not Found!\n" + "Current Path: " + Directory.GetCurrentDirectory());
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            newGamePanel.Show();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GameMessage load = new GameMessage("Loading");
            load.Show();
            newGamePanel.Hide();
            Hide();
            Globals.population = (int)popNum.Value;
            Globals.gold = (int)goldNum.Value;
            Globals.food = (int)foodNum.Value;
            Globals.wood = (int)woodNum.Value;
            Globals.stone = (int)stoneNum.Value;
            Globals.iron = (int)ironNum.Value;
            if (marketBox.Checked)
                Globals.market = 1;
            if (barracksBox.Checked)
                Globals.barracks = 1;
            if (prisonBox.Checked)
                Globals.prison = 1;
            Globals.doods = createDoods();
            Globals.unemployed = Globals.population / 2;
            int i;
            for (i = 0; i < Globals.population / 5; i++)
                Globals.buildings.Add(new Building("House", 0));
            if (Globals.population % 5 != 0)
                Globals.buildings.Add(new Building("House", 0));
            Globals.houses = i;
            if (Globals.population == 100)
                Globals.crimeRate = 10;
            else Globals.crimeRate = 25;
            load.Close();
            Menu menu = new Menu();
            menu.ShowDialog();
            Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            newGamePanel.Hide();
        }

        private Dictionary<int,Dood> createDoods()
        {

            Dictionary<int, Dood> doods = new Dictionary<int, Dood>();
            int i;
            Random rand = new Random();

            for(i = 0; i < Globals.population / 2; i++)
            {
                Dood dood = new Dood(Globals.id);
                dood.FirstName = Globals.maleNames[rand.Next(Globals.maleNames.Count)];
                dood.LastName = Globals.lastNames[rand.Next(Globals.lastNames.Count)];
                dood.Age = rand.Next(16) + 15;
                dood.Gender = 0;
                dood.Month = rand.Next(12) + 1;
                doods.Add(dood.Id, dood);
                Globals.id++;
            }
            for(; i < Globals.population; i++)
            {
                Dood dood = new Dood(Globals.id);
                dood.FirstName = Globals.femaleNames[rand.Next(Globals.femaleNames.Count)];
                dood.LastName = Globals.lastNames[rand.Next(Globals.lastNames.Count)];
                dood.Age = rand.Next(16) + 15;
                dood.Gender = 1;
                dood.Month = rand.Next(12) + 1;
                doods.Add(dood.Id, dood);
                Globals.id++;
            }
            return doods;
        }
    }
}
