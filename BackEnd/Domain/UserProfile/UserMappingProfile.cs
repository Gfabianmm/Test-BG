using AutoMapper;
using BackEnd.DataBase.Entity;

namespace BackEnd.Domain.UserProfile
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {

            CreateMap<User, UserResource>().ReverseMap();
            CreateMap<User, UserResourceSave>().ReverseMap();
            CreateMap<UserQuery, UserQueryResource>().ReverseMap();
            
            
        }

    }
}
