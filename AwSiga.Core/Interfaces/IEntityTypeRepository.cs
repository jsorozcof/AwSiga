using AwSiga.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AwSiga.Core.Interfaces
{
    public interface IEntityTypeRepository
    {
        Task<IEnumerable<TipoEntidad>> GetAll();
    }
}
