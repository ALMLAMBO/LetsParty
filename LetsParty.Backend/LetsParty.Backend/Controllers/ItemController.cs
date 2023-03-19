using LetsParty.Backend.Models;
using LetsParty.Backend.Services.Game;
using LetsParty.Backend.Services.Item;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LetsParty.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService itemService;

        public ItemController(IItemService itemService)
        {
            this.itemService = itemService;
        }

        [HttpGet("all")]
        public ActionResult<List<Models.Item>> GetAllItems()
        {
            return itemService.All();
        }

        [HttpGet("{id}")]
        public ActionResult<Models.Item> GetItem(int id)
        {
            return itemService.Get(id);
        }

        [HttpPost("create-item")]
        public ActionResult<Models.Item> CreateItem([FromBody] Models.Item item)
        {
            return itemService.Create(item);
        }

        [HttpPut("{id}/update")]
        public ActionResult<Models.Item> UpdateGame(int id, [FromBody] Models.Item item)
        {
            return itemService.Update(item);
        }

        [HttpDelete("{id}/delete")]
        public ActionResult<Models.Item> DeleteGame(int id)
        {
            return itemService.Delete(id);
        }
    }
}
