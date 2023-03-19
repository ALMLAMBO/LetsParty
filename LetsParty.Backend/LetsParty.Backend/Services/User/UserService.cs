using Microsoft.AspNetCore.Mvc;

namespace LetsParty.Backend.Services.User {
	public class UserService : IUserService {
		
		
		public ActionResult<Models.User> CreateUser(Models.User user) {
			throw new NotImplementedException();
		}

		public ActionResult<Models.User> DeleteUser(int id) {
			throw new NotImplementedException();
		}

		public List<Models.User> GetAll() {
			throw new NotImplementedException();
		}

		public Models.User GetUser(int id) {
			throw new NotImplementedException();
		}

		public ActionResult<Models.User> UpdateUser(Models.User user) {
			throw new NotImplementedException();
		}
	}
}
