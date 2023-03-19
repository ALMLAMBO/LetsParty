using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsParty.Backend.Models {
	public class Item {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ItemId { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public int Quantity { get; set; }

		bool Brought { get; set; }

		public ICollection<Party> Parties { get; set; }
	}
}
