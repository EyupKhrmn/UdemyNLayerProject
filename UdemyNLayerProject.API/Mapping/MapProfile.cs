using AutoMapper;
using UdemyNLayerProject.API.DTOs;
using UdemyNlayerProject.CORE.Model;

namespace UdemyNLayerProject.API.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
        }
        
    }
}