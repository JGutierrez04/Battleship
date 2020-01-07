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
        public Selection()
        {
            InitializeComponent();
        }

        
        private int numAllowed = 0;
        private int numSelected = 0;
        private Ships[] shipChoices;

        private void btnBoard7_Click(object sender, EventArgs e)
        {
            shipChoices = new Ships[3];
            numAllowed = 3;
            SizeChoice();
        }

        private void btnBoard20_Click(object sender, EventArgs e)
        {
            shipChoices = new Ships[5];
            numAllowed = 5;
            SizeChoice();
        }

        private void btnBoard10_Click(object sender, EventArgs e)
        {
            shipChoices = new Ships[4];
            numAllowed = 4;
            SizeChoice();
        }

        private void SizeChoice()
        {
            btnBattleShip.Enabled = true; btnAirCraft.Enabled = true; btnMedical.Enabled = true; btnFrigate.Enabled = true; btnSubmarine.Enabled = true; btnDestroyer.Enabled = true;
            btnBoard10.Enabled = false; btnBoard7.Enabled = false; btnBoard20.Enabled = false;
        }

        private void btnAircraft_Click(object sender, EventArgs e)
        {
            Ships aircraft = new Ships("a", "b");
            BoatChoice(aircraft);
            btnAirCraft.Enabled = false;

        }

        private void btnBattleship_Click(object sender, EventArgs e)
        {
            Ships battle = new Ships("a", "b", "c", "d");
            BoatChoice(battle);
            btnBattleShip.Enabled = false;
        }

        private void btnFrigate_Click(object sender, EventArgs e)
        {
            Ships frig = new Ships("a");
            BoatChoice(frig);
            btnFrigate.Enabled = false;
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            Ships med = new Ships("a","b","c","d","e");
            BoatChoice(med);
            btnMedical.Enabled = false;
        }

        private void btnSubmarine_Click(object sender, EventArgs e)
        {
            Ships sub = new Ships();
            BoatChoice(sub);
            btnSubmarine.Enabled = false;
        }

        private void btnDestroyer_Click(object sender, EventArgs e)
        {
            Ships dest = new Ships("a","b","c");
            BoatChoice(dest);
            btnDestroyer.Enabled = false;
        }

        private void BoatChoice(Ships boat)
        {
            if (numSelected <= numAllowed)
            {
                shipChoices[numSelected] = boat;
                lblStats.Text += boat.ShipName + "\n";
                numSelected++;
            }
            if (numSelected == numAllowed)
            {
                MessageBox.Show("Max Ships Chosen");
                btnDestroyer.Enabled = false; btnSubmarine.Enabled = false; btnMedical.Enabled = false; btnFrigate.Enabled = false; btnBattleShip.Enabled = false; btnAirCraft.Enabled = false;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnDestroyer.Enabled = false; btnSubmarine.Enabled = false; btnMedical.Enabled = false; btnFrigate.Enabled = false; btnBattleShip.Enabled = false; btnAirCraft.Enabled = false;
            btnBoard10.Enabled = true; btnBoard7.Enabled = true; btnBoard20.Enabled = true;
            lblStats.Text = "";
            Array.Clear(shipChoices, 0, shipChoices.Length);
            numSelected = 0;
            numAllowed = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
