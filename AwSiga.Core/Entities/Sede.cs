using System;
using System.Collections.Generic;

#nullable disable

namespace AwSiga.Core.Entities
{
    public partial class Sede
    {
        public Sede()
        {
            Asignaturas = new HashSet<Asignatura>();
            Cursos = new HashSet<Curso>();
            PeriodoLectivos = new HashSet<PeriodoLectivo>();
            Personas = new HashSet<Persona>();
            Sede_Jornada = new HashSet<Sede_Jornada>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int EstadoId { get; set; }
        public int UsuarioCreacionId { get; set; }
        public int EntidadId { get; set; }

        public virtual Entidad Entidad { get; set; }
        public virtual ICollection<Asignatura> Asignaturas { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual ICollection<PeriodoLectivo> PeriodoLectivos { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<Sede_Jornada> Sede_Jornada { get; set; }
    }
}
