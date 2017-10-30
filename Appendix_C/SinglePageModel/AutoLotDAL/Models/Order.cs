using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLotDAL.Models
{
	public partial class Order
	{
		[Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OrderId { get; set; }

		[Required]
		public int CustId { get; set; }

		[Required]
		public int CarId { get; set; }

		[Timestamp]
		public byte[] Timestamp { get; set; }

		[ForeignKey("CustId")]
		public virtual Customer Customer { get; set; }

		[ForeignKey("CarId")]
		public virtual Inventory Car { get; set; }
	}
}
