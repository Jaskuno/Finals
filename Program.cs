using System;
using System.Collections.Generic;
namespace BJ
{
    class program
    {
        static List<string> Favorite;
        static string Anime;
        static string fav()
        {
            Favorite = new List<string>();
            Console.Write("Do you want to add it on your Hidden Library(Y/N): ");
            Fav = Console.ReadLine();
            if (Fav.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                Favorite.Add(Anime);
                Console.WriteLine("Successfully added in hidden library!");
            }
            else if (Fav.Equals("N", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine("Error, Invalid!");
            }
            return Fav;
        }
        static void succ()
        {
            Console.WriteLine("Successfully added in your Library!");
        }
        static string Fav;
        static void Main(string[] args)
        {
            string num;
            var Fiction = new List<string>();
            var Actions = new List<string>();
            var Drama = new List<string>();
            var Comedy = new List<string>();
            var Horror = new List<string>();
            do
            {
                Console.WriteLine("\nANIMANGA");
                Console.WriteLine("------------------");
                Console.WriteLine("LIBRARY");
                Console.WriteLine("Enter 1, ADD an Anime or Manga in your library.");
                Console.WriteLine("Enter 2, REMOVE an Anime or Manga in your Library.");
                Console.WriteLine("Enter 3, SEE what Anime or Manga are in your Library.");
                Console.WriteLine("Enter 4, SEE your HIDDEN Anime or Manga.");
                Console.WriteLine("Enter x, exit the program.");
                Console.WriteLine("------------------");
                Console.Write("Enter 1, 2, 3, 4, or x: ");
                num = Console.ReadLine();
                if (num == "1")
                {
                    string Genre;
                    Console.Write("Enter an Anime or Manga to add in Library: ");
                    Anime = Console.ReadLine();
                    Console.WriteLine("Fiction, Action, Drama, Comedy, or Horror.");
                    Console.Write("Enter what is its main genre: ");
                    Genre = Console.ReadLine();
                    if (Genre.Equals("Fiction", StringComparison.OrdinalIgnoreCase))
                    {
                        fav();
                        if (Fav.Equals("N", StringComparison.OrdinalIgnoreCase))
                        {
                            Fiction.Add(Anime);
                            succ();
                        }
                    }
                    else if (Genre.Equals("Action", StringComparison.OrdinalIgnoreCase))
                    {
                        fav();
                        if (Fav.Equals("N", StringComparison.OrdinalIgnoreCase))
                        {
                            Actions.Add(Anime);
                            succ();
                        }
                    }
                    else if (Genre.Equals("Drama", StringComparison.OrdinalIgnoreCase))
                    {
                        fav();
                        if (Fav.Equals("N", StringComparison.OrdinalIgnoreCase))
                        {
                            Drama.Add(Anime);
                            succ();
                        }

                    }
                    else if (Genre.Equals("Comedy", StringComparison.OrdinalIgnoreCase))
                    {
                        fav();
                        if (Fav.Equals("N", StringComparison.OrdinalIgnoreCase))
                        {
                            Comedy.Add(Anime);
                            succ();
                        }

                    }
                    else if (Genre.Equals("Horror", StringComparison.OrdinalIgnoreCase))
                    {
                        fav();
                        if (Fav.Equals("N", StringComparison.OrdinalIgnoreCase))
                        {
                            Horror.Add(Anime);
                            succ();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid Genre!");
                    }
                }
                else if (num == "2")
                {
                    string Anim;
                    string GENRE;
                    Console.Write("Enter an Anime or Manga you want to remove: ");
                    Anim = Console.ReadLine();
                    Console.Write("Enter its Genre or [hidden] if it is hidden: ");
                    GENRE = Console.ReadLine();
                    if (GENRE.Equals("Fiction", StringComparison.OrdinalIgnoreCase))
                    {
                        Fiction.Remove(Anim);
                        Console.WriteLine("Successfully removed!\n");
                    }
                    else if (GENRE.Equals("Action", StringComparison.OrdinalIgnoreCase))
                    {
                        Actions.Remove(Anim);
                        Console.WriteLine("Successfully removed!\n");
                    }
                    else if (GENRE.Equals("Drama", StringComparison.OrdinalIgnoreCase))
                    {
                        Drama.Remove(Anim);
                        Console.WriteLine("Successfully removed!\n");
                    }
                    else if (GENRE.Equals("Comedy", StringComparison.OrdinalIgnoreCase))
                    {
                        Comedy.Remove(Anim);
                        Console.WriteLine("Successfully removed!\n");
                    }
                    else if (GENRE.Equals("Horror", StringComparison.OrdinalIgnoreCase))
                    {
                        Horror.Remove(Anim);
                        Console.WriteLine("Successfully removed!\n");
                    }
                    else if (GENRE.Equals("Hidden", StringComparison.OrdinalIgnoreCase))
                    {
                        Favorite.Remove(Anim);
                        Console.WriteLine("Successfully removed!\n");
                    }
                    else
                    {
                        Console.WriteLine("The Manga or Anime is nowhere to be found...");
                    }
                }
                else if (num == "3")
                {
                    string genre;
                    Console.Write("Enter what Genre you want to see: ");
                    genre = Console.ReadLine();
                    if (genre.Equals("Fiction", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("List of Anime or Manga in your Library: ");
                        foreach (var item in Fiction)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else if (genre.Equals("Action", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("List of Anime or Manga in your Library: ");
                        foreach (var item in Actions)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else if (genre.Equals("Drama", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("List of Anime or Manga in your Library: ");
                        foreach (var item in Drama)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else if (genre.Equals("Comedy", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("List of Anime or Manga in your Library: ");
                        foreach (var item in Comedy)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else if (genre.Equals("Horror", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("List of Anime or Manga in your Library: ");
                        foreach (var item in Horror)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid, Genre!");
                    }
                }
                else if (num == "4")
                {
                    Console.Write("Enter the password: ");
                    string pass = Console.ReadLine();
                    if (pass.Equals("Password", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("List of your Hidden Anime or Manga: ");
                        foreach (var item in Favorite)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }

                else if (num == "x" || num == "X")
                {
                    Console.WriteLine("Exiting Program.");
                }
                else
                {
                    Console.WriteLine("Error, INVALID!");
                }
            }
            while (num == "1" || num == "2" || num == "3" || num == "4");
        }
    }
}