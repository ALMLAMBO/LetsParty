using LetsParty.Backend.Models;

namespace LetsParty.Backend.Services.Game {
	public class GameService : IGameService {
		private readonly LetsPartyDbContext _context;

		public GameService(LetsPartyDbContext context) {
			_context = context;
		}

		public List<Models.Game> All() {
			return _context.Games.ToList();
		}

		public Models.Game Create(Models.Game Game) {
			_context.Games.Add(Game);
			_context.SaveChanges();

			return Game;
		}

		public Models.Game Delete(int id) {
			Models.Game game = _context.Games
				.Where(g => g.GameId == id)
				.FirstOrDefault();

			_context.Games.Remove(game);
			_context.SaveChanges();

			return game;
		}

		public Models.Game Get(int id) {
			return _context.Games
				.Where(g => g.GameId == id)
				.FirstOrDefault();
		}

		public List<Models.Game> GetGamesForParty(int partyId) {
			Models.Party party = _context.Parties
				.Where(p => p.PartyId == partyId)
				.FirstOrDefault();

			return _context.Games
				.Where(g => g.Parties.Contains(party))
				.ToList();
		}

		public Models.Game Update(Models.Game game) {
			Models.Game oldGameData = _context.Games
				.Where(g => g.GameId == game.GameId)
				.FirstOrDefault();

			oldGameData = game;
			_context.SaveChanges();

			return game;
		}
	}
}