using LetsParty.Backend.Models;
using LetsParty.Backend.Services.Party;

namespace LetsParty.Backend.Services.PartyInvite
{
    public class PartyInviteService : IPartyInviteService
    {
        private readonly LetsPartyDbContext _context;

        public PartyInviteService(LetsPartyDbContext context)
        {
            _context = context;
        }

        public Models.PartyInvite Accept(int id)
        {
            Models.PartyInvite invite = _context.PartyInvites.FirstOrDefault(x => x.PartyId == id);
            Models.User receiver = _context.Users.FirstOrDefault(x => x.UserId == id);
            invite.Party.Users.Add(receiver);

            _context.PartyInvites.Remove(invite);
            _context.SaveChanges();
            return invite;

        }

        public Models.PartyInvite Decline(int id)
        {
            Models.PartyInvite invite = _context.PartyInvites.FirstOrDefault(x => x.PartyId == id);
            _context.PartyInvites.Remove(invite);
            _context.SaveChanges();
            return invite;
        }

        public Models.PartyInvite Get(int id)
        {
            return _context.PartyInvites.Where(x => x.PartyId == id)
                            .FirstOrDefault();
        }

        public Models.PartyInvite Sent(Models.PartyInvite invite)
        {
            _context.PartyInvites.Add(invite);
            _context.SaveChanges();
            return invite;

        }
    }
}
