using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    sealed class Ships
    {
        private int shotsLeft;
        private int health;
        private string shipname;
        public bool Nuke { get; set; }

        public string ShipName
        { get { return shipname; }set { shipname = value; } }
        public int Health
        { get { return health; } set { health = value; } }
        //Ships frigate = new Ships();

        

        public Ships()
        {   
            shipname = "";
            shotsLeft = 0;
            health = 0;
            Nuke = false;
        }
        
        public Ships(string input, int num, bool check)
        {
            shipname = input;
            shotsLeft = num;
            health = num;
            Nuke = check;
        }

        public void Frigate()
        {
            shipname = "Frigate";
            shotsLeft = 2;
            health = 2;
            Nuke = false;
        }

        public void Submarine()
        {
            shipname = "Submarine";
            shotsLeft = 2;
            health = 2;
            Nuke = false;
        }
        public void Destroyer()
        {
            shipname = "Destroyer";
            shotsLeft = 3;
            health = 3;
            Nuke = false;
        }
        public void Battleship()
        {
            shipname = "Battleship";
            shotsLeft = 3;
            health = 3;
            Nuke = false;
        }
        public void AirCarrier()
        {
            shipname = "Aircraft Carrier";
            shotsLeft = 2;
            health = 2;
            Nuke = false;
        }
        public void Medical()
        {
            shipname = "Medical";
            shotsLeft = 2;
            health = 2;
            Nuke = false;
        }

        public void Damage()
        {
            health--;
        }

        public void Heal()
        {
            health++;
        }

        public void ShotFired()
        {
            shotsLeft--;
        }
    }
}
