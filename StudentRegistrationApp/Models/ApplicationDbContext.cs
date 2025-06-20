using System.Data.Entity;

namespace StudentRegistrationApp.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext() : base("DefaultConnection") { }

		public DbSet<Student> Students { get; set; }
	}
}
