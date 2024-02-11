using Library_Model.Entities.Abstract;

namespace Library_Model.Entities.Tables
{
    public  class  S_Card:BaseEntity
    {
        public int StudentsId { get; set; }
        public int BooksId { get; set; }

        //Navigation Property

        public virtual Book? Books { get; set; }
        public virtual  Student? Students { get; set; }
    }
}
