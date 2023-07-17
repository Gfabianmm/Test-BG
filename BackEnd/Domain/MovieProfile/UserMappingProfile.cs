using AutoMapper;
using BackEnd.DataBase.Entity;
using BackEnd.Domain.ActorProfile;
using BackEnd.Domain.CategoryProfile;
using BackEnd.Domain.GenreProfile;

namespace BackEnd.Domain.MovieProfile
{
    public class MovieMappingProfile : Profile
    {
        public MovieMappingProfile()
        {
            CreateMap<Genre, GenreResource>().ReverseMap();
            CreateMap<Genre, GenreResourceSave>().ReverseMap();

            CreateMap<Actor, ActorResource>().ReverseMap();
            CreateMap<Actor, ActorResourceSave>().ReverseMap();

            CreateMap<Category, CategoryResource>().ReverseMap();
            CreateMap<Category, CategoryResourceSave>().ReverseMap();

            CreateMap<Movie, MovieResource>()
                .ForMember(a=>a.MovieGenres, dest=>dest.MapFrom(d=>d.MovieGenres.Select(b=>b.Genre)))
                .ForMember(a => a.MovieActors, dest => dest.MapFrom(d => d.MovieActors.Select(b => b.Actor)))
                .ForMember(a => a.MovieCategories, dest => dest.MapFrom(d => d.MovieCategories.Select(b => b.Category)))
                .ReverseMap();
            CreateMap<Movie, MovieResourceSave>().ReverseMap();
            CreateMap<MovieQuery, MovieQueryResource>().ReverseMap();

        }

    }
}
