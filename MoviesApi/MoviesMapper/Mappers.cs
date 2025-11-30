using AutoMapper;
using MoviesApi.DAL.Models;
using MoviesApi.DAL.Models.Dtos;

namespace MoviesApi.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateUpdateDto>().ReverseMap();

            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<Movie, MovieCreateUpdateDto>().ReverseMap();
        }
    }
}
