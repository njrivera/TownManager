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
    public partial class WorkerInfo : Form
    {
        public WorkerInfo()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void jobSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDoods();
        }

        private void sortSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDoods();
        }

        private void ShowDoods()
        {
            jobBox.Items.Clear();
            IEnumerable<Dood> doods = from dood in Globals.doods
                                      where dood.Value.Job == jobSelector.Text
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
                jobBox.Items.Add(" " + dood.FirstName + " " + dood.LastName);
                jobBox.Items.Add("  Age: " + dood.Age + "\n");
                jobBox.Items.Add("\n");
            }
        }
    }
}
