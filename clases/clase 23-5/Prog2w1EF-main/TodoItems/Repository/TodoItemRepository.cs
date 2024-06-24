using TodoItems.ModelsDatabase;

namespace TodoItems.Repository
{
    public class TodoItemRepository : ITodoItemRepository ///2DO
    {
        //readonly: al ser solo lectura se le pone guion bajo
        private readonly TodoItemsContext _context;
        public TodoItemRepository()
        {
            _context = new TodoItemsContext();
        }
        public int Add(Item item)
        {
            _context.Add(item);
            return _context.SaveChanges(); //Guardar los cambios //devuelve un int
        }

        public bool delete(Guid id)
        {
            //con el FirstOrDefault te sirve porque puede devolver un registro nulo
            //buscar el id
            var entity = _context.Items.FirstOrDefault(x=>x.Id == id);
            _context.Remove(entity);
            var response = _context.SaveChanges();
            if (response != 0) //afecto a una fila
            {
                return true;
            }
            //sino afecto a una sola fila
            return false;
        }

        public List<Item> GetAll()
        {
            //Devuelve una lista de items //va a traer todos los registros
            return _context.Items.ToList(); 
        }

        public Item Put(Item item)
        {
            //busca por el Id el item que nos manda por parámetro
            var entity=  _context.Items.FirstOrDefault(x => x.Id == item.Id);
            //Modificar los datos de la entity original por la que mandan por parámetro
            entity.NombreTarea = item.NombreTarea;
            entity.EstaCompleta = item.EstaCompleta;
            entity.CategoriaId = item.CategoriaId;
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
