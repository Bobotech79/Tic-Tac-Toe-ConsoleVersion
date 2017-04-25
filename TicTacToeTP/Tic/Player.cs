using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic
{
    //perhaps flesh out this class later, if there's time.
    class Player
    {
        //properties
        public string playerName { get; set; }
        public int playerNumber { get; set; }

        //player constructor
        public Player(string name, int number)
        {
            this.playerName = name;
            this.playerNumber = number;
        }

    }
}
