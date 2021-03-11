using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Game_v1
{
    [Serializable] public class Barrel
    {
        public Point centar { get; set; } // 130 , 460 koordinati na pocetok na cevkata
        public double radians { get; set; }
        public int heliX1 { get; set; } // helicopter blade point 1 - X axis
        public int heliX2 { get; set; } // helicopter blade point 2 - X axis
        public int heliY1 { get; set; } // helicopter blade point 1 - Y axis
        private bool outX { get; set; } // out - se smaluvaat ili zgolemuvaat perkite
        public bool upY { get; set; } // up == true - se dvizi na gore

        public int ropePosX { get; set; }
        public int ropePosY { get; set; }
        public int ropeHeight { get; set; }
        public int ropeWidth { get; set; }

        public int wallPosX { get; set; }
        public int wallPosY { get; set; }
        public int wallHeight { get; set; }
        public int wallWidth { get; set; }

        public int buttonPosX { get; set; }
        public int buttonPosY { get; set; }
        public int buttonHeight { get; set; }
        public int buttonWidth { get; set; }

       

        public Barrel()
        {
            centar = new Point(130,460);
            radians = 1;
            heliX1 = 500;
            heliX2 = 500;
            heliY1 = 30;
            outX = true;
            upY = true;
        }
        public Barrel(Point p)
        {
            centar = p;
            radians = 1;
            heliX1 = 500;
            heliX2 = 500;
            heliY1 = 30;
            outX = true;
            upY = true;
        }
        public void drawBarrel(Graphics g, double r)
        {
            radians = r;
            Pen b = new Pen(Color.DarkOliveGreen, 10);
            g.DrawLine(b, centar.X, centar.Y, this.getBarrelExit().X, this.getBarrelExit().Y);
        }
        public Point getBarrelExit() // returns coordinates of barrel exit point
        {
            int tockaX = Convert.ToInt32(50 * Math.Cos(radians)) + centar.X;
            int tockaY = Convert.ToInt32(50 * Math.Sin(radians + Math.PI)) + centar.Y;
            return new Point(tockaX, tockaY);
        }
        public void move(double r)
        {
            radians = r;
        }
        public void drawHeli(Graphics g)
        {
            Pen b = new Pen(Color.White, 2);
            g.DrawLine(b, heliX1, heliY1, heliX2, heliY1); 
        }
        public void motionHeli() // helicopter blade rotate
        {
            if (heliX1 == 500) outX = true;
            if (heliX1 == 450) outX = false;

            if (heliY1 == 20)  upY = false;
            if (heliY1 == 60) upY = true;

            if (outX)   { heliX1 -= 10; heliX2 += 10; }
            else        { heliX1 += 10; heliX2 -= 10; }

            if (!upY)   heliY1+=2;
            else        heliY1-=2;
        }

        public void drawRope(Graphics g)
        {
            Brush brush = new SolidBrush(Color.White);
            g.FillRectangle(brush, ropePosX, ropePosY, ropeWidth, ropeHeight);
        }
     
        public void drawWall(Graphics g)
        {
            Brush brush = new SolidBrush(Color.DarkSlateGray);
            g.FillRectangle(brush, wallPosX, wallPosY, wallWidth, wallHeight);
        }
        public void drawButton(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Red);
            g.FillRectangle(brush, buttonPosX, buttonPosY, buttonWidth, buttonHeight);
        }
        public void moveRope(int x, int y)
        {       
            ropePosX = x+30;
            ropePosY = y+60;
        }   
        public void RopeFall()
        {         
            ropePosY += 5;
        }
        public void RopeDelete()
        {
            ropeHeight -= 5;
        }
        public void moveWall()
        {      
            wallHeight -= 2;
            wallPosY += 2;
        }
    }
}
