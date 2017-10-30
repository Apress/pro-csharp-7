using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserShoppingCart
/// </summary>
public class UserShoppingCart
{
    public string DesiredCar { get; set; }
    public string DesiredCarColor { get; set; }
    public float DownPayment { get; set; }
    public bool IsLeasing { get; set; }
    public DateTime DateOfPickUp { get; set; }

    public override string ToString() => 
        $"Car: {DesiredCar}<br>Color: {DesiredCarColor}<br>$ Down: {DownPayment}" + 
        $"<br>Lease: {IsLeasing}<br>Pick-up Date: {DateOfPickUp.ToShortDateString()}";
}
