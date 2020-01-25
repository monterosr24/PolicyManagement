
using PolicyManagement.Models.ModelView;
using System.ComponentModel.DataAnnotations;

namespace PolicyManagement.Models.ModelView
{
    public class ClientViewModel: BaseViewModel
    {
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Display(Name = "Dirección")]
        public string Direction { get; set; }
    }
}
