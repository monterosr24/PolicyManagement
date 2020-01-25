using AutoMapper;
using PolicyManagement.Models.Model;
using PolicyManagement.Models.ModelView;

namespace PolicyManagement.Models.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, ClientViewModel>().ReverseMap();
            CreateMap<Policy, PolicyViewModel>().ReverseMap();
            CreateMap<TypeCovering, TypeCoveringViewModel>().ReverseMap();
            CreateMap<TypeRisk, TypeRiskViewModel>().ReverseMap();
        }
    }
}
