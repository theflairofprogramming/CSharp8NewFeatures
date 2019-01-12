using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Console;

namespace AsynchronousStreams
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await foreach (var length in GetCharactersAsync())
            {
                WriteLine(length);
            }

            WriteLine("Press ENTER to exit...");
            ReadLine();
        }

        private static async IAsyncEnumerable<int> GetCharactersAsync()
        {
            HttpClient client = new HttpClient();

            string[] characters = {
                "Daenerys Targaryen", "Eddard Stark", "Catelyn Stark", "Jon Snow", "Sansa Stark", "Arya Stark", "Robb Stark", "Jaime Lannister", "Cersei Lannister"
            };

            foreach (var character in characters)
            {
                var result = await client.GetAsync($"https://www.google.com/search?q={character}");

                var content = await result.Content.ReadAsStringAsync();

                yield return content.Length;
            }
        }
    }
}
