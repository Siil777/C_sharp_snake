using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
// point consist constituent 1) data, 2)constructor to creat differente points 3) Methods to call for each specific point
namespace Snake
{
    class program
    {
        static void Main(string[] args)
        {
            //// Point this is class is used to create instances
            //Point p1 =new Point(1,3,'*');
            ////p1.x= 1;
            ////p1.y= 3;
            ////p1.sym = '*';

            ////output to screen with the help of function Draw
            ////Draw(p1.x, p1.y,p1.sym);
            //// method draw to call it
            //p1.Draw();




            //Point p2=new Point(4,5,'*');
            ////p2.x=4; 
            ////p2.y=5;
            ////p2.sym = '*';

            ////Draw(p2.x, p2.y,p2.sym);
            //p2.Draw();

            HorizontalLine line=new HorizontalLine(5, 30,8,'+' ); //8 line 
            
            // вызываем метов DRAW линии
            line.Draw();

            VerticalLine line1 = new VerticalLine(8, 20, 5, '+');

            line1.Draw();


            //standart class library Csharp which can keep a few elements at once

            List<int> numlist = new List<int>();
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);

            // to get accsess to varriable
            int x = numlist[0]; // the first element of list
            int y = numlist[1];
            int z = numlist[2];

            // в переменную i на каждом ветке цикла были записаны значение всех элементов данного списка
            //foreach (int i in numlist)
            //{
            //    Console.WriteLine(i);

            //}
            ////remove - to delete some element

            //numlist.RemoveAt(0);

            //// list consist a few point
            List<Point> pList = new List<Point>();

            
            //pList.Add(p1);
            //pList.Add(p2);


            //int x1 = 1;
            //int y1 = 3;
            //char sym1 = '*';

            //Draw(x1, y1,sym1);

            //int x2 = 4;
            //int y2=5;
            //char sym2= '*';
            //repeated pieces of code are brought into a separate function
            //Draw(x2, y2,sym2);
           

            Console.ReadLine();


        }
        // to do not repeat each time copy, function will use as input parameters x,y,sym
        //static void Draw(int x,int y, char sym)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(sym);

        
    }

}
