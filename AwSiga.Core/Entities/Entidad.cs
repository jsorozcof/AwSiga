using System;
using System.Collections.Generic;

#nullable disable

namespace AwSiga.Core.Entities
{
    public partial class Entidad
    {
        public Entidad()
        {
            Sedes = new HashSet<Sede>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int PaisId { get; set; }
        public int CiudadId { get; set; }
        public int RegionId { get; set; }
        public string Direccion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Nit { get; set; }
        public string Correo { get; set; }
        public string Responsable1 { get; set; }
        public string Responsable2 { get; set; }
        public string Responsable3 { get; set; }
        public string Resolucion { get; set; }
        public string Dane { get; set; }
        public string Icfes { get; set; }
        public string RegistroEducativo { get; set; }
        public string Web { get; set; }
        public string Logo { get; set; }
        public string ColorPrimario { get; set; }
        public string ColorSecundario { get; set; }
        public int TipoEntidadId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int EstadoId { get; set; }
        public int UsuarioCreacionId { get; set; }

        public virtual TipoEntidad TipoEntidad { get; set; }
        public virtual ICollection<Sede> Sedes { get; set; }
    }
}
