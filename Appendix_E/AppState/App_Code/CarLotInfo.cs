using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class CarLotInfo
{
    public CarLotInfo(string salesPerson, string currentCar, string mostPopular)
    {
        SalesPersonOfTheMonth = salesPerson;
        CurrentCarOnSale = currentCar;
        MostPopularColorOnLot = mostPopular;
    }
    public string SalesPersonOfTheMonth { get; set; }
    public string CurrentCarOnSale { get; set; }
    public string MostPopularColorOnLot { get; set; }
}
