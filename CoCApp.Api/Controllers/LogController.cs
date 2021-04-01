using AutoMapper;
using CoCApp.Api.Dtos;
using CoCApp.Api.Services.Interfaces;
using CoCApp.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoCApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogService logService;
        private readonly IMapper mapper;

        public LogController(ILogService logService, IMapper mapper)
        {
            this.logService = logService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dtos.Log>>> GetLogs([FromQuery] DateTimeOffset? beginDate, [FromQuery]DateTimeOffset? endDate, string logLevel)
        {
            var filters = new LogFilterOptions()
            {
                BeginDate = beginDate,
                EndDate = endDate,
                LogLevel = logLevel
            };

            var logs = await logService.GetFilteredLogsAsync(filters);
            return Ok(mapper.Map<List<Dtos.Log>>(logs));
        }
    }
}
