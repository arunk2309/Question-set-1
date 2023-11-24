using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Set_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //No 1
            //Console.WriteLine("Enter the Number1:");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Number2:");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sume of Two numbers is:" + (n1 + n2));
            //Console.WriteLine("Differnece of Two number is:" +Math.Abs(n1-n2));
            //Console.WriteLine("Product of Two numbers is:" + n1 * n2);

            //No 2
            //Console.WriteLine("Enter the value of a:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the value of B:");
            //int b = int.Parse(Console.ReadLine());
            //double total = Math.Pow(a, b);
            //Console.WriteLine("The raised integer of" + a + "and" + b + "is" + total);

            //No 3
            //Console.WriteLine("Enter the Length:");
            //int length = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enthe the Width:");
            //int width = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Height:");
            //int height = int.Parse(Console.ReadLine());
            //int Volume = length * width * height;
            //Console.WriteLine("The volume of the tank is:" + Volume);

            // No 4
            //Console.WriteLine("Enter the Radius:");
            //int radius = int.Parse(Console.ReadLine());
            //double perimeter = 2 * Math.PI * radius;
            //Console.WriteLine("The Perimeter of the Circle is:" + perimeter);



            // No 5
            //Console.WriteLine("Enter the Numbertor:");
            //int numerator = int.Parse(Console.ReadLine());
            //Console.WriteLine("Emter the Denominator:");
            //int denominator = int.Parse(Console.ReadLine());
            //int Q = numerator / denominator;
            //int R = numerator % denominator;
            //Console.WriteLine("The Quotient is:" + Q);
            //Console.WriteLine("The Remainder is:" + R);

            // No 6
            Console.WriteLine("Enter the Number:");
            int number = int.Parse(Console.ReadLine());
            double square = Math.Pow(number, 2);
            Console.WriteLine("THe Square of a Given number is:" + square);
        }
    }
}
