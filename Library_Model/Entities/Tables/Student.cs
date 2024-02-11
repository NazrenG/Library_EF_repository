using Library_Model.Entities.Abstract;

namespace Library_Model.Entities.Tables
{
    public class Student:BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int ? Age { get; set; }

        //Foreign key
        public int Group_Id { get; set; }

        //navigation 
        public virtual Group? Group { get; set; }

        public virtual ICollection<S_Card>? S_Cards { get; set; }

    }
}
