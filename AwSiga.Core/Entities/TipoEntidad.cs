using System;
using System.Collections.Generic;

#nullable disable

namespace AwSiga.Core.Entities
{
    public partial class TipoEntidad
    {
        public TipoEntidad()
        {
            Entidads = new HashSet<Entidad>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int EstadoId { get; set; }
        public int UsuarioCreacionId { get; set; }

        public virtual ICollection<Entidad> Entidads { get; set; }
    }
}
