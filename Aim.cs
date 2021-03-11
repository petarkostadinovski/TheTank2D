using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_v1
{
   [Serializable] public class Aim
    {
        public Point centar { get; set; }
        public Aim() { centar = new Point(); }
        public Aim(Point c)
        {
            centar = c;
        }
        public void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, centar.X, centar.Y - 10, centar.X, centar.Y + 10);
            g.DrawLine(p, centar.X-10, centar.Y, centar.X+10, centar.Y);
            g.DrawEllipse(p, centar.X-10, centar.Y-10, 20, 20);
        }
        public void move(Point p)
        {
            centar = p;
        }
    }
}
