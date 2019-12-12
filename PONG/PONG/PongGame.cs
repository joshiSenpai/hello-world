using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONG
{
    class PongGame
    {
        private Player p1;
        private Player p2;

        public int player1Score = 0;
        public int player2Score = 0;
        public int stopGame = 0;

        public PongGame(Size clientSize)
        {
            int wall_offset = 100;
            Size playerSize = new Size(20, 100);
            Size ballSize = new Size(20, 20);
        }
    }
}
