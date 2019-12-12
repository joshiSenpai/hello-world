using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONG
{
    class Player
    {
            public Rectangle r;
            public bool mov_up = false;
            public bool mov_down = false;
            Keys upKey;
            Keys downKey;
            Size enclosing;
            int speed = 3;

            public Player(Rectangle r, Size enclosing, Keys upKey, Keys downKey)
            {
                this.r = r;
                this.enclosing = enclosing;
                this.upKey = upKey;
                this.downKey = downKey;
            }
    }
}
