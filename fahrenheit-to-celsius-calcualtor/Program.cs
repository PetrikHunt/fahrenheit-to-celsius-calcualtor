Console.WriteLine("Emter initial temperature type (F/C): ");
char userInput = Char.Parse(Console.ReadLine());
userInput = char.ToUpper(userInput);


Console.WriteLine("Enter initial value:");
int userValue = Int32.Parse(Console.ReadLine());

switch (userInput)

{
    case 'F':
        ConverToCelsius(userValue);
        break;
    case 'C':
        ConvertToFahrenheit(userValue);
        break;
    default:
        Console.WriteLine("Wrong type!");
        break;
}

static void ConverToCelsius(int userValue)
{
    Console.WriteLine($"{userValue}F is {(userValue - 32) * 5 / 9}C");
}
static void ConvertToFahrenheit(int userValue)
{
    Console.WriteLine($"{userValue}C is {(userValue * 9) / 5 + 32}F");
}