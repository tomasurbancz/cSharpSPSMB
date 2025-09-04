using System;
using System.Collections.Generic;

namespace setup
{
    public class Kalkulacka
    {
        public Kalkulacka()
        {
            List<string> tokens = Tokenize("5     + 1   ");
            foreach (var s in tokens)
            {
                Console.WriteLine(s);
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