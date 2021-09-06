using CoCApp.DataAccess.Sql.Contexts;
using CoCApp.Domain.Entities;
using System.Threading.Tasks;

namespace CoCApp.DataAccess.Sql.Repositories
{
    public class CharacteristicsRepository : Repository<Characteristics>, ICharacteristicsRepository
    {
        public CharacteristicsRepository(AppDbContext context) : base(context)
        {

        }

        public Task SetStrength(int value)
        {
            return Task.FromResult(Task.CompletedTask);
        }
    }
}
