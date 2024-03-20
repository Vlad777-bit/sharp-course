namespace dotnet;

class Program
{
    static void Main()
    {
        const int height = 7;
        const string tab = "    ";

        for (int i = height; i >= 1; i--)
        {
            for (int j = 3; j <= i; j++)
            {
                Console.Write($"2{tab}");
            }
            Console.WriteLine();

            for (int j = 3; j <= i; j++)
            {
                var numberToPrint = i switch
                {
                    3 => j - 4,
                    4 => j - 3,
                    5 => j - 2,
                    _ => (i % 2 != 0) ? j : j - 1,
                };
                Console.Write($"{numberToPrint}{tab}");
            }
            Console.WriteLine();
        }
    }
}
