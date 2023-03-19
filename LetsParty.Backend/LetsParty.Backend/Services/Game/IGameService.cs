namespace LetsParty.Backend.Services.Game {
	public interface IGameService {
		public List<Models.Game> All();
		public Models.Game Get(int id);
		public Models.Game Create(Models.Game location);
		public Models.Game Update(Models.Game location);
		public Models.Game Delete(int id);

		public List<Models.Game> GetGamesForParty(int partyId);
	}
}
