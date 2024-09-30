int num1, num2, num3;

Console.Write("Введіть перше число: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Введіть друге число: ");
num2 = int.Parse(Console.ReadLine());

Console.Write("Введіть третє число: ");
num3 = int.Parse(Console.ReadLine());

int max = Math.Max(num1, Math.Max(num2, num3));

Console.WriteLine("Максимальне число: " + max);