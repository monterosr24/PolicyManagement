using System;
using System.ComponentModel.DataAnnotations;

namespace PolicyManagement.Models.ModelView
{
    public class PolicyViewModel : BaseViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Inicio de vigencia de la póliza")]
        public DateTime StartPolicy { get; set; }

        [Required]
        [Display(Name = "Periodo de cobertura")]
        public int Period { get; set; }

        [Required]
        [Display(Name = "Precio de la poliza")]
        public int Price { get; set; }
        
        [Required]
        [Display(Name = "Tipo de cubrimiento")]
        public int IdTypeCovering { get; set; }

        [Required]
        [Display(Name = "Tipo de Riesgo")]
        public int IdTypeRisk { get; set; }

    }
}
