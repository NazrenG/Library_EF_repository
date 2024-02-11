using Library_Model.Entities.Abstract;

namespace Library_Model.Entities.Tables
{
    public  class Author:BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Description { get; set; }

        //Navigation Property

        public virtual ICollection<Book>? Books { get; set; }
        
    }
}
