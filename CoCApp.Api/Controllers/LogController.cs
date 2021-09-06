using AutoMapper;
using CoCApp.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoCApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public LogController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.Dtos.Log>>> GetLogs([FromQuery] DateTimeOffset? beginDate, [FromQuery]DateTimeOffset? endDate)
        {
            var finalStartDate = beginDate ?? DateTime.Now.AddDays(-1);
            var finalEndDate = endDate ?? DateTime.Now;

            var logs = await unitOfWork.Logs.GetLogsAsync(finalStartDate, finalEndDate);
            return Ok(mapper.Map<List<Domain.Dtos.Log>>(logs));
        }
    }
}
