using LetsParty.Backend.Services.Item;
using LetsParty.Backend.Services.PartyInvite;
using LetsParty.Backend.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LetsParty.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartyInviteController : ControllerBase
    {
        private readonly IPartyInviteService service;

        public PartyInviteController(IPartyInviteService service)
        {
            this.service = service;
        }

        [HttpGet("{id}")]
        public ActionResult<Models.PartyInvite> GetPartyInvite(int id)
        {
            return service.Get(id);
        }

        [HttpPost("sent")]
        public ActionResult<Models.PartyInvite> CreatePartyInvite([FromBody] Models.PartyInvite partyInvite)
        {
            return service.Sent(partyInvite);
        }

        [HttpPut("{id}/accept")]
        public ActionResult<Models.PartyInvite> UpdatePartyInvite(int id, [FromBody] Models.PartyInvite partyInvite)
        {
            return service.Accept(id);
        }

        [HttpDelete("{id}/decline")]
        public ActionResult<Models.PartyInvite> DeletePartyInvite(int id)
        {
            return service.Decline(id);
        }
    }
}
