using AutoMapper;
using PolicyManagement.Models.Model;
using PolicyManagement.Models.ModelView;

namespace PolicyManagement.Models.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, ClientModelView>().ReverseMap();
            CreateMap<Policy, PolicyModelView>().ReverseMap();
            CreateMap<TypeCovering, TypeCoveringModelView>().ReverseMap();
            CreateMap<TypeRisk, TypeRiskModelView>().ReverseMap();
        }
    }
}
