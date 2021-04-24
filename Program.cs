using System;

namespace midterm_sat
{
    class Program
    {
        static void Main(string[] args)
        {
            //ข้อ2.1/2.2
            /*
            Console.Write("input a number =");
            int year =int.Parse(Console.ReadLine());
            
            if ((year % 400) == 0)
            {
                Console.Write("Leap year!");
            }
            else if ((year % 100) == 0)
            {
                Console.Write("Not leap year!");
            }
            else if ((year % 4) == 0)
            {
                Console.Write("Leap year!");
            }
            else
                Console.Write("Error!!");
            */
            //ข้อ4
            float x,y,dx,dy,step;
            Console.Write("Input x1");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Input y1");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Input x2");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Input y2");
            int y2 = int.Parse(Console.ReadLine());
            if (dx == x2 - x1)
            {
                if (dy == y2 - y1)
                {
                    if (Math.Abs(dx) >= Math.Abs(dy))
                    {
                        Console.Write(step = Math.Abs(dx));
                    }
                    else if ((Math.Abs(dx) >= Math.Abs(dy)))
                    {
                        Console.Write(dx /= step);
                    }
                    else if ((Math.Abs(dx) >= Math.Abs(dy)))
                    {
                        Console.Write(dy /= step);
                    }
                    else if ((Math.Abs(dx) >= Math.Abs(dy)))
                    {
                        Console.Write(x = x1);
                    }
                    else if ((Math.Abs(dx) >= Math.Abs(dy)))
                    {
                        Console.Write(y = y1);
                    }
                }
                for (int i = 1; i <= step; i++)
                {
                    Console.Write("x={0},y={1}",dx,dy);
                }
            }
            else
                Console.Write("ERROR");
        }
    }
}
