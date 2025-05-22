using System.ComponentModel.DataAnnotations;

namespace ProductInventoryAPI.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

		[MaxLength(500)]
		public string Description { get; set; }

		[Required]
		[Range(0, double.MaxValue)]
		public decimal Price { get; set; }

		[Required]
		[Range(0, int.MaxValue)]
		public int QuantityInStock { get; set; }

		[MaxLength(100)]
		public string Category { get; set; }
	}
}
