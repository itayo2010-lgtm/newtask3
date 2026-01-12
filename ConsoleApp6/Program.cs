using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
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

