using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Annotations : System.Web.UI.Page
{
    private Inventory _model = null;
    public void SaveCar(Inventory car)
    {
        if (ModelState.IsValid)
        {
            _model = car;
            //Add new record here 
        }
    }

    public void UpdateCar(int carID)
    {
        Inventory car = new Inventory();
        if (TryUpdateModel(car))
        {
            _model = car; 
            //Update record here
        }
    }

    public Inventory GetCar() => _model;
}