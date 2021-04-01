using AutoMapper;
using CoCApp.Domain;

namespace CoCApp.Api.DataMapping
{
    public class DataMappingProfile : Profile
    {
        public DataMappingProfile()
        {
            CreateMap<Log, Dtos.Log>().ReverseMap();
        }
    }
}
