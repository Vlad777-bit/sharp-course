// Используя среду разработки MS Visual Studio и язык программирования C#, написать программы для
// вычисления значения выражения (по вариантам).

// Примечание: все параметры, участвующие в записи выражения, считывать с клавиатуры. Результат
// выводить на экран, используя интерполяцию строк и округление до трех знаков после запятой.

// Вариант №4

// Получаем значения x и y от юзера и конвертируем их в double
Console.Write("Введите число для x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число для y: ");
double y = Convert.ToDouble(Console.ReadLine());

// Высчитываем результат
double numerator = (Math.Sqrt(Math.Pow(2 + y, 2)) + Math.Pow(Math.Sin(y + 5), 2));
double denominator = (Math.Log(x + 1) - Math.Pow(y, 3));
double result = numerator / denominator;

Console.WriteLine($"F = {result:F3}");
