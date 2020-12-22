using System;
using System.Collections.Generic;

#nullable disable

namespace AwSiga.Core.Entities
{
    public partial class Jornada
    {
        public Jornada()
        {
            Sede_Jornada = new HashSet<Sede_Jornada>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int EstadoId { get; set; }
        public int UsuarioCreacionId { get; set; }
        public int SedeId { get; set; }

        public virtual ICollection<Sede_Jornada> Sede_Jornada { get; set; }
    }
}
