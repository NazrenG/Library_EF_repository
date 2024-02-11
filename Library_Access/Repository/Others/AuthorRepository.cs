using Library_Access.Repository.Abstract;
using Library_Model.Entities.Tables;
using Microsoft.EntityFrameworkCore;

namespace Library_Access.Repository.Others;

public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
{
    public ICollection<Author> GetAllWithBook()
    {
       return context.Set<Author>().Include(x=>x.Books).ToList();
    }
}

