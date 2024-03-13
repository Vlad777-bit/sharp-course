namespace dotnet;

// Вариант 20

class Program
{
    static void Main()
    {
        Console.Write("Введите значение k: ");

        int k = Convert.ToInt32(Console.ReadLine());
        double z = CalculateProduct(k);

        Console.WriteLine($"Z = {z}");
    }

    static double CalculateProduct(int k)
    {
        double product = 1;

        for (int j = -4; j <= k; j++)
        {
            double factor = CalculateFactor(k, j);
            if (factor != 0)
            {
                product *= factor;
            }
        }

        return product;
    }

    static double CalculateFactor(int k, int j)
    {
        double numerator = k * (j + 2);
        double denominator = j - 3;

        if (denominator == 0 || double.IsInfinity(denominator))
        {
            return 0;
        }

        double factor = numerator / denominator;
        if (double.IsInfinity(factor) || factor == 0)
        {
            return 0;
        }

        double sum = CalculateSum(k, j);
        if (sum == 0)
        {
            return 0;
        }

        return factor * sum;
    }

    static double CalculateSum(int k, int j)
    {
        double sum = 0;
        for (int i = j; i <= k; i++)
        {
            double sumTerm = CalculateSumTerm(k, i);
            if (sumTerm != 0)
            {
                sum += sumTerm;
            }
        }
        return sum;
    }

    static double CalculateSumTerm(int k, int i)
    {
        double numerator = Math.Sqrt(i + 5);
        double denominator = i - 11 - Math.Pow(k, 5 * i);

        if (denominator == 0 || double.IsInfinity(denominator))
        {
            return 0;
        }

        double sumTerm = numerator / denominator;
        if (double.IsInfinity(sumTerm) || sumTerm == 0)
        {
            return 0;
        }

        return sumTerm;
    }
}
