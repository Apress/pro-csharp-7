using System;
using System.Collections.Generic;
using System.Web.UI;
using AutoLotDAL.Models;
using AutoLotDAL.Repos;

namespace CodeBehindPageModel
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Inventory> GetData()
        {
            Trace.Write("Default.aspx","Getting Data");
            return new InventoryRepo().GetAll();
        }
    }
}