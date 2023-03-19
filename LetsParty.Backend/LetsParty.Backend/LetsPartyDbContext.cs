using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using LetsParty.Backend.Models;

namespace LetsParty.Backend {
	public class LetsPartyDbContext : DbContext {
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlite(@"DataSource=db.sqlite3");
		}

		public DbSet<Models.User> Users { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<Game> Games { get; set; }
		public DbSet<Party> Parties { get; set; }
		public DbSet<PartyInvite> PartyInvites { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Models.User>().ToTable("users");
			modelBuilder.Entity<Models.User>().HasData(
				new Models.User {
					UserId = 1,
					Email = "test@test.com",
					Username = "test",
					FirstName = "test",
					LastName = "test",
					Password = "test1234"
				});

			modelBuilder.Entity<Party>().ToTable("parties");
			modelBuilder.Entity<Game>().ToTable("games");
			modelBuilder.Entity<Item>().ToTable("items");

			modelBuilder.Entity<Party>()
				.HasMany<Location>(p => p.Locations)
				.WithMany(l => l.Parties)
				.UsingEntity(j => j.ToTable("PartiesLocations"));

			modelBuilder.Entity<Party>()
				.HasMany<Item>(p => p.Items)
				.WithMany(i => i.Parties)
				.UsingEntity(j => j.ToTable("PartiesItems"));

			modelBuilder.Entity<Party>()
				.HasMany<Game>(p => p.Games)
				.WithMany(g => g.Parties)
				.UsingEntity(j => j.ToTable("PartiesGames"));

			modelBuilder.Entity<Party>()
				.HasMany<User>(p => p.Users)
				.WithMany(u => u.Parties)
				.UsingEntity(j => j.ToTable("PartiesUsers"));

			modelBuilder.Entity<PartyInvite>().ToTable("party_invites");
			modelBuilder.Entity<PartyInvite>()
				.HasKey(nameof(PartyInvite.PartyId), 
					nameof(PartyInvite.OwnerId),
					nameof(PartyInvite.ReceiverId));


			modelBuilder.Entity<Party>()
				.HasMany<PartyInvite>(p => p.PartyInvites)
				.WithOne(p => p.Party);
		}
	}
}
