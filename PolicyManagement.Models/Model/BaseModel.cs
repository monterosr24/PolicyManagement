using System;
using System.ComponentModel.DataAnnotations;

namespace PolicyManagement.Models.Model
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedUser { get; set; }

        public DateTime? ModifydDate { get; set; }

        public string UpdatedUser { get; set; }

    }
}
