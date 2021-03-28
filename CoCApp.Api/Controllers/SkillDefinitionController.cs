using CoCApp.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoCApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillDefinitionController : ControllerBase
    {
        private readonly ISkillDefinitionService skillDefinitionService;
        private readonly ILogger<SkillDefinitionController> logger;

        public SkillDefinitionController(ISkillDefinitionService skillDefinitionService, ILogger<SkillDefinitionController> logger)
        {
            this.skillDefinitionService = skillDefinitionService;
            this.logger = logger;
        }

        public async Task<ActionResult<List<Domain.SkillDefinition>>> GetAllASync()
        {
            var results = await skillDefinitionService.GetAllSkillDefinitionsAsync();
            return Ok(results);
        }

    }
}
