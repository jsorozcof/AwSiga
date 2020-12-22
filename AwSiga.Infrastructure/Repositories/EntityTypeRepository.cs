using AwSiga.Core.Entities;
using AwSiga.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AwSiga.Infrastructure.Repositories
{
    public class EntityTypeRepository : IEntityTypeRepository
    {
        public Task<IEnumerable<TipoEntidad>> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
