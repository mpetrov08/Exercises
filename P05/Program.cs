namespace P05
{
    public class People
    {
        public People(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<People> list = new List<People>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                People p = new People(tokens[0], int.Parse(tokens[1]));
                list.Add(p);
            }

            string condition = Console.ReadLine();
            int filterValue = int.Parse(Console.ReadLine());    
            Func<People, int, bool> filter = Filter(condition);
            list = list.Where(p => filter(p, filterValue)).ToList();
            string format = Console.ReadLine();
            Action<People> formatter = PrintOption(format);

            foreach (var person in list)
            {
                formatter(person);
            }
            
            Func<People, int, bool> Filter(string condition)
            {
                if (condition == "younger")
                {
                    return (p, age) => p.Age < age;
                }
                else
                {
                    return (p, age) => p.Age >= age;
                }
            }
            
            Action<People> PrintOption(string format)
            {
                if (format == "name")
                {
                    return p => Console.WriteLine(p.Name);
                }
                else if (format == "age")
                {
                    return p => Console.WriteLine(p.Age);
                }
                else
                {
                    return p => Console.WriteLine($"{p.Name} - {p.Age}");
                }
            }
        }
    }
}