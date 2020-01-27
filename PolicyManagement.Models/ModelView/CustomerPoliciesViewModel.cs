using System.ComponentModel.DataAnnotations;

namespace PolicyManagement.Models.ModelView
{
    public class CustomerPoliciesViewModel: BaseViewModel<string>
    {

        public int ClientId { get; set; }
        public int PolicyId { get; set; }
        public int ClientePolicyId { get; set; }

        [Display(Name = "Nombre Cliente")]
        public string NameClient { get; set; }

        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Display(Name = "Póliza")]
        public string NamePolicy { get; set; }

        [Display(Name = "Periodo")]
        public int Period { get; set; }

        [Display(Name = "Tipo riesgo")]
        public string Type { get; set; }

        [Display(Name = "Tipo de cubrimiento")]
        public string NameCovering { get; set; }

        [Display(Name = "Porcentaje")]
        public int Percentage { get; set; }
    }
}
