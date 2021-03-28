using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoCApp.Api.Services
{
    public interface ISkillDefinitionService
    {


        Task<List<Domain.SkillDefinition>> GetAllSkillDefinitionsAsync();
    }
}
