using System;

namespace setup
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Fb(i));
            }
        }

        private string Fb(int i)
        {
            string strToReturn = "";
            if (i % 3 == 0)
            {
                strToReturn += "Fizz";
            }
            if (i % 5 == 0)
            {
                strToReturn += "Buzz";
            }

            if (strToReturn.Equals(""))
            {
                return i + "";
            }
            return strToReturn;
        }
    }
}