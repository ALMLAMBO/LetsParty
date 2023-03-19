using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsParty.Backend.Models {
	public class Game {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int GameId { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public string Duration { get; set; }

		[Required]
		public int NumberOfPlayers { get; set; }

		public ICollection<Party> Parties { get; set; }
	}
}
