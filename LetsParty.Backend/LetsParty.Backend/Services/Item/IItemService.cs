namespace LetsParty.Backend.Services.Item
{
    public interface IItemService
    {
        public List<Models.Item> All();
        public Models.Item Get(int id);
        public Models.Item Create(Models.Item item);
        public Models.Item Update(Models.Item item);
        public Models.Item Delete(int id);

        public List<Models.Item> GetItemsForParty(int partyId);
    }
}
