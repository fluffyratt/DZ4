using Microsoft.Extensions.Logging;

namespace MauiApp1
{
    public class Product
    {
        public double Price { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Name { get; set; }
        public DateTime PackagingDate { get; set; }
        public string Description { get; set; }
    }
    public class GroceryProduct : Product
    {
        public TimeSpan ExpiryPeriod { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasurement { get; set; }
    }
    public class Book : Product
    {
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public List<string> Authors { get; set; }
    }











}
