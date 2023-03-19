namespace LetsParty.Backend.Services.PartyInvite
{
    public interface IPartyInviteService
    {
        public Models.PartyInvite Sent(Models.PartyInvite invite);
        public Models.PartyInvite Decline(int id);
        public Models.PartyInvite Accept(int id);
        public Models.PartyInvite Get(int id);


    }
}
