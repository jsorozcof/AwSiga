using System;
using System.Collections.Generic;

#nullable disable

namespace AwSiga.Core.Entities
{
    public partial class PeriodoLectivo
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int SedeId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int EstadoId { get; set; }
        public int UsuarioCreacionId { get; set; }

        public virtual Sede Sede { get; set; }
    }
}
