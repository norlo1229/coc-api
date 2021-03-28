using AutoMapper;
using CoCApp.DataAccess.Sql.Repositories;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoCApp.Api.Services
{
    public class SkillDefinitionService : ISkillDefinitionService
    {
        private readonly IRepository<DataAccess.Sql.Entities.SkillDefinition> skillDefinitionRepository;
        private readonly ILogger<SkillDefinitionService> logger;
        private readonly IMapper mapper;

        public SkillDefinitionService(IRepository<DataAccess.Sql.Entities.SkillDefinition> skillDefinitionRepository, ILogger<SkillDefinitionService> logger, IMapper mapper)
        {
            this.skillDefinitionRepository = skillDefinitionRepository;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async Task<List<Domain.SkillDefinition>> GetAllSkillDefinitionsAsync()
        {
            var skillDefinitions = await skillDefinitionRepository.GetAllAsync();
            skillDefinitions = skillDefinitions.OrderBy(s => s.Name).ToList();
            return mapper.Map<List<Domain.SkillDefinition>>(skillDefinitions);
        }
    }
}
