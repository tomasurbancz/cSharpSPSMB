using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Files
{
  public interface IFile
  {
    void Save(IEnumerable<Movie> movies);
    
    IEnumerable<Movie> Load(); 
  }
  
  public class JsonFile : IFile
  {
    public JsonFile()
    {

      bool ended = false;
      while (!ended)
      {
        Console.WriteLine("1 - Nacist, 2 - Pridat, 3 - Konvertovat na json");
        string key = Console.ReadKey().KeyChar.ToString();
        Console.WriteLine("\n");
        if (key.Equals("1"))
        {
          List<string> lines = File.ReadAllLines("movies.json").ToList();
          List<Movie> movies = new List<Movie>();
          lines.RemoveAt(0);
          lines.RemoveAt(0);
          lines.RemoveAt(lines.Count - 1);
          lines.RemoveAt(lines.Count - 1);
          foreach (string line in lines)
          {
            string s = MakeToConvertable(line);
            movies.Add(new Movie("s"));
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
          string film = ReadString("Zadej Film: ");
          string genre = ReadString("Zadej Genre: ");
          string studio = ReadString("Zadej Lead Studio: ");
          int score = ReadInt("Zadej Audience score: ");
          float profitability = ReadFloat("Zadej Profitability: ");
          int tomatoes = ReadInt("Zadej Rotten Tomatoes: ");
          float gross = ReadFloat("Zadej Worldwide Gross: ");
          int year = ReadInt("Zadej Year: ");
          List<string> lines = File.ReadAllLines("movies.csv").ToList();
          lines.Add(
            $"{film}, {genre}, {studio}, {score}, {(profitability + "").Replace(",", ".")}, {tomatoes}, {(gross + "").Replace(",", ".")}, {year}");
          File.WriteAllLines("movies.csv", lines);
          ended = true;
        }
        else if (key.Equals("3"))
        {
          SaveToJson();
          ended = true;
        }
        else
        {
          Console.WriteLine("Key is bad");
        }
      }
    }

    public string MakeToConvertable(string s)
    {
      string convertable = "";
      s = s.Trim();
      s = s.Replace("\"", "");
      s = s.Replace("{", "");
      s = s.Replace("}", "");
      for (int i = 0; i < s.Split(',').Length - 1; i++)
      {
        convertable += s.Split(',')[i].Split(':')[1].Trim();
        if (i + 1 < s.Split(',').Length - 1) convertable += ",";
      }
      return convertable;
    }

    public int ReadInt(string text)
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

    public float ReadFloat(string text)
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

    public string ReadString(string text)
    {
      while (true)
      {
        Console.Write(text);
        string txt = Console.ReadLine();
        if (!txt.Trim().Equals("")) return txt.Trim();
        Console.WriteLine("Špatně zadáno!");
      }
    }

    public void SaveToJson()
    {
      string space = "    ";
      List<string> saveLines = new List<string>();
      List<string> lines = File.ReadAllLines("movies.csv").ToList();
      List<string> properties = new List<string>();
      foreach (string line in lines[0].Replace("%", "").Split(','))
      {
        properties.Add(line.Trim());
      }

      saveLines.Add("{");
      saveLines.Add($"{space}{'"'}movies{'"'}: [");
      for (int i = 1; i < lines.Count; i++)
      {
        string line = space + space + "{";
        for (int j = 0; j < properties.Count; j++)
        {
          line += '"';
          line += properties[j];
          line += '"';
          line += ":";
          line += " ";

          if (!IsNumber(lines[i].Split(',')[j].Replace("$", "").Replace(".", ",").Trim())) line += '"';
          line += lines[i].Split(',')[j].Replace("$", "").Replace(",", ".").Trim();
          if (!IsNumber(lines[i].Split(',')[j].Replace("$", "").Replace(".", ",").Trim())) line += '"';
          if (j + 1 < properties.Count) line += ", ";
        }

        line += "}";
        if (i + 1 < lines.Count) line += ",";
        saveLines.Add(line);
      }

      saveLines.Add($"{space}]");

      saveLines.Add("}");
      File.WriteAllLines("movies.json", saveLines);
    }

    public bool IsNumber(string s)
    {
      return float.TryParse(s, out _);
    }

    public void Save(IEnumerable<Movie> movies)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> Load()
    {
      throw new NotImplementedException();
    }
  }
}