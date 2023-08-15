using System.Diagnostics.Contracts;

namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> filter = w => char.IsUpper(w[0]);
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(w => filter(w)).ToArray();
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}