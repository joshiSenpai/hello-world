using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Class1
{
    public Class1()
    {
        public Rectangle r;
        int dx;
        int dy;
        Size enclosing;
        Rectangle top_wall;
        Rectangle bot_wall;

        public Ball(Rectangle r, Size enclosing)
        {
            this.r = r;
            this.enclosing = enclosing;
            int wall_thickness = 100;
            top_wall = new Rectangle(0, -wall_thickness, enclosing.Width, wall_thickness);
            bot_wall = new Rectangle(0, enclosing.Height, enclosing.Width, wall_thickness);
            reset();
        }

        public void reset()
        {
            /* Put the ball in the center with random velocity */
            Random rnd = new Random();
            r.X = enclosing.Width / 2;
            r.Y = enclosing.Height / 2;
            dx = rnd.Next(0, 7) - 3;
            dy = rnd.Next(0, 7) - 3;
            dx = (dx == 0) ? 1 : dx;
            dy = (dy == 0) ? -1 : dy;
        }

        public int update_pos(Player p1, Player p2)
        {
            /* Update the position of the ball */
            r.X += dx;
            r.Y += dy;

            /* Determine if the ball has slipped throug any player */
            if (r.Left < 0)
            {
                return 2;
            }
            else if (r.Right > enclosing.Width)
            {
                return 1;
            }

            /* Check if the ball touches the top or bottom wall */
            if (r.IntersectsWith(top_wall) || r.IntersectsWith(bot_wall))
            {
                dy = -dy;
            }

            if (r.IntersectsWith(p1.r)) // Bouce with player1
            {
                bounceWith(p1);
            }
            else if (r.IntersectsWith(p2.r)) // Bouce with player2
            {
                bounceWith(p2);
            }
            return 0;

        }

        private void bounceWith(Player p)
        {
            dx = -dx;

            if (dx > 0 && r.Left + dx < p.r.Right)
            {
                // If bounce with top or bottom of player1
                dx = -Math.Abs(dx);
                dy = -dy;
            }
            else if (dx < 0 && r.Right + dx > p.r.Left)
            {
                // If bounce with top or bottom of player2
                dx = Math.Abs(dx);
                dy = -dy;
            }
            else
            {
                // Bounce with vertical edge of player
                if (p.mov_down && !p.mov_up)
                {
                    if (dy > 0)
                    {
                        // Player down, ball down
                        dy += 1;
                    }
                    else
                    {
                        // Player down, ball up
                        dy += 1;
                        if (dy == 0)
                        {
                            dy = -1;
                        }
                        else
                        {
                            dx = Math.Sign(dx) * (Math.Abs(dx) + 1);
                        }
                    }
                }
                else if (p.mov_up && !p.mov_down)
                {
                    if (dy > 0)
                    {
                        // Player up, ball down
                        dy += -1;
                        if (dy == 0)
                        {
                            dy = 1;
                        }
                        else
                        {
                            dx = Math.Sign(dx) * (Math.Abs(dx) + 1);
                        }
                    }
                    else
                    {
                        // Player up, ball up
                        dy += -1;
                    }
                }
            }
        }
}
}

