using LOJA.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LOJA.Data
{
	public class DataContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Client> Clients { get; set; }


		public DataContext(DbContextOptions<DataContext> options) : base(options) 
		{ }
	}
}
