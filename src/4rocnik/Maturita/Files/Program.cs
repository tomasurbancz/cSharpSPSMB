using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Files
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      bool ended = false;
      while (!ended)
      {
        Console.WriteLine("1 - Nacist, 2 - Pridat");
        string key = Console.ReadKey().KeyChar.ToString();
        Console.WriteLine("\n");
        if (key.Equals("1"))
        {
          List<string> lines = File.ReadAllLines("movies.csv").ToList();
          List<Movie> movies = new List<Movie>();
          lines.RemoveAt(0);
          foreach (string line in lines)
          {
            movies.Add(new Movie(line));
          }

          List<int> years = new List<int>();
          movies.ForEach(movie =>
          {
            if (!years.Contains(movie.Year))
            {
              years.Add(movie.Year);
            }
          });
          years.Sort();
          years.ForEach(i =>
          {
            Movie worstRating = null;
            Movie bestRating = null;
            Movie mostProfitable = null;
            Movie leastProfitable = null;
            float gross = 0;
            int delitel = 0;
            foreach (Movie movie in movies)
            {
              if (movie.Year == i)
              {
                if (worstRating == null) worstRating = movie;
                if (bestRating == null) bestRating = movie;
                if (mostProfitable == null) mostProfitable = movie;
                if (leastProfitable == null) leastProfitable = movie;
                if (movie.AudienceScore < worstRating.AudienceScore) worstRating = movie;
                if (movie.AudienceScore > bestRating.AudienceScore) bestRating = movie;
                if (movie.Profibality < leastProfitable.Profibality) leastProfitable = movie;
                if (movie.Profibality > mostProfitable.Profibality) mostProfitable = movie;
                gross += movie.WorldwideGross;
                delitel++;
              }
            }

            gross /= delitel;
            Console.WriteLine(
              $"\n\nRok: {i}\nNejhur hodnoceny: {worstRating.Film}\nNejlepe hodnoceny: {bestRating.Film}\n" +
              $"Nejvydelavanejsi: {mostProfitable.Film}\nNejmene vydelenecny: {leastProfitable.Film}\n" +
              $"Prumer: {gross}");
          });
          if (years.Count % 2 == 1)
          {
            Console.WriteLine($"\n\nMedian je: {years[years.Count / 2]}");
          }
          else
          {
            Console.WriteLine($"\n\nMedian je: {(years[years.Count / 2] + years[years.Count / 2 + 1]) / 2}");
          }

          ended = true;
        }
        else if (key.Equals("2"))
        {
          Console.Write("Zadej Film: ");
          string film = Console.ReadLine();
          Console.Write("Zadej Genre: ");
          string genre = Console.ReadLine();
          Console.Write("Zadej Lead Studio: ");
          string studio = Console.ReadLine();
          int score = ReadInt("Zadej Audience score: ");
          float profitability = ReadFloat("Zadej Profitability: ");
          int tomatoes = ReadInt("Zadej Rotten Tomatoes: ");
          float gross = ReadFloat("Zadej Worldwide Gross: ");
          int year = ReadInt("Zadej Year: ");
          List<string> lines =  File.ReadAllLines("movies.csv").ToList();
          lines.Add($"{film}, {genre}, {studio}, {score}, {profitability}, {tomatoes}, {gross}, {year}");
          File.WriteAllLines("movies.csv", lines);
          ended = true;
        }
        else
        {
          Console.WriteLine("Key is bad");
        }
      }
    }

    public static int ReadInt(string text)
    {
      while (true)
      {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine().Replace(".", ","), out int num))
        {
          return num;
        }
        Console.WriteLine("Špatně zadáno!");
      }
    }
    
    public static float ReadFloat(string text)
    {
      while (true)
      {
        Console.Write(text);
        if (float.TryParse(Console.ReadLine().Replace(".", ","), out float num))
        {
          return num;
        }
        Console.WriteLine("Špatně zadáno!");
      }
    }
  }
}