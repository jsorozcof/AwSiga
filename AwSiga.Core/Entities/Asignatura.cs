using System;
using System.Collections.Generic;

#nullable disable

namespace AwSiga.Core.Entities
{
    public partial class Asignatura
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? Prioridad { get; set; }
        public string Color { get; set; }
        public bool? ObtienePromedios { get; set; }
        public int AreaId { get; set; }
        public int SedeId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int EstadoId { get; set; }
        public int UsuarioCreacionId { get; set; }

        public virtual Area Area { get; set; }
        public virtual Sede Sede { get; set; }
    }
}
