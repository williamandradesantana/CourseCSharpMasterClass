namespace CourseCSharpMasterClass.section1;

public class UnderstandingIntNumberDatatypeAndWhyWeCantFitAStringIntoIt
{
    public static void Run()
    {
        // Prints out whatever is in side of ()
        Console.WriteLine("Enter a number!");

        // datatype variableName = initial value;

        int myNumber = 0;
        //myNumber = int.Parse(Console.ReadLine());

        // takes the user input and stores it
        // Variable with the name "userInput" and the data type "string"
        // string are used for text
        string userInput = Console.ReadLine()!;
        myNumber = int.Parse(userInput);
        // We are adding to strings together and writing them onto the console
        Console.WriteLine("You entered: " + userInput);
        Console.ReadKey();
    }
}
