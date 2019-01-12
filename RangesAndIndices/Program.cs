using System;
using static System.Console;

namespace RangesAndIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] characters = {
                "Daenerys Targaryen", "Eddard Stark", "Catelyn Stark", "Jon Snow", "Sansa Stark", "Arya Stark", "Robb Stark", "Jaime Lannister", "Cersei Lannister"
            };

            WriteLine("Stark Family:");

            foreach (var character in characters[1..7])
            {
                WriteLine(character);
            }

            WriteLine();
            WriteLine("Starks which are alive:");

            Range range = 3..^3;
            foreach (var character in characters[range])
            {
                WriteLine(character);
            }


            WriteLine();
            WriteLine("Lannister Family:");

            range = ^2..;
            foreach (var character in characters[range])
            {
                WriteLine(character);
            }

            ReadLine();
        }
    }
}
