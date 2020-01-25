using PolicyManagement.Models.ModelView;
using System;

namespace PolicyManagement.Models.ModelView
{
    public class PolicyModelView : BaseModelView
    {
        public string Name { get; set; }

        public string Description { get; set; }
        
        public DateTime StartPolicy { get; set; }
        
        public int Period { get; set; }
        
        public int Price { get; set; }
        
        public int IdTypeCovering { get; set; }
        
        public int IdTypeRisk { get; set; }
        
    }
}
