using Microsoft.AspNetCore.Mvc;

namespace LetsParty.Backend.Services.User {
	public interface IUserService {
		public List<Models.User> GetAll();
		public Models.User GetUser(int id);
		public Models.User CreateUser(Models.User user);
		public Models.User UpdateUser(Models.User user);
		public Models.User DeleteUser(int id);
	}
}
