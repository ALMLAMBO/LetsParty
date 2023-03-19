using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace LetsParty.Backend.Controllers {
	[Route("api/[controller]/")]
	[ApiController]
	public class UserController : ControllerBase {
		private readonly LetsPartyDbContext _context;

		public UserController(LetsPartyDbContext context) { 
			_context = context;
		}
		
		[HttpGet("all")]
		public ActionResult<List<Models.User>> Get() {
			return _context.Users.ToList();	
		}

		[HttpGet("{id}")]
		public ActionResult<Models.User> GetUser(int id) {
			return _context.Users
				.Where(x => x.Id == id)
				.FirstOrDefault();
		}

		[HttpPost("add")]
		public ActionResult CreateUser([FromBody] Models.User user) {
			if(!ModelState.IsValid) {
				return BadRequest();
			}

			_context.Users.Add(user);
			_context.SaveChanges();

			return Ok();
		}

		[HttpPut("{id}/update")]
		public ActionResult<Models.User> Update([FromBody] Models.User user, int id) {
			if(!ModelState.IsValid) {
				return BadRequest();
			}

			Models.User userToUpdate = _context.Users
				.Where(x => x.Id == id)
				.FirstOrDefault();

			_context.Users.Update(user);
			_context.SaveChanges();

			return Ok();
		}

		[HttpDelete("{id}/delete")]
		public ActionResult Delete(int id) { 
			if(!ModelState.IsValid) {
				return BadRequest();
			}

			Models.User user = _context.Users
				.Where(x => x.Id == id)
				.FirstOrDefault();

			_context.Remove(user);
			_context.SaveChanges();

			return Ok();
		}
	}
}
