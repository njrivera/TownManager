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
    public partial class Notifications : Form
    {
        public Notifications()
        {
            InitializeComponent();
            foreach (var notification in Globals.notifications)
                messageBox.Items.Add(notification.getMessage() + "\n");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
