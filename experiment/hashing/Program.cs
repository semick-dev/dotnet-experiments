
using System;

namespace hashing
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var shorthashResult = ShortHashGenerator.GenerateShortHash("Azure/azure-sdk-for-pythonsdk/tables/assets.json");

            Console.WriteLine($"Short hash result is \"{shorthashResult}\"");

            return 0;
        }
    }
}