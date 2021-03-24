using System;
using System.Collections;

namespace Data_Structure
{
    class Program
    {
        public static string reversing(string reverse)
        {
            Stack stack = new Stack();
            foreach (char c in reverse) stack.Push(c);
            string input = "";
            while(stack.Count != 0)
            {
                input += stack.Pop();
            }
            return input;
        }
        public static string reverseData(string data)
        {
            string output = "";
            string input = "";
            foreach(char c in data)
            {
                if(c == ' ')
                {
                    input += reversing(output);
                    input += " ";
                    output = "";
                }
                else
                {
                    output += c;
                }
            }
            return reversing(output);
        }
        public static bool correct(string reverse)
        {
            foreach(char c in reverse)
            {
                if (!((c >= 'a' && c <= 'z' || c >= 'A' || c <= 'Z')))
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string userInput;
            Console.Write("Please enter a word you would like to reverse: ");
            userInput = Console.ReadLine();
            Console.WriteLine("Your word in reverse is: " + reverseData(userInput));
            
           
        }
    }
}
