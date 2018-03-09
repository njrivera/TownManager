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
    public partial class InProgress : Form
    {
        public InProgress()
        {
            InitializeComponent();
            foreach (var building in Globals.inProgress)
                listBox1.Items.Add(building.getType() + " " + building.getMonths());
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
