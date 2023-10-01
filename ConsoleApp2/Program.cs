using System;
public abstract class GeographicalObject
{
    public double XCoordinate { get; set; }
    public double YCoordinate { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

   
    public virtual void GetInformation()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Coordinates: ({XCoordinate}, {YCoordinate})");
    }
}


public class River : GeographicalObject
{
    public double FlowSpeed { get; set; }
    public double TotalLength { get; set; }
    
    public override void GetInformation()
    {   
        base.GetInformation();
        
        Console.WriteLine($"Flow Speed: {FlowSpeed} cm/s");
        Console.WriteLine($"Total Length: {TotalLength} units");

    }
}

public class Mountain : GeographicalObject
{
    public double HighestPoint { get; set; }

    public override void GetInformation()
    {
        base.GetInformation();
        Console.WriteLine($"Highest Point: {HighestPoint} units");
    }
}
