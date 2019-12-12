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

        public void update_pos(Ball b)
        {
            if (mov_up && mov_down)
            {
                return;
            }
            else if (mov_up) {
                if ( r.Top - speed >= 0)
                {
                    r.Y -= speed;
                    if (this.r.IntersectsWith(b.r))
                    {
                        r.Y += speed; // Undo
                    }
                }
                else
                {
                    r.Y = 0;
                }
            }
            else if (mov_down)
            {
                if (r.Bottom + speed <= enclosing.Height)
                {
                    r.Y += speed;
                    if (this.r.IntersectsWith(b.r))
                    {
                        r.Y -= speed; // Undo
                    }
                }
                else
                {
                    r.Y = enclosing.Height - r.Height;
                }
            }
        }

        public void update_key(Keys key, bool down)
        {
            if (key == upKey)
            {
                mov_up = down;
            }
            else if (key == downKey)
            {
                mov_down = down;
            }
        }
    }
}
