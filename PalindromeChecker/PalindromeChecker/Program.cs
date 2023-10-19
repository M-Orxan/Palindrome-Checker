using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome!");
            bool wantsToContinue = true;

            while (wantsToContinue)
            {
               

                Console.WriteLine();

                Console.WriteLine("Please enter the number:");

                string userInput = Console.ReadLine();
                int originalNumber = CheckNumberValidity(userInput);

                int reverserNumber = FindReversedOfNumber(originalNumber);
                Console.WriteLine();
                CheckPalindrome(originalNumber, reverserNumber);
                Console.WriteLine();

                Console.WriteLine("Do you want to check anoter number? Yes or no");
                string choice = Console.ReadLine();
                bool isValid = false;

                while (!isValid)
                {
                    if (choice.ToLower() == "yes")
                    {
                        isValid= true;
                    }
                    else if (choice.ToLower() == "no")
                    {
                        wantsToContinue = false;
                        isValid = true;
                        Console.WriteLine();
                        Console.WriteLine("Thanks for playing");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again:");
                        choice = Console.ReadLine();
                    }
                }
                
            }


            


        }

        public static int CheckNumberValidity(string input)
        {
            int number;

            bool isValid = int.TryParse(input, out number);

            while (!isValid)
            {
                Console.WriteLine("Invalid input. Please try again:");
                input = Console.ReadLine();
                isValid = int.TryParse(input, out number);

            }
            return number;
        }

        public static int FindReversedOfNumber(int number)
        {
            string stringReversedNumber = "";
            int reversedNumber;

            while (number > 0)
            {
                int num = number % 10;
                stringReversedNumber += num;
                number = number / 10;

            }

            
            int.TryParse(stringReversedNumber, out reversedNumber);
            return  reversedNumber;
            
        }

        public static void CheckPalindrome(int originalNumber, int reversedNumber)
        {
            if(originalNumber==reversedNumber)
            {
                Console.WriteLine("It's a palindrome number");
            }
            else
            {
                Console.WriteLine("It's not a palindrome number");
            }
        }


      

    }
}
