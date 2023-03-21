using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xRight,int y, char sym)
        {
            pList = new List<Point>();

            // в данном цикле на каждой итерации переменная x будет получать значение от xLeft до xRight
            // на первом витке x получает значение 5 , дальше делаем проверку что не дошли до конца цикла x <=xRight, увиличиваем x на 1
            for (int x = xLeft; x <=xRight; x++)
            {
                // point with essential means
                Point p=new Point(x,y,sym);
                // and add them to list with points
                // координаты со значением левой точки 
                pList.Add(p);

            }
            //Point p1= new Point(4,4,'*'); 
            //Point p2= new Point(5,4,'*');
            //Point p3= new Point(6,4,'*');
            //pList.Add(p1);
            //pList.Add(p2);
            //pList.Add(p3);
        }
        public void Draw()
        {
            // и по очередно выводим на экран каждую точку 
            foreach (Point p in pList)
            {
                p.Draw();

            }
        }

    }
}
