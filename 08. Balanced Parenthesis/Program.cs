using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parantheses = new Stack<char>();

            bool isBalanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    parantheses.Push(input[i]);
                }
                if (parantheses.Count == 0)
                {
                    
                    isBalanced = false;
                    break;
                }
                if (input[i] == ')' & parantheses.Peek() == '(')
                {
                    parantheses.Pop();
                }
                else if (input[i] == '}' & parantheses.Peek() == '{')
                {
                    parantheses.Pop();
                }
                else if (input[i] == ']' & parantheses.Peek() == '[')
                {
                    parantheses.Pop();
                }
                
            }
            
            if (!isBalanced || parantheses.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }


        }
    }
}