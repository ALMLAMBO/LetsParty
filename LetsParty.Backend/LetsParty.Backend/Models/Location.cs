using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsParty.Backend.Models {
	public class Location {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int LocationId { get; set; }

		[Required]
		public string Address { get; set; }

		public ICollection<Party> Parties { get; set; }
	}
}
