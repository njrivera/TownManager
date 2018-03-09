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
    public partial class GameMessage : Form
    {
        public GameMessage(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }

        private void GameMessage_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
