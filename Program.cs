using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Олег", "Артем", "Ира", "Оля", "Костя", "Яна" };
            string[] shortnames = new string[names.Length];
            int index = 0;

            foreach (string str in names)
            {
                if (str.Length <= 3)
                {
                    shortnames[index] = str;
                    index++;
                }
            }

            Array.Resize(ref shortnames, index);

            foreach (string str in shortnames)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
