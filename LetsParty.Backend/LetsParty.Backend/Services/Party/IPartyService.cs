namespace LetsParty.Backend.Services.Party
{
    public interface IPartyService
    {
        public List<Models.Party> All();
        public Models.Party Get(int id);
        public Models.Party Create(Models.Party party);
        public Models.Party Update(Models.Party party);
        public Models.Party Delete(int id);

        public List<Models.User> GetGuestsForParty(int partyId);
    }
}
