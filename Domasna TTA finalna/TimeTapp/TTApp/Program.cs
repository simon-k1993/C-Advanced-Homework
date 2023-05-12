using Domain.Models;
using Services;

MainApp timeTrackingApp = new MainApp();

while (true)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("*** Welcome to the Time Tracking App ***\n");
    Console.ResetColor();
    Console.WriteLine("==============================\n");
    Console.WriteLine("To login an existing user press 1\n");
    Console.WriteLine("To register new user press 2\n");
    Console.WriteLine("To exit press 3\n");
    Console.Write("Your choice: ");
    string option = Console.ReadLine();
    Console.Clear();

    switch (option)
    {
        case "1":
                timeTrackingApp.Login();
                Console.WriteLine();
            break;
        case "2":
            timeTrackingApp.RegisterNewUser();
            Console.WriteLine();
            break;
        case "3":
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Good bye!\n");
            Console.ResetColor();
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter one of the options listed!!!\n");
            Console.ResetColor();
            break;
    }
    if (option == "3")
    {
        break;
    }
}