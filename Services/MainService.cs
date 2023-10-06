using System;

namespace ApplicationTemplate.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    private readonly IFileService _fileService;
    public MainService(IFileService fileService)
    {
        _fileService = fileService;
    }

    public void Invoke()
    {
        string choice;
        do
        {
            Console.WriteLine("");
            Console.WriteLine("1) Movies");
            Console.WriteLine("2) Videos");
            Console.WriteLine("3) Shows");
            Console.WriteLine("X) Quit");
            Console.WriteLine("");
            choice = Console.ReadLine();
            CollectiveDisplay collectiveDisplay;

            // Logic would need to exist to validate inputs and data prior to writing to the file
            // You would need to decide where this logic would reside.
            // Is it part of the FileService or some other service?
            if (choice == "1")
            {
                collectiveDisplay = new Movie();
                ((Movie)collectiveDisplay).Display();
            }
            else if (choice == "2")
            {
                collectiveDisplay = new Video();
                ((Video)collectiveDisplay).Display();
            }
            else if (choice == "3")
            {
                collectiveDisplay = new Show();
                ((Show)collectiveDisplay).Display();
            }
        }
        while (choice != "X");
    }
}
