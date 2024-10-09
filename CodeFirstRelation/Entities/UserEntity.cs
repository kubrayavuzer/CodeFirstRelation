using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstRelation.Entities
{

    [Table("Users")]
    public class UserEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public List<PostEntity> Posts { get; set; }
    }
}
