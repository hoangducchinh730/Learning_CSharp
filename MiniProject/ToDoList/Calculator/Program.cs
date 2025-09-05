

Console.WriteLine("Hello.");

Console.Write("Input the first number: ");
var firstNumber = double.Parse(Console.ReadLine());

Console.Write("Input the second number: ");
var secondNumber = double.Parse(Console.ReadLine());


Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers.");
Console.WriteLine("[S]ubstract numbers.");
Console.WriteLine("[M]ultiply numbers.");

var userChoice = Console.ReadLine().ToUpper();

if (EqualsCaseInsensitive(userChoice, "A"))
{
    var sum = firstNumber + secondNumber;
    PrintFinalResult(firstNumber, secondNumber, sum, "+");
}
else if (EqualsCaseInsensitive(userChoice, "S"))
{
    var difference = firstNumber + secondNumber;
    PrintFinalResult(firstNumber, secondNumber, difference, "-");
}
else if (EqualsCaseInsensitive(userChoice, "M"))
{
    var product = firstNumber * secondNumber;
    PrintFinalResult(firstNumber, secondNumber, product, "*");
}
else
{
    Console.WriteLine("Invalid choice.");
}


Console.WriteLine("Press any key to close.");
Console.ReadKey();

void PrintFinalResult(double firstNumber, double secondNumber, double result, string @operator)
{
    Console.WriteLine($"{firstNumber} {@operator} {secondNumber} = {result}");
}

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}