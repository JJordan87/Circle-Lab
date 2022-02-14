using Lab_Circle_Objects;

bool runProgram = true;

Console.WriteLine("Welcome to the Circle Tester");

while (runProgram)
{
    Console.Write("Enter a radius: ");
    double userInput = double.Parse(Console.ReadLine());
    Circle userCircle = new Circle(userInput);
    Console.WriteLine($"Cicumference: {userCircle.CalculateFormattedCircumference()}");
    Console.WriteLine($"Area: {userCircle.CalculateFormattedArea}");

    Console.WriteLine("Continue? (y/n)");
    string userChoice = Console.ReadLine().ToLower().Trim();

    while (true)
    {
        if(userChoice == "y")
        {
            runProgram = true;
            break;
        }
        else if (userChoice == "n")
        {
            Console.WriteLine("Thank you for using the Circle Tester.");
            runProgram=false;
            break;
        }
        else
        {
            Console.WriteLine("That is not a valid input.");
        }
    }
}
