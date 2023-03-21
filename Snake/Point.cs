using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
// class this the same type of data as numbers of symbols
// class fisrt of all save some data
//encapsulation allows you to combine data and methods working with nimes in the class
// инкапсуляция позволяет объеденить данные и методы работающие с нимми в классе(свойств класса скрывать делтали своей реализации)
namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        //function constructor will be called by creating each point 

        public Point()
        {
            //Console.WriteLine("creat a new point");
        }
        // by creating new point takes 3 arguments
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }



        public void Draw()
        {
            // sets the position of the curso
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
    
    
       
    
}
