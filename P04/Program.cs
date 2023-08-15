namespace P04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(", ").Select(double.Parse).Select(n => n + n * 0.2).ToArray();
            foreach (double number in numbers)
            {
                Console.WriteLine($"{number:F2}");
            }
        }
    }
}