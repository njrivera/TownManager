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
    public partial class RankInfo : Form
    {
        public RankInfo()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rankSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDoods();
        }

        private void sortSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDoods();
        }

        private void showDoods()
        {
            rankBox.Items.Clear();
            IEnumerable<Dood> doods = from dood in Globals.doods
                                      where dood.Value.Job == rankSelector.Text
                                      orderby dood.Value.Id ascending
                                      select dood.Value;

            switch (sortSelector.Text)
            {
                case "First Name":
                    doods = from dood in doods orderby dood.FirstName select dood;
                    break;
                case "Last Name":
                    doods = from dood in doods orderby dood.LastName select dood;
                    break;
                case "Age":
                    doods = from dood in doods orderby dood.Age select dood;
                    break;
                default: break;
            }

            foreach (var dood in doods)
            {
                rankBox.Items.Add(" " + dood.FirstName + " " + dood.LastName);
                rankBox.Items.Add("  Age: " + dood.Age + "\n");
                rankBox.Items.Add("\n");
            }
        }
    }
}
