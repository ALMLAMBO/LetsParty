using System.Security.Cryptography;
using System.Text;

namespace LetsParty.Backend.Services.User {
	public class UserService : IUserService {
		private readonly LetsPartyDbContext _context;

		public UserService(LetsPartyDbContext context) {
			_context = context;
		}

		public Models.User CreateUser(Models.User user) {
			HMACSHA512 hmac = new HMACSHA512();
			byte[] key = hmac.Key;
			user.Password = Encoding.UTF8.GetString(
				hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password)));

			_context.Users.Add(user);
			_context.SaveChanges();

			return user;
		}

		public Models.User DeleteUser(int id) {
			Models.User user = _context.Users
				.Where(x => x.Id == id)
				.FirstOrDefault();

			_context.Remove(user);
			_context.SaveChanges();

			return user;
		}

		public List<Models.User> GetAll() {
			return _context.Users.ToList();
		}

		public Models.User GetUser(int id) {
			return _context.Users
				.Where(x => x.Id == id)
				.FirstOrDefault();
		}

		public Models.User UpdateUser(Models.User user) {
			Models.User userToUpdate = _context.Users
				.Where(x => x.Id == user.Id)
				.FirstOrDefault();

			userToUpdate = user;

			_context.Users.Update(userToUpdate);
			_context.SaveChanges();

			return user;
		}
	}
}
