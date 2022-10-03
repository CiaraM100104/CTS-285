using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanProjectClassLibrary
{
    public class Logic
    {
        public static void answerChecker(string problem)
        {
            int num1;
            int num2;
            // For division and multiplying, may add double to addition/subtract, havent decided.
            double dmNum1;
            double dmNum2;
            double dmAnswer1;
            double dmAnswer2;
            int answer1;
            int answer2;
            string[] tokens = problem.Split(' ');
            Problem userProblem = new Problem(tokens[0], tokens[1], tokens[2], tokens[4]);
            if (userProblem.Operand == "+")
            {

                num1 = int.Parse(userProblem.Number1);
                num2 = int.Parse(userProblem.Number2);
                answer1 = int.Parse(userProblem.Answer);

                answer2 = num1 + num2;
                if (answer1 == answer2)
                {
                    Console.WriteLine("Correct.");
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }
            else if (userProblem.Operand == "-")
            {
                num1 = int.Parse(userProblem.Number1);
                num2 = int.Parse(userProblem.Number2);
                answer1 = int.Parse(userProblem.Answer);

                answer2 = num1 - num2;
                if (answer1 == answer2)
                {
                    Console.WriteLine("Correct.");
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }
            else if (userProblem.Operand == "*")
            {
                dmNum1 = int.Parse(userProblem.Number1);
                dmNum2 = int.Parse(userProblem.Number2);
                dmAnswer1 = int.Parse(userProblem.Answer);

                dmAnswer2 = dmNum1 * dmNum2;
                if (dmAnswer1 == dmAnswer2)
                {
                    Console.WriteLine("Correct.");
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }
            else if (userProblem.Operand == "/")
            {
                dmNum1 = int.Parse(userProblem.Number1);
                dmNum2 = int.Parse(userProblem.Number2);
                dmAnswer1 = int.Parse(userProblem.Answer);

                dmAnswer2 = dmNum1 / dmNum2;
                if (dmAnswer1 == dmAnswer2)
                {
                    Console.WriteLine("Correct.");
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }
            else
            {
                Console.WriteLine(userProblem.Operand);
                Console.WriteLine("Invalid Input.");
            }
        }

        public static void memoryBankAnswerChecker(Problem userProblem, string userAnswer)
        {
            int num1;
            int num2;
            // For division and multiplying, may add double to addition/subtract, havent decided.
            double dmNum1;
            double dmNum2;
            double dmAnswer1;
            double dmAnswer2;
            int answer1;
            int answer2;
            int i = 1;
            if (userProblem.Operand == "+")
            {

                num1 = NumberParse.ParseInt(userProblem.Number1);
                num2 = NumberParse.ParseInt(userProblem.Number2);
                answer1 = NumberParse.ParseInt(userAnswer);

                answer2 = num1 + num2;
                if (answer1 == answer2)
                {
                    Console.WriteLine("Correct.");
                }
                else
                {
                    while (i != 2)
                    {
                        Console.WriteLine("Incorrect. Please try it again.");
                        i++;
                        answer1 = NumberParse.ParseInt(Console.ReadLine());
                        if (answer1 == answer2)
                        {
                            Console.WriteLine("Correct.");
                        }
                        else
                        {
                            Console.WriteLine("Sorry that was both of your tries, the correct answer was: " + answer2);
                        }
                    }
                }
            }
            else if (userProblem.Operand == "-")
            {
                num1 = NumberParse.ParseInt(userProblem.Number1);
                num2 = NumberParse.ParseInt(userProblem.Number2);
                answer1 = NumberParse.ParseInt(userAnswer);

                answer2 = num1 - num2;
                if (answer1 == answer2)
                {
                    Console.WriteLine("Correct.");
                }
                else
                {
                    while (i != 2)
                    {
                        Console.WriteLine("Incorrect. Please try it again.");
                        i++;
                        answer1 = NumberParse.ParseInt(Console.ReadLine());
                        if (answer1 == answer2)
                        {
                            Console.WriteLine("Correct.");
                        }
                        else
                        {
                            Console.WriteLine("Sorry that was both of your tries, the correct answer was: " + answer2);
                        }
                    }
                }
            }
            else if (userProblem.Operand == "*")
            {
                dmNum1 = NumberParse.ParseInt(userProblem.Number1);
                dmNum2 = NumberParse.ParseInt(userProblem.Number2);
                dmAnswer1 = NumberParse.ParseInt(userAnswer);

                dmAnswer2 = dmNum1 * dmNum2;
                if (dmAnswer1 == dmAnswer2)
                {
                    Console.WriteLine("Correct.");
                }
                else
                {
                    while (i != 2)
                    {
                        Console.WriteLine("Incorrect. Please try it again.");
                        i++;
                        dmAnswer1 = NumberParse.ParseDouble(Console.ReadLine());
                        if (dmAnswer1 == dmAnswer2)
                        {
                            Console.WriteLine("Correct.");
                        }
                        else
                        {
                            Console.WriteLine("Sorry that was both of your tries, the correct answer was: " + dmAnswer2);
                        }
                    }
                }
            }
            else if (userProblem.Operand == "/")
            {
                dmNum1 = NumberParse.ParseInt(userProblem.Number1);
                dmNum2 = NumberParse.ParseInt(userProblem.Number2);
                dmAnswer1 = NumberParse.ParseInt(userAnswer);

                dmAnswer2 = dmNum1 / dmNum2;
                if (dmAnswer1 == dmAnswer2)
                {
                    Console.WriteLine("Correct.");
                }
                else
                {
                    while (i != 2)
                    {
                        Console.WriteLine("Incorrect. Please try it again.");
                        i++;
                        dmAnswer1 = NumberParse.ParseDouble(Console.ReadLine());
                        if (dmAnswer1 == dmAnswer2)
                        {
                            Console.WriteLine("Correct.");
                        }
                        else
                        {
                            Console.WriteLine("Sorry that was both of your tries, the correct answer was: " + dmAnswer2);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine(userProblem.Operand);
                Console.WriteLine("Invalid Input.");
            }
        }

        public static List<Problem> memoryBankStore(string problem, List<Problem> userMemory)
        {
            string[] tokens = problem.Split(' ');
            Problem userProblem = new Problem(tokens[0], tokens[1], tokens[2]);
            userMemory.Add(userProblem);
            return userMemory;
        }

        public static void memoryBankSolve(List<Problem> userMemory)
        {
            foreach (Problem problem in userMemory)
            {
                Console.WriteLine(problem.Number1 + " " + problem.Operand + " " + problem.Number2 + " = ?");
                String userAnswer = Console.ReadLine();
                memoryBankAnswerChecker(problem, userAnswer);
            }
        }

        public static double addNumbers(string num1, string num2)
        {
            double number1;
            double number2;
            number1 = NumberParse.ParseDouble(num1);
            number2 = NumberParse.ParseDouble(num2);
            return number1 + number2;
        }

        public static double subtractNumbers(string num1, string num2)
        {
            double number1;
            double number2;
            number1 = NumberParse.ParseDouble(num1);
            number2 = NumberParse.ParseDouble(num2);
            return number1 - number2;
        }

        public static double multiplyNumbers(string num1, string num2)
        {
            double number1;
            double number2;
            number1 = NumberParse.ParseDouble(num1);
            number2 = NumberParse.ParseDouble(num2);
            return number1 * number2;
        }

        public static double divideNumbers(string num1, string num2)
        {
            double number1;
            double number2;
            number1 = NumberParse.ParseDouble(num1);
            number2 = NumberParse.ParseDouble(num2);
            return number1 / number2;
        }
    }
}
