
using System;
using System.ComponentModel.DataAnnotations;

namespace LOJA.Data.Entities
{
	public class Client
	{
		public int Id { get; set; }


		public string Name { get; set; }

		[Display(Name = "Currency")]
		[DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
		public decimal Price { get; set; }

		[Display(Name = "Profile")]
		public string ImageURL { get; set; }

		[Display(Name = "Date of Birth")]
		public DateTime LastBuy { get; set; }

		[Display(Name = "Last Sale")]
		public DateTime LastSell { get; set; }

		[Display(Name = "PRO User")]
		public bool Available { get; set; }

		[DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
		public double Hours { get; set; }
	}
}
