Console.Write("Введіть букву: ");
char inputChar = Console.ReadKey().KeyChar;
Console.WriteLine();

bool isVowel = false;

switch (Char.ToLower(inputChar))
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        isVowel = true;
        break;
}
if (isVowel)
{
    Console.WriteLine("Це голосна буква");
}
else
{
    Console.WriteLine("Це приголосна буква");
}
