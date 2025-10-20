namespace CourseCSharpMasterClass.section1;

public class FinalizingOurAdditionCalculator
{
    public static void Run()
    {
        int firstNumber = 0;
        int secondNumber = 0;

        Console.WriteLine("Enter a whole number!");

        string userInput = Console.ReadLine()!;
        firstNumber = int.Parse(userInput);

        Console.WriteLine("Enter a whole number!");
        userInput = Console.ReadLine()!;
        secondNumber = int.Parse(userInput);

        int sum = firstNumber + secondNumber;

        Console.WriteLine($"The result of {firstNumber} + {secondNumber} is {sum}");
        Console.ReadKey();
    }
}
