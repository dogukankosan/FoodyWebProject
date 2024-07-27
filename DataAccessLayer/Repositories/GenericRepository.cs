using DataAccessLayer.Abstract;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context.Context _context;
        public GenericRepository(Context.Context context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            _context.Set<T>().Remove(_context.Set<T>().Find(id));
            _context.SaveChanges();
        }
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}