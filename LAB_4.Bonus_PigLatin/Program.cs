using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LAB_4.Bonus_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr;
            string pattern = @"^[a-zA-Z]{1,}$";

            Console.WriteLine("Welcome to the Pig Latin Translator!\n");

            do
            {
                
                arr = GetString().Split(" ");
                Console.WriteLine();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (CheckRegex(arr[i],pattern))
                    {
                        TranslatePigLatin(arr[i]);
                    }
                    else
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
            } while (RunAgain());
        }
        //------------------------------------------------------------------------------------------------------
        //------------------------------------- GETS STRING INPUT ----------------------------------------------
        //------------------------------------------------------------------------------------------------------
        public static string GetString()
        {
            string input;
            do
            {
                Console.Write("Please enter a word or phrase: ");
                input = Console.ReadLine();
                if (input.Length <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("You must enter text..");
                    Console.WriteLine();
                }
            } while (input.Length <= 0);
            return input;
        }
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------
        //---------------------------------------- REGEX CHECK -------------------------------------------------
        //------------------------------------------------------------------------------------------------------
        public static bool CheckRegex(string str, string pattern)
        {
            if (Regex.IsMatch(str, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------
        //------------------------------------- PIG LATIN TRANSLATION ------------------------------------------
        //------------------------------------------------------------------------------------------------------
        public static void TranslatePigLatin(string str)
        {
            string vowls = "aeiouAEIOU";
            if (vowls.Contains(str[0]))
            {
                Console.Write(str + "way ");
            }
            else
            {
                Console.Write(str.Substring(1, str.Length - 1) + str[0] + "ay ");
            }
        }
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------
        //------------------------------------- CONTINUE PROMPT ------------------------------------------------
        //------------------------------------------------------------------------------------------------------
        public static bool RunAgain()
        {
            char c;
            do
            {
                Console.WriteLine("\n");
                Console.Write("Would you like to continue? (y/n): ");
                c = Console.ReadKey().KeyChar;

                if (c == 'n' || c == 'N')
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Bye!");
                    Console.WriteLine();
                    return false;
                }
                Console.WriteLine("\n");
            } while (c != 'y' && c != 'Y');
            return true;
        }
        //------------------------------------------------------------------------------------------------------
    }
}
