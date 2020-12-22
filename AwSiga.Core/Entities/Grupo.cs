using System;
using System.Collections.Generic;

#nullable disable

namespace AwSiga.Core.Entities
{
    public partial class Grupo
    {
        public Grupo()
        {
            Cursos = new HashSet<Curso>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int LimiteAlumnos { get; set; }
        public int SedeId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int EstadoId { get; set; }
        public int UsuarioCreacionId { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
