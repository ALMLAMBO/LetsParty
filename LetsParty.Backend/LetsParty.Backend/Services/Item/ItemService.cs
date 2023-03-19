namespace LetsParty.Backend.Services.Item
{
    public class ItemService : IItemService
    {
        private readonly LetsPartyDbContext _context;

        public ItemService(LetsPartyDbContext context)
        {
            _context = context;
        }
        public List<Models.Item> All()
        {
            return _context.Items.ToList();
        }

        public Models.Item Create(Models.Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Models.Item Delete(int id)
        {
            Models.Item item = _context.Items
               .Where(x => x.ItemId == id)
               .FirstOrDefault();

            _context.Remove(item);
            _context.SaveChanges();

            return item;
        }

        public Models.Item Get(int id)
        {
            return _context.Items
                .Where(x => x.ItemId == id)
                .FirstOrDefault();
        }

        public List<Models.Item> GetItemsForParty(int partyId)
        {
            return _context.Parties.Where(x => x.PartyId == partyId).SelectMany(p => p.Items).ToList();
        }

        public Models.Item Update(Models.Item item)
        {
            Models.Item itemToUpdate = _context.Items
                            .Where(x => x.ItemId == item.ItemId)
                            .FirstOrDefault();

            itemToUpdate = item;

            _context.Items.Update(itemToUpdate);
            _context.SaveChanges();

            return item;   
        }
    }
}
