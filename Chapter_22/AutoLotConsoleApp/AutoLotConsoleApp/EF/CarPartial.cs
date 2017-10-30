using System;

namespace AutoLotConsoleApp.EF
{
	public partial class Car
	{
		public override string ToString()
		{
			// Since the PetName column could be empty, supply
			// the default name of **No Name**.
			return $"{this.CarNickName ?? "**No Name**"} is a {this.Color} {this.Make} with ID {this.CarId}.";
		}
	}
}