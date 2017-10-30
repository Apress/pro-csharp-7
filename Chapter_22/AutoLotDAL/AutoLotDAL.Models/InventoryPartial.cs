using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLotDAL.Models
{
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