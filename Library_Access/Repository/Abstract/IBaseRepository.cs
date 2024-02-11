using Library_Model.Entities.Abstract;

namespace Library_Access.Repository.Abstract
{
    public interface IBaseRepository<T> where T : BaseEntity, new()
    {
        ICollection<T> GetAll();
        T? GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Save();
    }

}
