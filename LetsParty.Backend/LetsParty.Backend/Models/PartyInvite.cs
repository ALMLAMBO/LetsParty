using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsParty.Backend.Models {
	public class PartyInvite {
		[Key, Column(Order = 0)]
		public int PartyId { get; set; }
		[Key, Column(Order = 1)]
		public int OwnerId { get; set; }
		[Key, Column(Order = 2)]
		public int ReceiverId { get; set; }	

		public Party Party { get; set; }
	}
}
