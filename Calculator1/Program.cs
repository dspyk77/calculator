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
            int firstNumber = 0;
            int secondNumber = 0;
            bool repeatQ;
            
            

            

                Console.WriteLine("Welcome to the calculator!\r\n Enter a number.");

            while (repeatQ = true)
            {

                firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a second number.");
                secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine($"You entered {firstNumber} and {secondNumber}");

                


                if (secondNumber >= 1)
                {
                    Console.WriteLine("Enter a to add, s to subtract, m to multiply or d to divide");
                }
                else
                {
                    Console.WriteLine("Enter a to add, s to subtract, m to multiply or d to divide");
                    Console.WriteLine("You better not try and divide with those numbers...");
                }
                
                    


                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"{firstNumber} plus {secondNumber} is " + (firstNumber + secondNumber) + ", You really needed a calculator for that?");
                        break;

                    case "s":
                        Console.WriteLine($"{firstNumber} minus {secondNumber} is " + (firstNumber - secondNumber) + ", Alright alright you can put down your fingers now.");
                        break;

                    case "m":
                        Console.WriteLine($"Boop beep bo boop {firstNumber} times {secondNumber} is " + (firstNumber * secondNumber) + " now get out of my program");
                        break;

                    case "d":
                        Console.WriteLine($"{firstNumber} divided by {secondNumber} is " + (secondNumber / secondNumber) + " What ever happened to long divison?");
                        break;
                        
                    default:
                        Console.WriteLine("You having a hard time reading bud?");
                        break;


                }

                    Console.WriteLine("Another equation?");
                repeatQ = true;

            }
            
            Console.ReadKey();



        }
    }
}