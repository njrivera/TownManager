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
    public partial class DoodInfo : Form
    {
        public DoodInfo()
        {
            InitializeComponent();
            ShowDoods();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDoods();
        }

        private void ShowDoods()
        {
            doodBox.Items.Clear();
            List<Dood> doods = new List<Dood>();
            foreach (var dood in Globals.doods)
                doods.Add(dood.Value);
            if (Globals.cemetary != null)
                foreach (var dood in Globals.cemetary)
                    doods.Add(dood.Value);

            for (int i = doods.Count - 1; i >= 0; i--)
            {
                if (doods[i].Gender == 1 && maleButton.Checked == true)
                {
                    doods.Remove(doods[i]);
                    continue;
                }
                if (doods[i].Gender == 0 && femaleButton.Checked == true)
                {
                    doods.Remove(doods[i]);
                    continue;
                }
                if (doods[i].Age < 15 && adultButton.Checked == true)
                {
                    doods.Remove(doods[i]);
                    continue;
                }
                if (doods[i].Age >= 15 && childButton.Checked == true)
                {
                    doods.Remove(doods[i]);
                    continue;
                }
                if (deceasedBox.Checked == true && doods[i].Deceased == false)
                {
                    doods.Remove(doods[i]);
                    continue;
                }
                if(deceasedBox.Checked == false && doods[i].Deceased == true)
                {
                    doods.Remove(doods[i]);
                    continue;
                }
                if (imprisonedBox.Checked == true && doods[i].Job != "Prisoner")
                {
                    doods.Remove(doods[i]);
                    continue;
                }
                if (doods[i].WorkStatus == false && employedButton.Checked == true)
                {
                    doods.Remove(doods[i]);
                    continue;
                }
                if (doods[i].WorkStatus == true && unemployedButton.Checked == true)
                {
                    doods.Remove(doods[i]);
                    continue;
                }
            }

            IEnumerable<Dood> doods2 = from dood in doods
                                       orderby dood.Id ascending
                                       select dood;

            switch (sortSelector.Text)
            {
                case "First Name":
                    doods2 = from dood in doods2 orderby dood.FirstName select dood;
                    break;
                case "Last Name":
                    doods2 = from dood in doods2 orderby dood.LastName select dood;
                    break;
                case "Age":
                    doods2 = from dood in doods2 orderby dood.Age select dood;
                    break;
                default: break;
            }

            foreach (var dood in doods2)
            {
                doodBox.Items.Add(" " + dood.FirstName + " " + dood.LastName);
                doodBox.Items.Add("  Age: " + dood.Age);
                if (dood.Job != null)
                    doodBox.Items.Add("  " + dood.Job);
                if (dood.MaritalStatus)
                {
                    if (Globals.doods.ContainsKey(dood.Spouse))
                        doodBox.Items.Add("  Married to: " + Globals.doods[dood.Spouse].FirstName);
                    else doodBox.Items.Add(" Was married to: " + Globals.cemetary[dood.Spouse].FirstName);
                }
                if (dood.getChildren().Count > 0)
                {
                    doodBox.Items.Add("  Children:\n");
                    foreach (var child in dood.getChildren())
                        if (Globals.doods.ContainsKey(child))
                            doodBox.Items.Add("    " + Globals.doods[child].FirstName + " Age: " + Globals.doods[child].Age);
                        else doodBox.Items.Add("    " + Globals.cemetary[child].FirstName + " Age: " + Globals.cemetary[child].Age);
                }
                doodBox.Items.Add("\n");
            }
        }
    }
}
