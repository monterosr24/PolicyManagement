using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolicyManagement.Models.Model
{
    [Table("Client")]
    public class Client: BaseModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Direction { get; set; }

        public int IdPolicy { get; set; }

        public virtual ICollection<Policy> Policies { get; set; }
    }
}
