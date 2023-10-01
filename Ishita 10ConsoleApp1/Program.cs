using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishita_10ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("\n\n Recursion: Print even or odd numbers in a given range : \n");
            Console.WriteLine("...............................................................");

            Console.WriteLine("Input the rang to print starting from 1: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n all even numbers from 1 to {0} are :", n);
            EvenAndOdd(2, n); ;//call the function EvenAndOdd for even numbers

            Console.WriteLine("\n\n all even numbers from 1 to {0} are :", n);
            EvenAndOdd(1, n); ;//call the function EvenAndOdd for odd numbers
            Console.WriteLine("\n\n");

            return;
        }
        static void EvenAndOdd(int stVal, int n)
        {
            if (stVal > n)
                return;
            Console.Write(" {0}  ", stVal);
            EvenAndOdd(stVal + 2, n);//calling the function EvenAndOdd itself recursively
        }
    }
}


