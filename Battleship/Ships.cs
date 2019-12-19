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

        public Ships()
        {
            shipname = "";
            shotsLeft = 0;
            health = 0;
            Nuke = false;
        }
        
        public Ships(string a)
        {
            shipname = "Frigate";
            shotsLeft = 1;
            health = 3;
            Nuke = false;
        }

        public Ships(string a, string b)
        {

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
