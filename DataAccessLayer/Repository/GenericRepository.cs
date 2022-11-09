using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T t)
        {
            using var _context = new DatabaseContext();
            _context.Add(t);
            _context.SaveChanges();

        }
        public void Remove(T t)
        {
            using var _context = new DatabaseContext();
            _context.Remove(t);
            _context.SaveChanges();
        }
        public void Update(T t)
        {
            using var _context = new DatabaseContext();
            _context.Update(t);
            _context.SaveChanges();
        }
        public List<T> GetAllList()
        {
            using var _context = new DatabaseContext();
            return _context.Set<T>().ToList();

        }

        public T GetTById(int id)
        {
            using var _context = new DatabaseContext();
            return _context.Set<T>().Find(id);
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using var context = new DatabaseContext();
            return context.Set<T>().Where(filter).ToList(); 
        }
    }
}
