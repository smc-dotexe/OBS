using System;

namespace OBS_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string filteredString1 = DuplicateChars("dabAcCaCBAcCcaDA");
            Console.WriteLine("filteredString1 = " + filteredString1); // dabCBAcaDA

            string filteredString2 = DuplicateChars("caAB");
            Console.WriteLine("filteredString2 = " + filteredString2); // cB

            string filteredString3 = DuplicateChars("aByYbf");
            Console.WriteLine("filteredString3 = " + filteredString3); // af
        }

        public static string DuplicateChars(string input)
        {   
            if (input.Length == 2)
                return input;

            int y = 1;

            while (y < input.Length)
            {
                int x = y - 1;
                if (input[x] == char.ToLower(input[y]) || input[x] == char.ToUpper(input[y]))
                {
                    string removedDuplicates = input.Remove(x, 2);
                    return DuplicateChars(removedDuplicates);
                }
                y += 1;
            }

            return input;
        }
    }
}
