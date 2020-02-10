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
            string pattern = @"^[a-zA-Z]+$";

            Console.WriteLine("Welcome to the Pig Latin Translator!\n");

            do
            {

                arr = GetString().Split(" ");
                Console.WriteLine();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (CheckRegex(arr[i], pattern))
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
                    Console.WriteLine("\nYou must enter text..\n");
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
        public static string TranslatePigLatin(string str)
        {
            string vowels = "aeiouAEIOU";
            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[0]))
                {
                    Console.Write(str + "way ");
                    break;
                }
                else if (vowels.Contains(str[i]) && str.Length > 2)
                {
                    Console.Write(str.Substring(i) + str.Substring(0, i) + "ay ");
                    break;
                }
                else if ((!vowels.Contains(str[0])) && str.Length == 2)
                {
                    Console.Write($"{str[1]}{str[0]}ay ");
                    break;
                }
                else if (!vowels.Contains(str[0]) && str.Length == 1)
                {
                    Console.Write($"{str}ay ");
                    break;
                }
            }
            return str;
            //----------------------------------------------------------------------------
            //if (vowels.Contains(str[0]))
            //{
            //    str = str + "way ";
            //    return str;
            //}
            //else
            //{
            //    string strCopy1 = str;
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        strCopy1 = (strCopy1.Substring(1) + (str[i]));

            //        if (vowels.Contains(strCopy1[0]))
            //        {
            //            break;
            //        }
            //    }
            //    string strCopy2 = strCopy1 + "ay ";
            //    return strCopy2;
            //}
        }
        //----------------------------------------------------------------------------
    
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------
        //------------------------------------- CONTINUE PROMPT ------------------------------------------------
        //------------------------------------------------------------------------------------------------------
        public static bool RunAgain()
        {
            char c;
            do
            {
                Console.Write("\n\nWould you like to continue? (y/n): ");
                c = Console.ReadKey().KeyChar;

                if (c == 'n' || c == 'N')
                {
                    Console.WriteLine("\n\nBye!\n");
                    return false;
                }
                Console.WriteLine("\n");
            } while (c != 'y' && c != 'Y');
            return true;
        }
        //------------------------------------------------------------------------------------------------------
    }
}
