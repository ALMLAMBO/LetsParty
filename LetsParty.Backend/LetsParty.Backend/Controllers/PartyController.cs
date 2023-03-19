using LetsParty.Backend.Services.Item;
using LetsParty.Backend.Services.Party;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LetsParty.Backend.Controllers {
	[Route("api/[controller]/")]
	[ApiController]
	public class PartyController : ControllerBase {
		private readonly IPartyService partyService;

		public PartyController(IPartyService partyService) {
			this.partyService = partyService;
		}

		[HttpGet("all")]
		public ActionResult<List<Models.Party>> All() {
			return partyService.All();
		}

		[HttpGet("{id}")]
		public ActionResult<Models.Party> GetItem(int id) {
			return partyService.Get(id);
		}

		[HttpPost("create-item")]
		public ActionResult<Models.Party> CreateItem([FromBody] Models.Party item) {
			return partyService.Create(item);
		}

		[HttpPut("{id}/update")]
		public ActionResult<Models.Party> UpdateItem(int id, [FromBody] Models.Party item) {
			return partyService.Update(item);
		}

		[HttpDelete("{id}/delete")]
		public ActionResult<Models.Party> DeleteItem(int id) {
			return partyService.Delete(id);
		}
	}
}
