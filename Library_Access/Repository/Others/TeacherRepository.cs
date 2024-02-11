using Library_Access.Repository.Abstract;
using Library_Model.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Access.Repository.Others
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public ICollection<Teacher> GetAllGroup()
        {
            return context.Set<Teacher>().Include(x => x.Groups).ToList();
        }

       
    }
}
