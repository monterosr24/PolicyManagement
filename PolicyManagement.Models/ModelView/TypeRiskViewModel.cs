using System.ComponentModel.DataAnnotations;

namespace PolicyManagement.Models.ModelView
{
    public class TypeRiskViewModel: BaseViewModel
    {
        [Display(Name = "Tipo de Riesgo")]
        public string Type { get; set; }

        [Display(Name = "Descripción")]
        public string Description { get; set; }
    }
}
