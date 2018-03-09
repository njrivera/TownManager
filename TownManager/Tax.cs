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
    public partial class Tax : Form
    {
        public Tax()
        {
            InitializeComponent();
            taxNum.Value = Globals.taxRate;
        }

        private void taxNum_ValueChanged(object sender, EventArgs e)
        {
            int crimeInv = 0;
            if (Globals.population < 100)
            {
                crimeInv += (int)((50.0 - (int)taxNum.Value) * 1.25);
                if (100 * Globals.houses / Globals.population >= 20)
                    crimeInv += 50;
                else
                    crimeInv += (int)((100 * Globals.houses / Globals.population) * 2.5);
            }
            else
            {
                crimeInv += (50 - (int)taxNum.Value) / 2;
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
            crimeLabel.Text = (100 - crimeInv).ToString();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Globals.taxRate = (int)taxNum.Value;
            Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            taxNum.Value = Globals.taxRate;
            crimeLabel.Text = Globals.crimeRate.ToString();
        }
    }
}
