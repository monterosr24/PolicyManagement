using System.ComponentModel.DataAnnotations;

namespace PolicyManagement.Models.ModelView
{
    public class ClientViewModel: BaseViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Dirección")]
        public string Direction { get; set; }
    }
}
