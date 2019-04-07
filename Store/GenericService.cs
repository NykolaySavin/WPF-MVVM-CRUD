using HotelClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStore
{
    public interface IService<T> where T : class
    {
        void Create(T item);
        T FindById(Guid id);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Func<T, bool> predicate);
        void Remove(T item);
        void Update(T item);
    }
    public class GenericService<T> : IService<T> where T : Base
    {
        DbContext _context;
        DbSet<T> _dbSet;

        public GenericService(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual IEnumerable<T> Get()
        {
            return _dbSet.ToList();
        }
        public virtual IEnumerable<T> Get(Func<T, bool> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }
        public virtual T FindById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Create(T item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }
        public virtual void Update(T item)
        {
            _context.SaveChanges();
        }
        public virtual void Remove(T item)
        {
            _context.Entry(item).State = EntityState.Deleted;
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
    }
}
