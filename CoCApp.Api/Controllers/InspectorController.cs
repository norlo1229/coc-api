using CoCApp.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CoCApp.Api.Controllers
{
    public class InspectorController : ControllerBase
    {
        private readonly IInspectorService inspectorService;
        private readonly ILogger<InspectorController> logger;

        public InspectorController(IInspectorService inspectorService, ILogger<InspectorController> logger)
        {
            this.inspectorService = inspectorService;
            this.logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Inspector>> GetInspector(Guid inspectorId)
        {
            var inspector = await inspectorService.GetInspectorAsync(inspectorId);
            return Ok(inspector);
        }
    }
}
