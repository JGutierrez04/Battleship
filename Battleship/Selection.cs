using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class Selection : Form
    {
        Board board = new Board();
        Ships ships = new Ships();
        public Selection()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBoard7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmarine_Click(object sender, EventArgs e)
        {
            ships.Submarine();
            lblStats.Text = ships.ShipName;
            btnSubmarine.Enabled = false;
        }
    }
}
