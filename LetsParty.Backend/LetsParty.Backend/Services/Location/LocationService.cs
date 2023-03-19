using LetsParty.Backend.Models;
using Microsoft.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;

namespace LetsParty.Backend.Services.Location
{
    public class LocationService : ILocationService
    {
        private readonly LetsPartyDbContext _context;

        public LocationService(LetsPartyDbContext context)
        {
            _context = context;
        }
        public List<Models.Location> All()
        {
            return _context.Locations.ToList();
        }

        public Models.Location Create(Models.Location location)
        {
            _context.Locations.Add(location);
            _context.SaveChanges();

            return location;
        }

        public Models.Location Delete(int id)
        {
            Models.Location location = _context.Locations
                .Where(x => x.LocationId == id)
                .FirstOrDefault();

            _context.Remove(location);
            _context.SaveChanges();

            return location;
        }

        public Models.Location Get(int id)
        {
            return _context.Locations
                .Where(x => x.LocationId == id)
                .FirstOrDefault();
        }

        public List<Models.Location> GetLocationsForParty(int partyId)
        {
            return _context.Parties.Where(x => x.PartyId == partyId).SelectMany(p => p.Locations).ToList();
        }

        public Models.Location Update(Models.Location location)
        {
            Models.Location locationToUpdate = _context.Locations
                .Where(x => x.LocationId == location.LocationId)
                .FirstOrDefault();

            locationToUpdate = location;

            _context.Locations.Update(locationToUpdate);
            _context.SaveChanges();

            return location;
        }
    }
}
