using Library_Access.Context;
using Library_Access.Repository.Abstract;
using Library_Model.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Library_Access.Repository.Others
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, new()
    {

        internal LibraryContext context;
        internal DbSet<T> table;

        public BaseRepository()
        {
            context = new LibraryContext();
            table = context.Set<T>();
        }
        public void Add(T entity)
        {
            if (entity == null) 
                throw new Exception("null");
            table.Add(entity);
        }

        public ICollection<T> GetAll()
        {
            return table.ToList();
        }

        public T? GetById(int id)
        {
            return context.Set<T>().FirstOrDefault(a => a.Id == id);
        }

        public void Remove(T entity)
        {
            if (entity == null) 
                throw new Exception("null");

            var isChechk = context.Set<T>().FirstOrDefault(a => a.Id == entity.Id);

            if (isChechk == null) 
                throw new Exception("null");
            context.Set<T>().Remove(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }


        public void Update(T entity)
        {
            if (entity == null)
                throw new Exception("null");

            var isChechk = context.Set<T>().FirstOrDefault(a => a.Id == entity.Id);

            if (isChechk == null) 
                throw new Exception("null");
            context.Set<T>().Update(entity);
        }
    }
}
