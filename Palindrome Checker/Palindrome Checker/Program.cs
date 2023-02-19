using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Palindrome Checker\n");
            Console.WriteLine("Enter the number you want to check:");

            string num = Console.ReadLine();

            bool needToBreak = false;
            while (!needToBreak)
            {
                start:
                int number;

                while (!int.TryParse(num, out number))
                {
                    Console.WriteLine("Invalid value. Please try again:");
                    num = Console.ReadLine();
                }


                string reversedNum = "";
                while (number != 0)
                {
                    reversedNum += number % 10;

                    number = number / 10;
                }


                if (num == reversedNum)
                {
                    Console.WriteLine("It's a palindrome number");
                }
                else
                {
                    Console.WriteLine("It's not a palindrome number");
                }

                Console.WriteLine("Do you want to check another number? Press y for yes, n for no:");

                string choice = Console.ReadLine();
                while (true)
                {
                    if (choice == "y" || choice == "Y")
                    {
                        Console.WriteLine("Enter the number you want to check:");
                        num = Console.ReadLine();
                        goto start;
                    }
                    else if (choice == "n" || choice == "N")
                    {
                        Console.WriteLine("Thanks for playing");
                        needToBreak = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again:");
                        choice = Console.ReadLine();
                    }
                }

                

            }
            

        }


        
    }
}
