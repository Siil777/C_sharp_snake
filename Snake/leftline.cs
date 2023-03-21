using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Rightline
    {
        List<Point> pList;
        public Rightline(int xRight, int xDown, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }






        }
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();

            }
        }
    }
}
