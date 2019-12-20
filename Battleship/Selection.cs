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
            Board sea = new Board(1, 2);
            ButtonControl();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBoard7_Click(object sender, EventArgs e)
        {
            Board lake = new Board(1);
            ButtonControl();

            
        }

        private void btnSubmarine_Click(object sender, EventArgs e)
        {
            ships.Submarine();
            lblStats.Text += ships.ShipName + "\n";
            btnSubmarine.Enabled = false;
        }

        private void btnFrigate_Click(object sender, EventArgs e)
        {
            ships.Frigate();
            lblStats.Text += ships.ShipName + "\n";
            btnFrigate.Enabled = false;
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            ships.Medical();
            lblStats.Text += ships.ShipName + "\n";
            btnMedical.Enabled = false;
        }

        private void btnBattleShip_Click(object sender, EventArgs e)
        {
            ships.Battleship();
            lblStats.Text += ships.ShipName + "\n";
            btnBattleShip.Enabled = false;
        }

        private void btnDestroyer_Click(object sender, EventArgs e)
        {
            ships.Destroyer();
            lblStats.Text += ships.ShipName + "\n";
            btnDestroyer.Enabled = false;
        }

        private void btnAirCraft_Click(object sender, EventArgs e)
        {
            ships.AirCarrier();
            lblStats.Text += ships.ShipName + "\n";
            btnAirCraft.Enabled = false;
        }

        private void btnBoard20_Click(object sender, EventArgs e)
        {
            Board ocean = new Board(1, 2, 3);
            ButtonControl();
            
        }
        public void DisableButton()
        {
            btnBoard7.Enabled = false;
            btnBoard10.Enabled = false;
            btnBoard20.Enabled = false;
        }

        public void EnableButton()
        {
            btnBattleShip.Enabled = true;
            btnAirCraft.Enabled = true;
            btnMedical.Enabled = true;
            btnFrigate.Enabled = true;
            btnDestroyer.Enabled = true;
            btnSubmarine.Enabled = true;
        }
        public void ButtonControl()
        {
            EnableButton();
            DisableButton();
        }
    }
}
