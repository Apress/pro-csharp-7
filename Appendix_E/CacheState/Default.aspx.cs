using System;
using System.Collections.Generic;
using System.Web.UI;
using AutoLotDAL.Models;
using AutoLotDAL.Repos;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            carsGridView.DataSource = (IList<Inventory>)Cache["CarList"];
            carsGridView.DataBind();
        }
    }
    protected void btnAddCar_Click(object sender, EventArgs e)
    {
        // Update the Inventory table
        // and call RefreshGrid().
        new InventoryRepo().Add(new Inventory()
        {
            Color = txtCarColor.Text,
            Make = txtCarMake.Text,
            PetName = txtCarPetName.Text
        });
        RefreshGrid();

    }
    private void RefreshGrid()
    {
        carsGridView.DataSource = new InventoryRepo().GetAll();
        carsGridView.DataBind();
    }
}