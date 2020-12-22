using System;
using System.Collections.Generic;

#nullable disable

namespace AwSiga.Core.Entities
{
    public partial class Persona
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int TipoDocumentoId { get; set; }
        public string NumeroIdentificacion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public bool? Sexo { get; set; }
        public int TipoPersonaId { get; set; }
        public string Foto { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int EstadoId { get; set; }
        public int UsuarioCreacionId { get; set; }
        public int SedeId { get; set; }

        public virtual Sede Sede { get; set; }
    }
}
