// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNumber;
            string secondNumber;
            bool repeatQ = true;
            bool isNum1, isNum2;

            Console.WriteLine("Welcome to the calculator!\r\n Enter a number.");
            // loops program until user if finished. ending each equation user is asked to continue or to press "x" to exit the program.
            while (repeatQ)
            {
                firstNumber = Console.ReadLine();

                if (isNum1 = int.TryParse(firstNumber, out int firstNumberParsed))
                {
                    Console.WriteLine("Enter a second number.");
                }
                else
                {
                    Console.WriteLine($" {firstNumber} is not a number... I'm a more.. Simple calculator. Try again?");
                    firstNumber = Console.ReadLine();
                }

                secondNumber = Console.ReadLine();

                if (isNum2 = int.TryParse(secondNumber, out int secondNumberParsed))
                {
                    Console.WriteLine($"You entered {firstNumber} and {secondNumber}");
                }
                else
                {
                    Console.WriteLine($" {secondNumber} is not a number... I'm a more.. Simple calculator. Try again?");
                    secondNumber = Console.ReadLine();
                }

                // checking to make sure user wont divide by zero. Currently working more as a warning. If user divideds by zero program still crashes. work in progress... 

                if (secondNumberParsed == 0)
                {
                    Console.WriteLine("You better not try and divide with those numbers...");
                    Console.WriteLine("Enter a to add, s to subtract, m to multiply or d to divide");
                }
                else
                {
                    Console.WriteLine("Enter a to add, s to subtract, m to multiply or d to divide");
                }

                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"{firstNumber} plus {secondNumber} is " + (firstNumberParsed + secondNumberParsed) + ", I love the simple equations!");
                        break;

                    case "s":
                        Console.WriteLine($"{firstNumber} minus {secondNumber} is " + (firstNumberParsed - secondNumberParsed) + ", Alright alright, you can put down your fingers now.");
                        break;

                    case "m":
                        Console.WriteLine($"Boop beep bo boop {firstNumber} times {secondNumber} is " + (firstNumberParsed * secondNumberParsed) + " ....whoa");
                        break;

                    case "d":
                        Console.WriteLine($"{firstNumber} divided by {secondNumber} is " + (firstNumberParsed / secondNumberParsed) + " What ever happened to long divison? Calculators!");
                        break;

                    default:
                        Console.WriteLine("You know this is a calculator, right?");
                        break;
                }
                
                Console.WriteLine("Another equation? Keep on going! or just press x to exit");

                switch (Console.ReadLine())
                {
                    case "x":
                        repeatQ = false;
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
