using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolicyManagement.Models.Model
{
    [Table("Policy")]
    public class Policy : BaseModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime StartPolicy { get; set; }

        [Required]
        public int Period { get; set; }

        [Required]
        public int Price { get; set; }

        [ForeignKey("TypeCovering")]
        public int IdTypeCovering { get; set; }

        [ForeignKey("TypeRisk")]
        public int IdTypeRisk { get; set; }


        public virtual TypeCovering TypeCovering { get; set; }
        public virtual TypeRisk TypeRisk { get; set; }

        public virtual Client Client { get; set; }

    }
}
