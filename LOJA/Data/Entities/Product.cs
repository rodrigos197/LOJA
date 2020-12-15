using System;
using System.ComponentModel.DataAnnotations;

namespace LOJA.Data.Entities
{
	public class Product
	{
		public int Id { get; set; }


		public string Name { get; set; }

		[DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
		public decimal Price { get; set; }

		[Display(Name = "Image")]
		public string ImageURL { get; set; }

		[Display(Name = "Last Purchase")]
		public DateTime LastBuy { get; set; }

		[Display(Name = "Last Sale")]
		public DateTime LastSell { get; set; }

		[Display(Name = "Available")]
		public bool Available { get; set; }

		[DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
		public double Stock { get; set; }
	}
}
