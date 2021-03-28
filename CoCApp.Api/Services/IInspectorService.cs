using System;
using System.Threading.Tasks;

namespace CoCApp.Api.Services
{
    public interface IInspectorService
    {
        Task<Domain.Inspector> GetInspectorAsync(Guid id);
        Task<Domain.Inspector> CreateInspectorAsync(Guid id);
        Task SaveChangesAsync();
    }
}
