﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    sealed class Human : Player
    {
        //AutoImplementedProperties
        public bool RandomSelection { get; set; }
        public List<string> PowerUpsDuring;
        public string InitialPowerups;
        public List<Ships> boats { get; set; }

        //Constructor
        public Human()
        {
            Name = "";
            Wins = 0;
            Losses = 0;
            Turn = true;
            ShipsLeft = 3;
            RandomSelection = true;
        }
        public Human(string playerName)
        {
            Name = playerName;
            Wins = 0;
            Losses = 0;
            Turn = true;
            ShipsLeft = 0;
            RandomSelection = false;
        }
        public override void ShipSelect()
        {
            if (RandomSelection == true)
            {
                Board boardObj = new Board();
                Random rGen = new Random();
                int rNum = rGen.Next(9);




            }
        }
        public override void Firing()
        {

        }
    }
}
