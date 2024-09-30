int year;

Console.Write("Введіть рік: ");
year = int.Parse(Console.ReadLine());

bool isLeapYear = (year % 4 == 0 && year % 100 != 0);

if (isLeapYear)
{
    Console.WriteLine(year + " є високосним роком");
}
else
{
    Console.WriteLine(year + " не є високосним роком");
}
