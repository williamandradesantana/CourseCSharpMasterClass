namespace CourseCSharpMasterClass.section1;
using System.Globalization;

public class DotsAndCommasWithDoubles
{
    public static void Run()
    {
        double firstNumber = 0.0;
        double secondNumber = 0.0;

        Console.WriteLine("Enter a first number! ");
        string userInput = Console.ReadLine()!;
        firstNumber = double.Parse(userInput, CultureInfo.InvariantCulture);

        Console.WriteLine("Enter a second number! ");
        userInput = Console.ReadLine()!;
        secondNumber = double.Parse(userInput, CultureInfo.InvariantCulture);

        double sum = firstNumber + secondNumber;
        Console.WriteLine($"The result of {firstNumber} + {secondNumber} is {sum}");
        Console.ReadKey();
    }
}
