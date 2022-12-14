using AutoMapper;
using SuperAbp.RegionManagement.Cities;
using SuperAbp.RegionManagement.Districts;
using SuperAbp.RegionManagement.Locations;
using SuperAbp.RegionManagement.Provinces;
using SuperAbp.RegionManagement.Regions;
using SuperAbp.RegionManagement.Streets;
using SuperAbp.RegionManagement.Villages;

namespace SuperAbp.RegionManagement;

public class RegionManagementApplicationAutoMapperProfile : Profile
{
    public RegionManagementApplicationAutoMapperProfile()
    {
        CreateMap<Province, RegionNodeDto>()
            .ForMember(entity => entity.IsLeaf,
                opt => opt.Ignore())
            .ForMember(entity => entity.Children,
                opt => opt.Ignore());
        CreateMap<City, RegionNodeDto>()
            .ForMember(entity => entity.IsLeaf,
                opt => opt.Ignore())
            .ForMember(entity => entity.Children,
                opt => opt.Ignore());
        CreateMap<District, RegionNodeDto>()
            .ForMember(entity => entity.IsLeaf,
                opt => opt.Ignore())
            .ForMember(entity => entity.Children,
                opt => opt.Ignore());
        CreateMap<Street, RegionNodeDto>()
            .ForMember(entity => entity.IsLeaf,
                opt => opt.Ignore())
            .ForMember(entity => entity.Children,
                opt => opt.Ignore());
        CreateMap<Village, RegionNodeDto>()
            .ForMember(entity => entity.IsLeaf,
                opt => opt.Ignore())
            .ForMember(entity => entity.Children,
                opt => opt.Ignore());

        CreateMap<RegionLocation, LocationListDto>();
    }
}
