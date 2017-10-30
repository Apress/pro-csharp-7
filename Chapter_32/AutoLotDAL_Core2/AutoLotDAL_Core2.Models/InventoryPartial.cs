using System.ComponentModel.DataAnnotations.Schema;
using AutoLotDAL_Core2.Models.MetaData;
using Microsoft.AspNetCore.Mvc;

namespace AutoLotDAL_Core2.Models
{
    [ModelMetadataType(typeof(InventoryMetaData))]
	public partial class Inventory
	{
		public override string ToString()
		{
			// Since the PetName column could be empty, supply
			// the default name of **No Name**.
			return $"{this.PetName ?? "**No Name**"} is a {this.Color} {this.Make} with ID {this.Id}.";
		}
	    [NotMapped]
	    public string MakeColor => $"{Make} + ({Color})";
    }
}