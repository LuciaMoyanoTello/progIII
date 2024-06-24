using TodoItems.ModelsDatabase;

namespace TodoItems.Repository
{
    public interface ITodoItemRepository ///1RO
    {
        List<Item> GetAll();
        int Add(Item item);
        Item Put(Item item);
        bool delete(Guid id);
    }
}
