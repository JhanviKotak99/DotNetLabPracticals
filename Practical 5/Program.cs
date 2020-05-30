using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter infix expression to be converted");
            String exp = Console.ReadLine();
            String ansOfPostfix = infixToPostfix(exp);
            String ansOfPrefix = infixToPrefix(exp);
            Console.WriteLine("Postfix : " + ansOfPostfix);
            Console.WriteLine("Prefix : " + ansOfPrefix);
            Console.Read();

        }
        public static int Prec(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
        }
        public static string infixToPostfix(string exp)
        {
            // initializing empty String for result  
            string result = "";

            // initializing empty stack  
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < exp.Length; ++i)
            {
                char c = exp[i];

                // If the scanned character is an operand, add it to output.  
                if (char.IsLetterOrDigit(c))
                {
                    result += c;
                }

                // If the scanned character is an '(', push it to the stack.  
                else if (c == '(')
                {
                    stack.Push(c);
                }

                //  If the scanned character is an ')', pop and output from the stack   
                // until an '(' is encountered.  
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result += stack.Pop();
                    }

                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        return "Invalid Expression"; // invalid expression 
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else // an operator is encountered 
                {
                    while (stack.Count > 0 && Prec(c) <= Prec(stack.Peek()))
                    {
                        result += stack.Pop();
                    }
                    stack.Push(c);
                }

            }

            // pop all the operators from the stack  
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }

            return result;






        }
        public static string infixToPrefix(string exp)
        {
            string result = infixToPostfix(exp);
            char[] postChar = result.ToCharArray();
            int n = postChar.Length;
            int j = n - 1;
            char[] prefixChar = new char[n];
            for (int i = 0; i < n; i++)
            {
                prefixChar[i] = postChar[j];
                j--;
            }
            string prefix = new string(prefixChar);
            return prefix;
        }

    }
}
