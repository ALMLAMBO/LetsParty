namespace LetsParty.Backend.Services.Party
{
    public class PartyService : IPartyService
    {
        private readonly LetsPartyDbContext _context;

        public PartyService(LetsPartyDbContext context)
        {
            _context = context;
        }

        public Models.Party AddGuest(int userId, int partyId)
        {
            Models.User guest = _context.Users.FirstOrDefault(u => u.UserId == userId);
            Models.Party partyToUpdate = _context.Parties.FirstOrDefault(p => p.PartyId == partyId);
            partyToUpdate.Users.Add(guest);
            _context.SaveChanges();
            return partyToUpdate;
        }

        public List<Models.Party> All()
        {
            return _context.Parties.ToList();
        }

        public Models.Party Create(Models.Party party)
        {
            _context.Parties.Add(party);
            _context.SaveChanges();
            return party;
        }

        public Models.Party Delete(int id)
        {
            Models.Party party = _context.Parties.FirstOrDefault(x => x.PartyId == id);
            _context.Parties.Remove(party);
            _context.SaveChanges();
            return party;
        }

        public Models.Party Get(int id)
        {
            return _context.Parties.Where(x => x.PartyId == id)
                .FirstOrDefault();
        }

        public List<Models.User> GetGuestsForParty(int partyId)
        {
            return _context.Parties.Where(x => x.PartyId == partyId).SelectMany(p=>p.Users).ToList();
        }

        public Models.Party RemoveGuest(int userId, int partyId)
        {
            Models.User guest = _context.Users.FirstOrDefault(u => u.UserId == userId);
            Models.Party partyToUpdate = _context.Parties.FirstOrDefault(p => p.PartyId == partyId);
            partyToUpdate.Users.Remove(guest);
            _context.SaveChanges();
            return partyToUpdate;
        }

        public Models.Party Update(Models.Party party)
        {
            Models.Party partyToUpdate = _context.Parties
                .Where(x => x.PartyId == party.PartyId)
                .FirstOrDefault();

            partyToUpdate = party;

            _context.Parties.Update(partyToUpdate);
            _context.SaveChanges();

            return party;
        }
    }
}
