using Library_Model.Entities.Abstract;

namespace Library_Model.Entities.Tables
{
    public  class Book:BaseEntity
    {
        public string? Title { get; set; }
        public int? PageCount { get; set; }
        public float? Salary { get; set; }
        public string? Description { get; set; }

        //Foreign key
        public int CategoryId { get; set; }
        //Navigation Property

        public virtual ICollection<Author>? Authors { get; set; }
        public virtual ICollection<S_Card>? S_Cards { get; set; }
        public virtual ICollection<T_Card>? T_Cards { get; set; }
        public virtual Category? Category { get; set; }
    }
}
