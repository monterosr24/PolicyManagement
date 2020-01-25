using System.ComponentModel.DataAnnotations.Schema;

namespace PolicyManagement.Models.Model
{
    [Table("ClientPolicy")]
    public class ClientPolicy:BaseModel
    {
        public int ClientId { get; set; }
        public int PolicyId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        [ForeignKey("PolicyId")]
        public virtual Policy Policy { get; set; }
    }
}
