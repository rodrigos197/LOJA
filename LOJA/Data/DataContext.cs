using LOJA.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LOJA.Data
{
	public class DataContext : DbContext
	{
		public DbSet<Product> Products { get; set; }



		public DataContext(DbContextOptions<DataContext> options) : base(options) 
		{ }
	}
}
