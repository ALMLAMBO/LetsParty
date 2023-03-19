using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace LetsParty.Backend {
	public class LetsPartyDbContext : DbContext {
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlite(@"DataSource=db.sqlite3");
		}

		public DbSet<Models.User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Models.User>().ToTable("users");
			modelBuilder.Entity<Models.User>().HasData(
				new Models.User {
					Id = 1,
					Email = "test@test.com",
					Username = "test",
					FirstName = "test",
					LastName = "test",
					Password = "test1234"
				}); ;
		}
	}
}
