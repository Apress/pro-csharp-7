using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.ModelBinding;
using System.Web.UI;
using AutoLotDAL.Models;
using AutoLotDAL.Repos;

public partial class InventoryPage : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public IQueryable<Inventory> GetData2([Control("cboMake")]string make)
    {
        var inventoryRepo = new InventoryRepo();
        return string.IsNullOrEmpty(make) ? 
            inventoryRepo.GetAll().AsQueryable() : 
            inventoryRepo.GetAll().Where(x => x.Make == make).AsQueryable();
    }

    public void Delete(int carId, byte[] timeStamp)
    {
        new InventoryRepo().Delete(carId, timeStamp);
    }

    public async void Update(Inventory inventory)
    {
        if (ModelState.IsValid)
        {
            await new InventoryRepo().SaveAsync(inventory);
        }
    }
    public IQueryable<Inventory> GetData([Control("cboMake")]string make="") => 
        string.IsNullOrEmpty(make) ? 
        new InventoryRepo().GetAll().AsQueryable() : 
        new InventoryRepo().GetAll().Where(x => x.Make == make).AsQueryable();

    public IEnumerable GetMakes() => 
        new InventoryRepo().GetAll().Select(x => new {x.Make}).Distinct();
}