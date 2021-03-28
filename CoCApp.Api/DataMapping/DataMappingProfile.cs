using AutoMapper;

namespace CoCApp.Api.DataMapping
{
    public class DataMappingProfile : Profile
    {
        public DataMappingProfile()
        {
            this.CreateMap<DataAccess.Sql.Entities.Inspector, Domain.Inspector>().ReverseMap();
            this.CreateMap<DataAccess.Sql.Entities.SkillDefinition, Domain.SkillDefinition>().ReverseMap();
        }
    }
}
