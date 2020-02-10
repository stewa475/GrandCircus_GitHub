using System;
using System.Collections.Generic;

namespace LAB_4._2_Movies
{
    class Program
    {
        //------------------------------------------------------------------------------------------------------
        //----------------------------------------- MAIN -------------------------------------------------------
        //------------------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("TheDarkKnight", "Drama", 2008, 94, 94));
            movies.Add(new Movie("TheMatrix", "Fantasy", 1999, 88, 85));
            movies.Add(new Movie("PulpFiction", "Drama", 1994, 92, 96));
            movies.Add(new Movie("StarWars", "Fantasy", 1977, 93, 96));
            movies.Add(new Movie("Psycho", "Horror", 1960, 96, 95));
            movies.Add(new Movie("Frozen", "Animated", 2013, 90, 85));
            movies.Add(new Movie("HappyGilmore", "Comedy", 1996, 61, 85));
            movies.Add(new Movie("Aladdin", "Animated", 1992, 95, 92));
            movies.Add(new Movie("Jaws", "Horror", 1975, 98, 90));
            movies.Add(new Movie("TheLordOfTheRings", "Fantasy", 2001, 91, 95));
            movies.Add(new Movie("ComingToAmerica", "Comedy", 1988, 67, 85));
            movies.Add(new Movie("TheGodfather", "GOAT", 1972, 98, 98));

            SortList(movies);

            do
            {
                Console.WriteLine("====== Movie Categories ======");
                Console.WriteLine("------------------------------");
                for (int i = 0; i < GetCategoryList(movies).Count; i++)
                {
                    Console.WriteLine($"   {i + 1}. {GetCategoryList(movies)[i]}");
                }
                Console.WriteLine("------------------------------\n");

                int input;
                bool worked;
                do
                {
                    Console.Write("Enter a movie category number: ");
                    worked = int.TryParse(Console.ReadLine(), out input);
                    if (worked == true && (input >= 1 && input <= GetCategoryList(movies).Count))
                    {
                        Console.WriteLine($"\n{GetCategoryList(movies)[input - 1]} MOVIE LIST:");
                        Console.WriteLine("--------------------");
                        foreach (Movie m in movies)
                        {
                            if (m.Category == GetCategoryList(movies)[input - 1])
                            {
                                Console.WriteLine(m.ToString());
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nYou must enter one of the categories by number..\n");
                    }
                } while (true);

            } while (RunAgain());
        }
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------
        //---------------------------------------- CATEGORY LIST -----------------------------------------------
        //------------------------------------------------------------------------------------------------------
        public static List<string> GetCategoryList(List<Movie> movies)
        {
            List<string> category = new List<string>();
            foreach (Movie m in movies)
            {
                if (!category.Contains(m.Category))
                {
                    category.Add(m.Category);
                }            
            }
            return category;
        }
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------
        //--------------------------------- Sorts List -------------------------------------
        //------------------------------------------------------------------------------------------------------
        public static void SortList(List<Movie> movies)
        {
            movies.Sort(delegate(Movie m1, Movie m2) 
            { 
                return m1.Title.CompareTo(m2.Title); 
            });
        }
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------
        //--------------------------- PROMPTS USER IF THEY WANT TO CONTINUE ------------------------------------
        //------------------------------------------------------------------------------------------------------
        public static bool RunAgain()
        {
            char c;
            do
            {
                Console.Write("\nWould you like to continue? (y/n): ");
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
    }
}
