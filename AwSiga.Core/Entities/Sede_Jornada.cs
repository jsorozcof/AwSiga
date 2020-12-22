using System;
using System.Collections.Generic;

#nullable disable

namespace AwSiga.Core.Entities
{
    public partial class Sede_Jornada
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int SedeId { get; set; }
        public int JornadaId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int EstadoId { get; set; }
        public int UsuarioCreacionId { get; set; }

        public virtual Jornada Jornada { get; set; }
        public virtual Sede Sede { get; set; }
    }
}
