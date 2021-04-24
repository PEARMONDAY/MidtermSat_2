using System;

namespace midterm_sat
{
    class Program
    {
        static void Main(string[] args)
        {
            //ข้อ2.1/2.2
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
            
        }
    }
}
