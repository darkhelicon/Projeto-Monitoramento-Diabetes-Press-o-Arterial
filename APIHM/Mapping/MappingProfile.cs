using AutoMapper;
using Common;
using Repository.Entity;

namespace APIHM.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<UserEntity, UserModel>()
               /* .ForMember(dest => dest.TaxName, org => org.MapFrom(src => src.Tax != null ? src.Tax.Name : ""))*/;

        }
    }
}
