using AutoMapper;
using CoCApp.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoCApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacteristicsController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CharacteristicsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
    }
}
