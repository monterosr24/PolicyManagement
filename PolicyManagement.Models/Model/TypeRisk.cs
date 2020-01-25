using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolicyManagement.Models.Model
{
    [Table("TypeRisk")]
    public class TypeRisk: BaseModel
    {
        [Required]
        public string Type { get; set; }

        public string Description { get; set; }
    }
}
