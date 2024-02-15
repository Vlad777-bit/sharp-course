using System;

class Program
{
	static void Main()
	{
		int firstYear = 2023;
		int secondYear = 2024;

		int task1 = GetNumberOfLeapYears(firstYear, secondYear);
		int task2 = GetSumDivisibleBy(3, 5);

		double task3 = GetCalculateY(5.0);
		double task4 = GetCalculateK(0.3);
		bool task5 = IsOutsideRanges(5); // если больше 5 то значение True

		Console.WriteLine($"Результат выполнения задачи №1 {task1}");
		Console.WriteLine($"Результат выполнения задачи №2 {task2}");
		Console.WriteLine($"Результат выполнения задачи №3 {task3}");
		Console.WriteLine($"Результат выполнения задачи №4 {task4}");
		Console.WriteLine($"Результат выполнения задачи №5 {task5}");
	}

	// Найти количество високосных лет на отрезке [a, b] не используя циклы
	static int GetNumberOfLeapYears(int a, int b)
	{
		int countBy4 = b / 4 - (a - 1) / 4;
		int countBy100 = b / 100 - (a - 1) / 100;
		int countBy400 = b / 400 - (a - 1) / 400;

		return countBy4 - countBy100 + countBy400;
	}

	// Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.
	static int GetSumDivisibleBy(int number, int limit)
    {
        return number * (limit / number) * ((limit / number) + 1) / 2;
    }

	// Создать метод, возвращающий значение функции
	static double GetCalculateY(double x)
    {
        return Math.Cbrt(Math.Sin(x + 5));
    }

	// Создать метод, возвращающий значение функции
	static double GetCalculateK(double x)
    {
        double numerator = Math.Pow(Math.Sqrt(3) + x, 6) - Math.Log(x);
        double denominator = 1 + Math.Asin(6 * x * x);

        return numerator / denominator;
    }

	/* Используя среду разработки MS Visual Studio и язык программирования C#, создать консольный проект, содержащий
    метод, возвращающий значение логического типа, для проверки следующего утверждения: x лежит вне отрезков [2; 5] и [-1; 1]. */
	static bool IsOutsideRanges(double x)
    {
        return (x < -1 || x > 1) && (x < 2 || x > 5);
    }
}
