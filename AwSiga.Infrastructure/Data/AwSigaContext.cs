using System;
using AwSiga.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AwSiga.Infrastructure.Data
{
    public partial class AwSigaContext : DbContext
    {
        public AwSigaContext()
        {
        }

        public AwSigaContext(DbContextOptions<AwSigaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Asignatura> Asignaturas { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<Entidad> Entidads { get; set; }
        public virtual DbSet<Grupo> Grupos { get; set; }
        public virtual DbSet<Jornada> Jornada { get; set; }
        public virtual DbSet<PeriodoLectivo> PeriodoLectivos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Sede> Sedes { get; set; }
        public virtual DbSet<Sede_Jornada> SedeJornada { get; set; }
        public virtual DbSet<TipoEntidad> TipoEntidads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(local)\\SQLEXPRESS;Database=AwSiga;Integrated Security = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>(entity =>
            {
                entity.ToTable("Area", "ins");

                entity.HasIndex(e => e.Codigo, "UQ__Area__06370DAC483910EF")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Asignatura>(entity =>
            {
                entity.ToTable("Asignatura", "ins");

                entity.HasIndex(e => e.Codigo, "UQ__Asignatu__06370DAC77F52639")
                    .IsUnique();

                entity.HasIndex(e => e.Color, "UQ__Asignatu__E11D38455510B3BE")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Asignaturas)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Asignatur__AreaI__72C60C4A");

                entity.HasOne(d => d.Sede)
                    .WithMany(p => p.Asignaturas)
                    .HasForeignKey(d => d.SedeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Asignatur__Usuar__71D1E811");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.ToTable("Curso", "ins");

                entity.HasIndex(e => e.Codigo, "UQ__Curso__06370DACE3DFE098")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Seccion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Grupo)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.GrupoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Curso__UsuarioCr__778AC167");

                entity.HasOne(d => d.Sede)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.SedeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Curso__SedeId__787EE5A0");
            });

            modelBuilder.Entity<Entidad>(entity =>
            {
                entity.ToTable("Entidad", "adm");

                entity.HasIndex(e => e.Codigo, "UQ__Entidad__06370DAC3E1220E3")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ColorPrimario).HasMaxLength(50);

                entity.Property(e => e.ColorSecundario).HasMaxLength(50);

                entity.Property(e => e.Correo).HasMaxLength(50);

                entity.Property(e => e.Dane).HasMaxLength(255);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Direccion).HasMaxLength(255);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icfes).HasMaxLength(255);

                entity.Property(e => e.Nit).HasMaxLength(255);

                entity.Property(e => e.RegistroEducativo).HasMaxLength(255);

                entity.Property(e => e.Resolucion).HasMaxLength(255);

                entity.Property(e => e.Responsable1)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Responsable2).HasMaxLength(255);

                entity.Property(e => e.Responsable3).HasMaxLength(255);

                entity.Property(e => e.Telefono1).HasMaxLength(255);

                entity.Property(e => e.Telefono2).HasMaxLength(255);

                entity.Property(e => e.Web).HasMaxLength(255);

                entity.HasOne(d => d.TipoEntidad)
                    .WithMany(p => p.Entidads)
                    .HasForeignKey(d => d.TipoEntidadId)
                    .HasConstraintName("FK__Entidad__Usuario__5070F446");
            });

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.ToTable("Grupo", "ins");

                entity.HasIndex(e => e.Codigo, "UQ__Grupo__06370DACA7BDC6A9")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sede_Jornada>(entity =>
            {
                entity.ToTable("Jornada", "ins");

                entity.HasIndex(e => e.Codigo, "UQ__Jornada__06370DAC43464A9D")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PeriodoLectivo>(entity =>
            {
                entity.ToTable("PeriodoLectivo", "ins");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.HasOne(d => d.Sede)
                    .WithMany(p => p.PeriodoLectivos)
                    .HasForeignKey(d => d.SedeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PeriodoLe__Usuar__7C4F7684");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("Persona", "ins");

                entity.HasIndex(e => e.Codigo, "UQ__Persona__06370DAC76A33BFC")
                    .IsUnique();

                entity.HasIndex(e => e.NumeroIdentificacion, "UQ__Persona__FCA68D91D420B90B")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.NumeroIdentificacion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SegundoApellido).HasMaxLength(50);

                entity.Property(e => e.SegundoNombre).HasMaxLength(50);

                entity.HasOne(d => d.Sede)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.SedeId)
                    .HasConstraintName("FK__Persona__SedeId__6477ECF3");
            });

            modelBuilder.Entity<Sede>(entity =>
            {
                entity.ToTable("Sede", "ins");

                entity.HasIndex(e => e.Codigo, "UQ__Sede__06370DACAEC30780")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Entidad)
                    .WithMany(p => p.Sedes)
                    .HasForeignKey(d => d.EntidadId)
                    .HasConstraintName("FK__Sede__EntidadId__59063A47");
            });

            modelBuilder.Entity<Sede_Jornada>(entity =>
            {
                entity.ToTable("Sede_Jornada", "ins");

                entity.HasIndex(e => e.Codigo, "UQ__Sede_Jor__06370DAC5E5C878E")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Jornada)
                    .WithMany(p => p.Sede_Jornada)
                    .HasForeignKey(d => d.JornadaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sede_Jorn__Jorna__5EBF139D");

                entity.HasOne(d => d.Sede)
                    .WithMany(p => p.Sede_Jornada)
                    .HasForeignKey(d => d.SedeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sede_Jorn__Usuar__5DCAEF64");
            });

            modelBuilder.Entity<TipoEntidad>(entity =>
            {
                entity.ToTable("TipoEntidad", "adm");

                entity.HasIndex(e => e.Codigo, "UQ__TipoEnti__06370DACEDB28A1E")
                    .IsUnique();

                entity.HasIndex(e => e.Descripcion, "UQ__TipoEnti__92C53B6CA3A4CF0B")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
