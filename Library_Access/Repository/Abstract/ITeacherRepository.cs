using Library_Model.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Access.Repository.Abstract
{
    public interface ITeacherRepository : IBaseRepository<Teacher>
    {
        ICollection<Teacher> GetAllGroup();

    }
}
