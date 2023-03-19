using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace LetsParty.Backend.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase {
		private readonly LetsPartyDbContext _context;

		public UserController(LetsPartyDbContext context) { 
			_context = context;
		}
		
		[HttpGet]
		public ActionResult<List<Models.User>> Get() {
			return _context.Users.ToList();	
		}
	}
}
