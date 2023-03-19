using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsParty.Backend.Models {
	public class Party {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PartyId { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public bool IsHome { get; set; }

		[Required]
		public bool IsPrivate { get; set; }

		[Required]
		public DateTime StartTime { get; set; }

		[Required]
		public string Duration { get; set; }

		[Required]
		public int Limit { get; set; }

		public ICollection<Item> Items { get; set; }
		public ICollection<Location> Locations { get; set; }
		public ICollection<User> Users { get; set; }
		public ICollection<Game> Games { get; set; }
		public ICollection<PartyInvite> PartyInvites { get; set; }
	}
}
