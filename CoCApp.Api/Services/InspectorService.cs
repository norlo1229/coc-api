using AutoMapper;
using CoCApp.DataAccess.Sql.Repositories;
using CoCApp.Domain;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CoCApp.Api.Services
{
    public class InspectorService : IInspectorService
    {
        private readonly IInspectorRepository inspectorRepository;
        private readonly ILogger<InspectorService> logger;

        public InspectorService(IInspectorRepository inspectorRepository, ILogger<InspectorService> logger, IMapper mapper)
        {
            this.inspectorRepository = inspectorRepository;
            this.logger = logger;
        }

        public async Task<Inspector> CreateInspectorAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Inspector> GetInspectorAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task SaveChangesAsync()
        {
            await inspectorRepository.SaveChangesAsync();
        }
    }
}
