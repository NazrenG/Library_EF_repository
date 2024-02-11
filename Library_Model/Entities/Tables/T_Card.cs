using Library_Model.Entities.Abstract;

namespace Library_Model.Entities.Tables
{
    public class T_Card:BaseEntity
    {
        public int TeachersId { get; set; }
        public int BooksId { get; set; }

        //Navigation Property

        public virtual Book? Books { get; set; }
        public virtual  Teacher? Teachers { get; set; }
    }
}
