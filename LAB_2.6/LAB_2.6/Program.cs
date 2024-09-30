Console.Write("Введіть вік: ");
int age = int.Parse(Console.ReadLine());

if (age >= 12 && age <= 18)
{
    Console.WriteLine("Ти підліток");
}
else
{
    Console.WriteLine("Ти не підліток");
}
