using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "(5+7)*2-(4/2)";
            Console.WriteLine(Calculator(input)); // Output: 22
        }
        static int Calculator(string str)
        {
            char[] arrOfChar = str.ToCharArray();

            //* Stack for Numbers 
            Stack<int> numbers = new Stack<int>();
            //* Stack for Processes
            Stack<char> processes = new Stack<char>();

            for (int i = 0; i < arrOfChar.Length; i++)
            {
                // If the current character is a whitespace, skip it
                if (arrOfChar[i] == ' ')
                    continue;

                // If the current character is a digit, push it to the numbers stack
                if (char.IsDigit(arrOfChar[i]))
                {
                    int num = 0;
                    while (i < arrOfChar.Length && char.IsDigit(arrOfChar[i]))
                    {
                        num = num * 10 + (arrOfChar[i] - '0');
                        i++;
                    }
                    i--;

                    numbers.Push(num);
                }

                // If the current character is an opening parenthesis, push it to the processes stack
                else if (arrOfChar[i] == '(')
                {
                    processes.Push(arrOfChar[i]);
                }

                // If the current character is a closing parenthesis, evaluate the arrOfChar inside the parentheses
                else if (arrOfChar[i] == ')')
                {
                    while (processes.Peek() != '(')
                    {
                        int num2 = numbers.Pop();
                        int num1 = numbers.Pop();
                        char op = processes.Pop();
                        int result = ApplyProcesse(op, num1, num2);
                        numbers.Push(result);
                    }
                    processes.Pop();
                }

                // If the current character is an operator, push it to the processes stack
                else if (arrOfChar[i] == '+' || arrOfChar[i] == '-' ||
                         arrOfChar[i] == '*' || arrOfChar[i] == '/')
                {
                    while (processes.Count > 0 && HasPrecedence(arrOfChar[i], processes.Peek()))
                    {
                        int num2 = numbers.Pop();
                        int num1 = numbers.Pop();
                        char op = processes.Pop();
                        int result = ApplyProcesse(op, num1, num2);
                        numbers.Push(result);
                    }

                    processes.Push(arrOfChar[i]);
                }
            }


            // Evaluate the remaining processes in the stacks
            while (processes.Count > 0)
            {
                int num2 = numbers.Pop();
                int num1 = numbers.Pop();
                char op = processes.Pop();
                int result = ApplyProcesse(op, num1, num2);
                numbers.Push(result);
            }

            //* The final result is the only element left in the numbers stack
            return numbers.Pop();
        }

        static bool HasPrecedence(char currentOperation, char peekOperation)
        {
            if (peekOperation == '(' || peekOperation == ')')
                return false;
            if ((currentOperation == '*' || currentOperation == '/') && (peekOperation == '+' || peekOperation == '-'))
                return false;
            else
                return true;
        }

        static int ApplyProcesse(char op, int num1, int num2)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                default:
                    return 0;
            }
        }
    }
}
