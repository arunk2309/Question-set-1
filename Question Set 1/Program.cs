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
            Console.WriteLine("Enter the value of a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of B:");
            int b = int.Parse(Console.ReadLine());
            double total = Math.Pow(a, b);
            Console.WriteLine("The raised integer of" + a + "and" + b + "is" + total);
        }
    }
}
