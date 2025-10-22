namespace CourseCSharpMasterClass.section1;

public class UsingDecimalNumbersInsteadWithDouble
{
    public static void Run() 
    {
        double firstNumber = 0.0;
        double secondNumber = 0.0;

        Console.WriteLine("Enter a first number! ");
        string userInput = Console.ReadLine()!;
        firstNumber = double.Parse(userInput);

        Console.WriteLine("Enter a second number! ");
        userInput = Console.ReadLine()!;
        secondNumber = double.Parse(userInput);

        double sum = firstNumber + secondNumber;
        Console.WriteLine($"The result of {firstNumber} + {secondNumber} is {sum}");
        Console.ReadKey();
    }
}
