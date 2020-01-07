using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Battleship
{
    class Sound
    {
        System.Media.SoundPlayer theme = new System.Media.SoundPlayer(@"E:\Music BattleShip\Pirate Music");
        System.Media.SoundPlayer cannon = new System.Media.SoundPlayer(@"E:\Music BattleShip\Cannon");
        System.Media.SoundPlayer gameOver = new System.Media.SoundPlayer(@"E:\Music BattleShip\Losing Trumpet");
        System.Media.SoundPlayer victory = new System.Media.SoundPlayer(@"E:\Music BattleShip\Victory");
        System.Media.SoundPlayer miss = new System.Media.SoundPlayer(@"E:\Music BattleShip\Water Splash");
        System.Media.SoundPlayer quit = new System.Media.SoundPlayer(@"E:\Music BattleShip\Shutdown");

        public void Theme()
        {
            theme.Play();
        }

        public void Cannon()
        {
            cannon.Play();
        }

        public void Lose()
        {
            gameOver.Play();
        }

        public void Win()
        {
            victory.Play();
        }

        public void Miss()
        {
            miss.Play();
        }

        public void Quit()
        {
            quit.Play();
        }

    }
}
