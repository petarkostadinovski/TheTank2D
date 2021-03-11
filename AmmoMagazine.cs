using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_v1
{
    [Serializable] public class AmmoMagazine
    {
        public List<Ammo> ammoMag { get; set; }
        public int count { get; set; }
        public bool getAmmo { get; set; }
        public Point lastHit { get; set; }
        public double score { get; set; }
        public AmmoMagazine()
        {
            lastHit = new Point();
            ammoMag = new List<Ammo>();
            getAmmo = true;
            count = 15;
        }
        public void draw(Graphics g)
        {
            foreach(var item in ammoMag)
            {
                item.drawAmmo(g);
            }
        }
        public void drawGrayAmmo(Graphics g)
        {
            foreach (var item in ammoMag)
            {
                item.drawAmmoGray(g);
            }
        }
        public void add(Ammo a)
        {
            ammoMag.Add(a);
        }
        public void move()
        {
            foreach(var item in ammoMag)
            {
                item.move();
            }
        }
        public void Check() // removes ammo that is off-screen
        {
            for(int i=0; i<ammoMag.Count; i++)
            {
                if (ammoMag[i].centar.X > 1210 || ammoMag[i].centar.Y > 610
                    || ammoMag[i].centar.Y < -10) ammoMag.RemoveAt(i);
            }
        }
        public bool isHit(Point UpLeft, Point DownRight)
        {
            for (int i = 0; i < ammoMag.Count; i++)
            {
                if (ammoMag[i].isHit(UpLeft, DownRight))
                {
                    lastHit = ammoMag[i].centar;
                    ammoMag.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}
