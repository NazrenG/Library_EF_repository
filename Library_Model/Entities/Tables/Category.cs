using Library_Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Model.Entities.Tables
{
    public  class Category:BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }


        ///navigation 
        public virtual ICollection<Book>? Books { get; set; }
    }                
}
