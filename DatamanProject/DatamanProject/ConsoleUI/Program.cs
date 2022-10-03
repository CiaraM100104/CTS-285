using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanProjectClassLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Problem> memoryBankProblems = new List<Problem>();
            string userInput = "";
            String userProblem = "";
            int i = 1;
            while (userInput != "7")
            {
                Console.WriteLine("Welcome to the calculator program! Please choose a number.");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Divide");
                Console.WriteLine("4. Multiply");
                Console.WriteLine("5. Answer Checker");
                Console.WriteLine("6. Memory Bank");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Enter in your choice here > ");
                userInput = Console.ReadLine();

                switch (userInput.ToLower())
                {
                    case "1":
                        Console.WriteLine("Please enter in your first number to add.");
                        String userNum1 = Console.ReadLine();
                        Console.WriteLine("Please enter in your second number to add.");
                        String userNum2 = Console.ReadLine();
                        Console.WriteLine("The answer is " + Logic.addNumbers(userNum1, userNum2));
                        break;
                    case "2":
                        Console.WriteLine("Please enter in your first number to subtract.");
                        userNum1 = Console.ReadLine();
                        Console.WriteLine("Please enter in your second number to subtract.");
                        userNum2 = Console.ReadLine();
                        Console.WriteLine("The answer is " + Logic.subtractNumbers(userNum1, userNum2));
                        break;
                    case "3":
                        Console.WriteLine("Please enter in your first number to divide.");
                        userNum1 = Console.ReadLine();
                        Console.WriteLine("Please enter in your second number to divide.");
                        userNum2 = Console.ReadLine();
                        Console.WriteLine("The answer is " + Logic.divideNumbers(userNum1, userNum2));
                        break;
                    case "4":
                        Console.WriteLine("Please enter in your first number to multiply.");
                        userNum1 = Console.ReadLine();
                        Console.WriteLine("Please enter in your second number to multiply.");
                        userNum2 = Console.ReadLine();
                        Console.WriteLine("The answer is " + Logic.multiplyNumbers(userNum1, userNum2));
                        break;
                    case "5":
                        Console.WriteLine("Please enter in your problem like so: 2 + 2 = 4");
                        userProblem = Console.ReadLine();
                        Logic.answerChecker(userProblem);
                        break;
                    case "6":
                        Console.WriteLine("Are you storing questions inside of the memory bank? Press 1 to proceed.");
                        Console.WriteLine("Are you answering questions from the memory bank? Press 2 to proceed.");
                        Console.WriteLine("Would you like to clear the memory bank? Press 3 to proceed.");
                        String userInput2 = Console.ReadLine();
                        if (userInput2 == "1")
                        {
                            while (userProblem != "2")
                            {
                                
                                Console.WriteLine("Please format your problem like so: 2 + 2. Press 2 if you wish to stop entering problems.");
                                Console.WriteLine("Enter in problem " + i + ":");
                                userProblem = Console.ReadLine();
  
                                if (userProblem != "2")
                                {
                                    memoryBankProblems = Logic.memoryBankStore(userProblem, memoryBankProblems);
                                }

                                i++;
                                if (i > 10)
                                {
                                    break;
                                }

                            }

                        }
                        else if (userInput2 == "2")
                        {
                            Logic.memoryBankSolve(memoryBankProblems);
                        }
                        else if (userInput2 == "3")
                        {
                            memoryBankProblems.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Not a choice, please pick 7 if you wish to exit.");
                        Console.WriteLine();
                        break;
                }
            }
           
        }
    }
}
