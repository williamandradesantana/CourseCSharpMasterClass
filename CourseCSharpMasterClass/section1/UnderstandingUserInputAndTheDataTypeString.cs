namespace CourseCSharpMasterClass.section1;

public class UnderstandingUserInputAndTheDataTypeString
{
    public static void Run()
    {
        /*
            Variable with name "userInput" and the data type "string"
            string are used for text
         */
        string user = Console.ReadLine()!;

        Console.WriteLine($"You entered: {user}");

        // Prints out whatever is in side of ()
        Console.WriteLine("Enter a first number: ");
        // Takes the user input and stores it
        var firstNumber = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter a second number: ");
        var secondNumber = double.Parse(Console.ReadLine()!);

        var result = firstNumber + secondNumber;
        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: " + result);
    }
}
