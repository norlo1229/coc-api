using AutoMapper;
using CoCApp.Domain.Entities;

namespace CoCApp.Api.DataMapping
{
    public class DataMappingProfile : Profile
    {
        public DataMappingProfile()
        {
            CreateMap<Log, Domain.Dtos.Log>().ReverseMap();
            CreateMap<Investigator, Domain.Dtos.Investigator>().ReverseMap();
            CreateMap<Investigator, Domain.Dtos.CreateInvestigator>().ReverseMap();
            CreateMap<PersonalInformation, Domain.Dtos.PersonalInformation>().ReverseMap();
            CreateMap<Characteristics, Domain.Dtos.Characteristics>().ReverseMap();
        }
    }
}
