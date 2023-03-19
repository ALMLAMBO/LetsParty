namespace LetsParty.Backend.Services.Location {
	public interface ILocationService {
		public List<Models.Location> All();
		public Models.Location Get(int id);
		public Models.Location Create(Models.Location location);
		public Models.Location Update(Models.Location location);
		public Models.Location Delete(int id);

		public List<Models.Location> GetLocationsForParty(int partyId);
	}
}
