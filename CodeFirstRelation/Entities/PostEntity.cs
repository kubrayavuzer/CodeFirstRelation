using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstRelation.Entities
{

    [Table("Posts")]
    public class PostEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public string Content { get; set; }
        public int UserId { get; set; }


        [ForeignKey(nameof(UserId))]
        public UserEntity User { get; set; }
    }
}
