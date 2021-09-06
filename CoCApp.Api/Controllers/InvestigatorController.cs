using AutoMapper;
using CoCApp.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using System.Threading.Tasks;

namespace CoCApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestigatorController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public InvestigatorController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<ActionResult<Domain.Dtos.Investigator>> Create(Domain.Dtos.CreateInvestigator investigator)
        {
            var result = await unitOfWork
                .Investigators
                .AddAsync((mapper.Map<Domain.Entities.Investigator>(investigator)));

            await unitOfWork.SaveChangesAsync();

            return Ok(mapper.Map<Domain.Dtos.Investigator>(result));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Dtos.Investigator>> Get(Guid id)
        {
            var result = await unitOfWork.Investigators.GetInvestigatorAsync(id);
            return Ok(mapper.Map<Domain.Dtos.Investigator>(result));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Domain.Dtos.Investigator>> Update(Guid id, Domain.Dtos.Investigator investigator)
        {

            try
            {
                if (id != investigator.Id)
                {
                    return BadRequest();
                }

                var result = await unitOfWork
                    .Investigators
                    .UpdateInvestigatorAsync(mapper.Map<Domain.Entities.Investigator>(investigator));
                await unitOfWork.SaveChangesAsync();

                return Ok(mapper.Map<Domain.Dtos.Investigator>(result));
            }
            catch (DbUpdateException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}
