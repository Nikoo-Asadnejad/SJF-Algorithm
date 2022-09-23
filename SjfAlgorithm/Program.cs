using Microsoft.Extensions.DependencyInjection;
using SjfAlgorithm.Interface;
using SjfAlgorithm.Model;
using SjfAlgorithm.Service;


void Run()
{
    IScheduler scheduler = new Scheduler();
    IList<Process> processList = new List<Process>();
    var counter = 1;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Enter Your Processes");
    Console.ResetColor();
    Console.WriteLine();

    while (true)
    {
        
        string name;
        int executionTime;
       

        Console.WriteLine($"Enter Process {counter} Name : ");
        name = Console.ReadLine();

        Console.WriteLine($"Enter Process {counter} ExecutionTime : ");
        executionTime =int.Parse( Console.ReadLine());

        Process process = new (name,executionTime);
        processList.Add(process);

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Press Enter To Add another Process Or Press f1 To Execute.");
        Console.ResetColor();
        Console.WriteLine();

        counter++;
        var key  = Console.ReadKey().Key;
        if(key == ConsoleKey.F1)
        {
            Console.Clear();
            scheduler.ExecuteProcesses(processList);
            Console.ReadKey();
            break;
        }

        
    }
 
}


Run();

