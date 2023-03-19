using LetsParty.Backend.Services.Game;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LetsParty.Backend.Controllers {
	[Route("api/[controller]/")]
	[ApiController]
	public class GameController : ControllerBase {
		private readonly IGameService gameService;

		public GameController(IGameService gameService) {
			this.gameService = gameService;
		}

		[HttpGet("all")]
		public ActionResult<List<Models.Game>> GetAllGames() {
			return gameService.All();
		}

		[HttpGet("{id}")]
		public ActionResult<Models.Game> GetGame(int id) {
			return gameService.Get(id);
		}

		[HttpPost("create-game")]
		public ActionResult<Models.Game> CreateGame([FromBody] Models.Game game) {
			return gameService.Create(game);
		}

		[HttpPut("{id}/update")]
		public ActionResult<Models.Game> UpdateGame(int id, [FromBody] Models.Game game) {
			return gameService.Update(game);
		}

		[HttpDelete("{id}/delete")]
		public ActionResult<Models.Game> DeleteGame(int id) {
			return gameService.Delete(id);
		}
	}
}
