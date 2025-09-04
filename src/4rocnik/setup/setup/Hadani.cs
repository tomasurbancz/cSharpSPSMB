using System;

namespace setup
{
    public class Hadani
    {
        
        public Hadani()
        {
            bool guessed = false;
            int spodni = LoadSetting("Zapiš spodní hranici");
            int horni = LoadSetting("Zapiš horní hranici");
            int num = new Random().Next(spodni, horni);
            while (!guessed)
            {
                int guess = LoadNumber();
                if (guess < 0) Console.WriteLine("Špatně zadané číslo");
                else guessed = CheckGuess(guess, num);
            }
        }

        public bool CheckGuess(int guess, int needed)
        {
            if(guess == needed) Console.WriteLine("Uhádnul jsi!");
            if(guess < needed) Console.WriteLine("Je to vyšší číslo");
            if(guess > needed) Console.WriteLine("Je to nižší číslo");
            return guess == needed;
        }
        
        public int LoadSetting(string s)
        {
            int setting = -1;
            while (setting == -1)
            {
                Console.WriteLine(s);
                int num = LoadNumber();
                if(num >= 0) setting = num;
            }
            return setting;
        }

        public int LoadNumber()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}