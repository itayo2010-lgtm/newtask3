using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
                static void Task2()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            int sumeven = 0;
            int sumodd = 0;

            int max = num % 10;
            


            while (num > 0)
            {
                int digit = num % 10;
                if (digit > max)
                    max = digit;
                if (digit % 2  == 0)
                    sumeven += digit;
                else
                    sumodd += digit;
                num /= 10;
            }
            Console.WriteLine("the sum of even numbers is " + sumeven + " the sum of odd numbers is " + sumodd + " and the biggest number is " + max);
        }

        
        static void Task3()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            string output = "";
            int newnum;


            do
            {
                Console.WriteLine("enter a new number");
                newnum = int.Parse(Console.ReadLine());
                if (newnum != 0)
                {
                    if (num % 2 == 0)
                    {
                        output += newnum + " " + newnum + " ";
                    }
                    else
                    {
                        output += newnum + " ";
                    }
                }   while (newnum != 0);
               
            } while (newnum != 0);
            Console.WriteLine(output);
        }
        static void Main(string[] args)
        {
            Task3();
        }
    }
}

