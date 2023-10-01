public interface IGeographicalObject
{
    void GetInformation();
}

class Program
{
    static void Main(string[] args)
    {
       
        River river = new River
        {
            XCoordinate = 45.6,
            YCoordinate = 32.4,
            Name = "Amazon River",
            Description = "The largest river in the world.",
            FlowSpeed = 200.5,
            TotalLength = 6575.8
        };

        river.GetInformation();

       
        Mountain mountain = new Mountain
        {
            XCoordinate = 28.3,
            YCoordinate = 39.7,
            Name = "Mount Everest",
            Description = "The highest mountain on Earth.",
            HighestPoint = 8848.86
        };

        mountain.GetInformation();

        Console.ReadKey();
    }
}