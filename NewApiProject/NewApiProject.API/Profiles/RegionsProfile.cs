using AutoMapper;
using Microsoft.Extensions.Options;

namespace NewApiProject.API.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
                .ReverseMap();
            //.ForMember(dest=>dest.Id,options=>options.MapFrom(src=>src.RegionId));
            //[This line of code will be used if both model properties have differnt name]

        }
    }
}
