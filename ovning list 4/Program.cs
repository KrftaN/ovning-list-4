using System;

namespace övning_list._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings1 = { "hej", "nej", "ja" };
            char char1 = 'j';
            Console.WriteLine($"Finns '{char1}' i alla strängar? {FinnsTecknetIAllaSträngar(strings1, char1)}");

            string[] strings2 = { "hej", "nej", "ja" };
            char char2 = 'e';
            Console.WriteLine($"Finns '{char2}' i alla strängar? {FinnsTecknetIAllaSträngar(strings2, char2)}");
        }

        static bool FinnsTecknetIAllaSträngar(string[] strings, char character)
        {
            foreach (string str in strings)
            {
                if (!str.Contains(character))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
