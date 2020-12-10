using System;

namespace FindNumbersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            FindNumbersInString();
        }
        static void FindNumbersInString()
        {
            string sentence = "10 cats, 20 dogs, 40 fish and 1 programmer.";

            string w;
            int c = 0;
            string[] digits = System.Text.RegularExpressions.Regex.Split(sentence, @"\D+");
            foreach (string item in digits)
            {
                int number;
                if (int.TryParse(item, out number))
                {
                    Console.WriteLine(number);
                }
            }

        }
    }
}
