
using System.ComponentModel.DataAnnotations;

namespace PolicyManagement.Models.ModelView
{
    public class TypeCoveringViewModel: BaseViewModel
    {
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Porcentaje")]
        public int Percentage { get; set; }

    }
}
