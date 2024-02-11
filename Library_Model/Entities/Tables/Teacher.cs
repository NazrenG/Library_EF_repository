using Library_Model.Entities.Abstract;

namespace Library_Model.Entities.Tables
{
    public class Teacher:BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public float? Salary { get; set; }
         

        //Navigation Property

        public virtual  ICollection<Group>? Groups { get; set; }
        public virtual ICollection< T_Card>? T_Cards { get; set; }

    }
}
