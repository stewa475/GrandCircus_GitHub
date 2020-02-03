using System;
using System.Collections.Generic;

namespace LAB_3._3_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;

            Console.WriteLine("Please enter a sentence you would like to reverse: ");
            word = Console.ReadLine();

            string[] sentence = word.Split(" ");
            string[] reversedSentence = new string[sentence.Length];

            for (int i = 0; i < sentence.Length; i++)
            {
                reversedSentence[i] = Reverse(sentence[i]);
            }

            for (int i = 0; i < reversedSentence.Length; i++)
            {
                Console.Write(reversedSentence[i] + " ");
            }
        }

        static string Reverse(string str)
        {
            Stack<char> stack = new Stack<char>();

            string returnstring = "";

            foreach (char s in str)
            {
                stack.Push(s);
            }

            while (stack.Count > 0)
            {
                returnstring += stack.Pop();
            }
            return returnstring;
        }
        
    }
}
