using Microsoft.AspNetCore.Mvc;

namespace LetsParty.Backend.Services.User {
	public interface IUserService {
		public List<Models.User> GetAll();
		public Models.User GetUser(int id);
		public ActionResult<Models.User> CreateUser(Models.User user);
		public ActionResult<Models.User> UpdateUser(Models.User user);
		public ActionResult<Models.User> DeleteUser(int id);
	}
}
