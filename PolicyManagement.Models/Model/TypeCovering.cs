using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolicyManagement.Models.Model
{
    [Table("TypeCovering")]
    public class TypeCovering: BaseModel
    {
        [Required]
        public string Name { get; set; }

        public int Percentage { get; set; }

    }
}
