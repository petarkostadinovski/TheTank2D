using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Game_v1
{
    [Serializable] public class Ammo
    {
        public Point centar { get; set; }
        public double speedX { get; set; }
        public double speedY { get; set; }
        public static readonly double G = 0.3;
        SoundPlayer explosionSound = new SoundPlayer(Game_v1.Properties.Resources.explosion);
        public Ammo(Point t ,double x, double y)
        {
            centar = t;
            this.speedX = x;
            this.speedY = y;
            
        }
        public void drawAmmo(Graphics g)
        {
                Brush b = new SolidBrush(Color.Black);
                g.FillEllipse(b, centar.X, centar.Y, 10, 10);
        }
        public void drawAmmoGray(Graphics g)
        {
            Brush b = new SolidBrush(Color.DarkGray);
            g.FillEllipse(b, centar.X, centar.Y, 10, 10);
        }
        public void move()
        {
            Point t = new Point(centar.X + Convert.ToInt32(speedX), centar.Y + (Convert.ToInt32(speedY + G)));
            centar = t;
            speedY += G;
        }
        public bool isHit(Point UpLeft, Point DownRight)
        {
            if((centar.X + 5 > UpLeft.X && centar.X-5 < DownRight.X) &&
                    (centar.Y + 5 > UpLeft.Y && centar.Y-5 < DownRight.Y))
            {
                explosionSound.Play();
                return true;
            }
            else
                return false;
        }
    }
}
