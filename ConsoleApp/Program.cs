// Task 2.2
using System;
using System.Collections.Generic;
using System.Text;


abstract class Worker
{
    public string Name { get; }
    public string Position { get; }
    public int WorkDay { get; }

    public Worker(string name, string position, int workDay)
    {
        Name = name;
        Position = position;
        WorkDay = workDay;
    }

    public void Call()
    {
        Console.WriteLine($"{Name} is making a call.");
    }

    public void WriteCode()
    {
        Console.WriteLine($"{Name} is writing code.");
    }

    public void Relax()
    {
        Console.WriteLine($"{Name} is relaxing.");
    }

    abstract public void FillWorkDay();
}

class Developer : Worker
{
    public Developer(string name, int workDay) : base(name, "Developer", workDay){}

    public override void FillWorkDay()
    {
        Console.WriteLine($"{Name}'s work day as a Developer:");

        WriteCode();
        Call();
        Relax();
        WriteCode();
    }
}

class Manager : Worker
{
    private Random _random = new Random();

    public Manager(string name, int workDay) : base(name, "Manager", workDay){ }

    public override void FillWorkDay()
    {
        Console.WriteLine($"{Name}'s work day as a Manager:");

        int callsBeforeRelax = _random.Next(1, 11);
        for (int i = 0; i < callsBeforeRelax; i++)
        {
            Call();
        }

        Relax();

        int callsAfterRelax = _random.Next(1, 6);
        for (int i = 0; i < callsAfterRelax; i++)
        {
            Call();
        }
    }
}
class Team
{
    public string TeamName { get; }
    private List<Worker> _workers = new List<Worker>();

    public Team(string teamName)
    {
        TeamName = teamName;
    }

    public void AddWorker(Worker worker)
    {
        _workers.Add(worker);
    }

    public void PrintTeamInfo()
    {
        Console.WriteLine($"Team: {TeamName}");
        Console.WriteLine("Employees:");

        foreach (var worker in _workers)
        {
            Console.WriteLine($"{worker.Name}");
        }
    }

    public void PrintDetailedTeamInfo()
    {
        Console.WriteLine($"Team: {TeamName}");
        Console.WriteLine("Detailed information about employees:");

        foreach (var worker in _workers)
        {
            Console.WriteLine($"{worker.Name} - {worker.Position} - {worker.WorkDay} hours.");
        }
    }
}

public class Program
{
    private static void Main()
    {
        Team team = new Team("Developers");
        bool continueAdding = true;
        while (continueAdding)
        {
            Console.Write("Enter the name of the employee:");
            string name = Console.ReadLine();

            Console.Write("Enter the position of the employee: ");
            string position = Console.ReadLine();

            Console.Write("Enter the number of working hours: ");
            int workDay = int.Parse(Console.ReadLine());

            if (position.ToLower() == "developer")
            {
                Developer developer = new Developer(name, workDay);
                team.AddWorker(developer);
            }
            else if (position.ToLower() == "manager")
            {
                Manager manager = new Manager(name, workDay);
                team.AddWorker(manager);
            }
            else
            {
                Console.WriteLine("The position is not recognized.");
            }

            Console.Write("Add another employee? (yes/no): ");
            string addMore = Console.ReadLine().ToLower();
            continueAdding = (addMore == "yes");
        }
        team.PrintTeamInfo();
        team.PrintDetailedTeamInfo();
    }
}