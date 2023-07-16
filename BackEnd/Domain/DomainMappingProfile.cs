using AutoMapper;
using BackEnd.DataAccess;
using BackEnd.DataBase.Entity;
using BackEnd.Domain.UserProfile;

namespace BackEnd.Domain
{
    public class DomainMappingProfile : Profile
    {
        public DomainMappingProfile()
        {

            CreateMap(typeof(QueryResult<>), typeof(QueryResultResource<>));
        }

    }
}
