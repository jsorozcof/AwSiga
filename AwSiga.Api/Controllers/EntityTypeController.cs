using AwSiga.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwSiga.Api.Controllers
{
    public class EntityTypeController : ControllerBase
    {
        private readonly IEntityTypeRepository _EntityTypeRepository;
        public EntityTypeController(IEntityTypeRepository EntityTypeRepository)
        {
            _EntityTypeRepository = EntityTypeRepository;
        }
    }
}
