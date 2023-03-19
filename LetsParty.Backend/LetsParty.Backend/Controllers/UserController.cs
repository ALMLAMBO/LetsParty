using LetsParty.Backend.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace LetsParty.Backend.Controllers {
	[Route("api/[controller]/")]
	[ApiController]
	public class UserController : ControllerBase {
		private readonly IUserService service;

		public UserController(IUserService service) { 
			this.service = service;
		}
		
		[HttpGet("all")]
		public ActionResult<List<Models.User>> Get() {
			return service.GetAll();	
		}

		[HttpGet("{id}")]
		public ActionResult<Models.User> GetUser(int id) {
			return service.GetUser(id);
		}

		[HttpPost("add")]
		public ActionResult CreateUser([FromBody] Models.User user) {
			if(!ModelState.IsValid) {
				return BadRequest();
			}

			service.CreateUser(user);

			return Ok();
		}

		[HttpPut("{id}/update")]
		public ActionResult<Models.User> Update([FromBody] Models.User user, int id) {
			if(!ModelState.IsValid) {
				return BadRequest();
			}

			service.UpdateUser(user);

			return Ok();
		}

		[HttpDelete("{id}/delete")]
		public ActionResult Delete(int id) { 
			if(!ModelState.IsValid) {
				return BadRequest();
			}

			service.DeleteUser(id);

			return Ok();
		}
	}
}
