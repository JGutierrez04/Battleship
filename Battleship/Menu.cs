﻿
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
    public partial class Menu : Form 
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Selection form = new Selection();
            form.Show();
            Menu form1 = new Menu();
            form1.Close();

            Human human = new Human();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Sound sound = new Sound();
            sound.Theme();
        }
    }
}
