using System;
using System.Collections.Generic;

#nullable disable

namespace AwSiga.Core.Entities
{
    public partial class Curso
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Seccion { get; set; }
        public int GrupoId { get; set; }
        public int SedeId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int EstadoId { get; set; }
        public int UsuarioCreacionId { get; set; }

        public virtual Grupo Grupo { get; set; }
        public virtual Sede Sede { get; set; }
    }
}
