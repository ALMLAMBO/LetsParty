using LetsParty.Backend.Services.Location;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LetsParty.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService locationService;

        public LocationController(ILocationService locationService)
        {
            this.locationService = locationService;
        }

        [HttpGet("all")]
        public ActionResult<List<Models.Location>> GetAllLocation()
        {
            return locationService.All();
        }

        [HttpGet("{id}")]
        public ActionResult<Models.Location> GetLocation(int id)
        {
            return locationService.Get(id);
        }

        [HttpPost("create-location")]
        public ActionResult<Models.Location> CreateLocation([FromBody] Models.Location location)
        {
            return locationService.Create(location);
        }

        [HttpPut("{id}/update")]
        public ActionResult<Models.Location> UpdateLocation(int id, [FromBody] Models.Location location)
        {
            return locationService.Update(location);
        }

        [HttpDelete("{id}/delete")]
        public ActionResult<Models.Location> DeleteLocation(int id)
        {
            return locationService.Delete(id);
        }
    }
}
