using System;
using System.Collections.Generic;

namespace setup
{
    public class Kalkulacka
    {
        public double Calculate(double n1, double n2, string s)
        {
            switch (s)
            {
                case "+":
                {
                    return n1 + n2;
                }
                case "-":
                {
                    return n1 - n2;
                }
                case "*":
                {
                    return n1 * n2;
                }
                case "/":
                {
                    return n1 / n2;
                }
                case "**":
                {
                    return Math.Pow(n1, n2);
                }
            }
            throw new Exception("Špatně zadaný příkaz");
        }

        public string GetText(double n1, double n2, string s)
        {
            try
            {
                return
                    $"{(n1 + "").Replace(",", ".")} {s} {(n2 + "").Replace(",", ".")} = {(Calculate(n1, n2, s) + "").Replace(",", ".")}";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string CalculateEquation(String text)
        {
            List<string> tokens = null;
            try
            {
                tokens = Tokenize(text.Replace(".", ","));
            }
            catch (Exception e)
            {
                return "Špatně zadaný příklad";
            }
            if (tokens.Count != 3)
            {
                return "Špatně zadaný příklad";
            }

            double n1 = 0;
            double n2 = 0;
            try
            {
                n1 = double.Parse(tokens[0]);
                n2 = double.Parse(tokens[2]);
            }
            catch (Exception e)
            {
                return "Špatně zadaný příklad";
            }

            return GetText(n1, n2, tokens[1]);
            
        }
        
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Zadej příklad");
                Console.WriteLine(CalculateEquation(Console.ReadLine()));
            }
        }

        public List<String> Tokenize(string s)
        {
            List<String> tokens = new List<String>();
            string currentToken = "";
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    if (!currentToken.Equals(""))
                    {
                        tokens.Add(currentToken);
                        currentToken = "";
                    }
                }
                else
                {
                    currentToken += chars[i];
                }
            }
            if(!currentToken.Equals("")) tokens.Add(currentToken);
            return tokens;
        }
    }
}