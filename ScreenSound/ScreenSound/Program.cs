// Screen Sound
string welcomeMessage = "Welcome to Screen Sound";
Dictionary<string, List<int>> listOfBands = new Dictionary<string, List<int>>();


void showWelcomeMessage()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(welcomeMessage);
}

void createBand()
{
    Console.Clear();
    showOptionTitle("Create new Band");
    Console.Write("Enter the name of the band you want to register: ");
    string bandName = Console.ReadLine()!;
    listOfBands.Add(bandName, new List<int>());
    Console.WriteLine($"The band {bandName} was created successfully!");
    Console.Clear();
    Thread.Sleep(1000);
    showMenu();
}
void showListBands()
{
    Console.Clear();
    showOptionTitle("Displaying all bands");

    //for (int i = 0; i < listOfBands.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listOfBands[i]}");
    //}

    foreach (string band in listOfBands.Keys)
    {
        Console.WriteLine($"Banda: {band}");
    }

    Console.WriteLine("\nEnter a key to return to the main menu");
    // any typed key
    Console.ReadKey();
    Console.Clear();
    showMenu();

}

void showOptionTitle(string title)
{
    int numberOfLetters = title.Length;
    string stars = string.Empty.PadLeft(numberOfLetters, '*');
    Console.WriteLine(stars);
    Console.WriteLine(title);
    Console.WriteLine(stars + "\n");
}

void ratingBand()
{
    //enter which band you want to rate
    // if the band exists in the dictionary >> assign a note
    // otherwise, return to the main menu

    Console.Clear();
    showOptionTitle("Rating Band");
    Console.Write("Enter the name of the band you want to rate: ");
    string bandName = Console.ReadLine()!;
    if (listOfBands.ContainsKey(bandName))
    {
        Console.Write($"What rating does the {bandName} deserve: ");
        int rate = int.Parse(Console.ReadLine()!);
        listOfBands[bandName].Add(rate);
        Console.WriteLine($"\nThe rating {rate} was successfully registered for the band {bandName}");
        Thread.Sleep(2000);
        Console.Clear();
        showMenu();
    }
    else
    {
        Console.WriteLine($"\nThe band {bandName} was not found!");
        Console.WriteLine("Enter a key to return to the main menu");
        Console.ReadKey();
        Console.Clear();
        showMenu();
    }
}

void showAverage()
{
    Console.Clear();
    showOptionTitle("Display band average");
    Console.Write("Enter the name of the band you want to display the average: ");
    string bandName = Console.ReadLine()!;
    if (listOfBands.ContainsKey(bandName))
    {
        List<int> rateOfBand = listOfBands[bandName];
        Console.WriteLine($"\nThe average of band {bandName} is {rateOfBand.Average()}.");
        Console.WriteLine("Enter a key to return to the main menu.");
        Console.ReadKey();
        Console.Clear();
        showMenu();

    }
    else
    {
        Console.WriteLine($"\n The band {bandName} was not found.");
        Console.WriteLine("Enter a key to return to the main menu.");
        Console.ReadKey();
        Console.Clear();
        showMenu();
    }

}


void showMenu()
{
    Console.WriteLine("\nEnter 1 to register a band");
    Console.WriteLine("Enter 2 to show all bands");
    Console.WriteLine("Enter 3 to rate a band");
    Console.WriteLine("Enter 4 to display the average of a band");
    Console.WriteLine("Enter -1 to exit");

    Console.Write("\nEnter your option: ");
    string option = Console.ReadLine()!;
    int optionNumber = int.Parse(option);
 
    switch (optionNumber)
    {
        case 1:
            createBand();
            break;
        case 2:
            showListBands();
            break;
        case 3:
            ratingBand();
            break;
        case 4:
            showAverage();
            break;
        case -1:
            Console.WriteLine("Bye :)");
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
 

}

showWelcomeMessage();
showMenu();
