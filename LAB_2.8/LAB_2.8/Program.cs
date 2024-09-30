Console.Write("Введіть довжину сторони a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введіть довжину сторони b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введіть довжину сторони c: ");
double c = double.Parse(Console.ReadLine());

if (a >= b && a >= c)
{
    Console.WriteLine("Сторона a є найдовшою");
}
else if (b >= a && b >= c)
{
    Console.WriteLine("Сторона b є найдовшою");
}
else
{
    Console.WriteLine("Сторона c є найдовшою");
}
