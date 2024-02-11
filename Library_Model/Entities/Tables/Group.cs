using Library_Model.Entities.Abstract;

namespace Library_Model.Entities.Tables
{
    public  class Group:BaseEntity
    {
        public string? Name { get; set; }


        //Navigation Property

        public virtual ICollection<Teacher>? Teachers { get; set; }
        public virtual ICollection<Student>? Students { get; set; }

    }
}
