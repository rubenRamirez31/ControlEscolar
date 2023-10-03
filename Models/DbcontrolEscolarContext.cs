using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ServicioSocial.Models;

public partial class DbcontrolEscolarContext : DbContext
{
    public DbcontrolEscolarContext()
    {
    }

    public DbcontrolEscolarContext(DbContextOptions<DbcontrolEscolarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alumnos> Alumnos { get; set; }

    public virtual DbSet<Aulas> Aulas { get; set; }

    public virtual DbSet<Calificaciones> Calificaciones { get; set; }

    public virtual DbSet<Carreras> Carreras { get; set; }

    public virtual DbSet<Colonias> Colonias { get; set; }

    public virtual DbSet<Datosgeneralesalumno> Datosgeneralesalumnos { get; set; }

    public virtual DbSet<Datosgeneralestrabajadores> Datosgeneralestrabajadores { get; set; }

    public virtual DbSet<Docentes> Docentes { get; set; }

    public virtual DbSet<Documentos> Documentos { get; set; }

    public virtual DbSet<Especialidades> Especialidades { get; set; }

    public virtual DbSet<Estados> Estados { get; set; }

    public virtual DbSet<Estatusalumno> Estatusalumnos { get; set; }

    public virtual DbSet<Grupos> Grupos { get; set; }

    public virtual DbSet<Kardex> Kardices { get; set; }

    public virtual DbSet<Lista> Listas { get; set; }

    public virtual DbSet<Materias> Materias { get; set; }

    public virtual DbSet<Modalidades> Modalidades { get; set; }

    public virtual DbSet<Municipios> Municipios { get; set; }

    public virtual DbSet<Paises> Paises { get; set; }

    public virtual DbSet<Periodos> Periodos { get; set; }

    public virtual DbSet<Roles> Roles { get; set; }

    public virtual DbSet<Tipoacreditado> Tipoacreditados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=DBControlEscolar;uid=root;pwd=1234", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.34-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Alumnos>(entity =>
        {
            entity.HasKey(e => e.NoControl).HasName("PRIMARY");

            entity.ToTable("alumnos");

            entity.HasIndex(e => e.Curp, "fk_al_dg");

            entity.HasIndex(e => e.IdCarrera, "fk_alu_carr");

            entity.HasIndex(e => e.IdEspecialidad, "fk_alu_esp");

            entity.HasIndex(e => e.IdEstatus, "fk_alu_est");

            entity.HasIndex(e => e.IdModalidad, "fl_alu_mod");

            entity.Property(e => e.NoControl).HasMaxLength(10);
            entity.Property(e => e.Curp)
                .HasMaxLength(18)
                .HasColumnName("CURP");
            entity.Property(e => e.IdEstatus).HasMaxLength(2);
            entity.Property(e => e.Pwd).HasMaxLength(50);

            entity.HasOne(d => d.CurpNavigation)
            .WithMany(p => p.Alumnos)
                .HasForeignKey(d => d.Curp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_al_dg");

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.Alumnos)
                .HasForeignKey(d => d.IdCarrera)
                .HasConstraintName("fk_alu_carr");

            entity.HasOne(d => d.IdEspecialidadNavigation).WithMany(p => p.Alumnos)
                .HasForeignKey(d => d.IdEspecialidad)
                .HasConstraintName("fk_alu_esp");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.Alumnos)
                .HasForeignKey(d => d.IdEstatus)
                .HasConstraintName("fk_alu_est");

            entity.HasOne(d => d.IdModalidadNavigation).WithMany(p => p.Alumnos)
                .HasForeignKey(d => d.IdModalidad)
                .HasConstraintName("fl_alu_mod");
        });

        modelBuilder.Entity<Aulas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("aulas");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Aula1)
                .HasMaxLength(10)
                .HasColumnName("Aula");
        });

        modelBuilder.Entity<Calificaciones>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("calificaciones");

            entity.HasIndex(e => e.IdAlumno, "fk_cal_alumno");

            entity.HasIndex(e => e.IdMateria, "fk_cal_mat");

            entity.Property(e => e.IdAlumno).HasMaxLength(10);
            entity.Property(e => e.IdMateria).HasMaxLength(25);

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany(p => p.Calificaciones)
                .HasForeignKey(d => d.IdAlumno)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_cal_alumno");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.Calificaciones)
                .HasForeignKey(d => d.IdMateria)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_cal_mat");
        });

        modelBuilder.Entity<Carreras>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("carreras");

            entity.Property(e => e.Carrera1)
                .HasMaxLength(50)
                .HasColumnName("Carrera");
            entity.Property(e => e.FinVigencia).HasColumnName("Fin_Vigencia");
            entity.Property(e => e.InicioVigencia).HasColumnName("Inicio_Vigencia");
        });

        modelBuilder.Entity<Colonias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("colonias")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.Asentamiento, "index_asentamiento");

            entity.HasIndex(e => e.Ciudad, "index_ciudad");

            entity.HasIndex(e => e.CodigoPostal, "index_codigo_postal");

            entity.HasIndex(e => e.Municipio, "index_municipio");

            entity.HasIndex(e => e.Nombre, "index_nombre");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(25)
                .HasColumnName("asentamiento");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .HasColumnName("ciudad");
            entity.Property(e => e.CodigoPostal).HasColumnName("codigo_postal");
            entity.Property(e => e.Municipio).HasColumnName("municipio");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("nombre");

            entity.HasOne(d => d.MunicipioNavigation).WithMany(p => p.Colonia)
                .HasForeignKey(d => d.Municipio)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_municipio");
        });

        modelBuilder.Entity<Datosgeneralesalumno>(entity =>
        {
            entity.HasKey(e => e.Curp).HasName("PRIMARY");

            entity.ToTable("datosgeneralesalumno");

            entity.HasIndex(e => e.IdLocalidad, "fk_dga_loc");

            entity.Property(e => e.Curp)
                .HasMaxLength(18)
                .HasColumnName("CURP");
            entity.Property(e => e.Amaterno)
                .HasMaxLength(25)
                .HasColumnName("AMaterno");
            entity.Property(e => e.Apaterno)
                .HasMaxLength(25)
                .HasColumnName("APaterno");
            entity.Property(e => e.Cp).HasColumnName("CP");
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.Foto).HasColumnType("mediumblob");
            entity.Property(e => e.Nombre).HasMaxLength(25);
            entity.Property(e => e.Sexo).HasMaxLength(1);
            entity.Property(e => e.UrlFoto).HasMaxLength(100);

            entity.HasOne(d => d.IdLocalidadNavigation).WithMany(p => p.Datosgeneralesalumnos)
                .HasForeignKey(d => d.IdLocalidad)
                .HasConstraintName("fk_dga_loc");
        });

        modelBuilder.Entity<Datosgeneralestrabajadores>(entity =>
        {
            entity.HasKey(e => e.Rfc).HasName("PRIMARY");

            entity.ToTable("datosgeneralestrabajadores");

            entity.HasIndex(e => e.IdLocalidad, "fk_dgt_loc");

            entity.Property(e => e.Rfc)
                .HasMaxLength(13)
                .HasColumnName("RFC");
            entity.Property(e => e.Amaterno)
                .HasMaxLength(25)
                .HasColumnName("AMaterno");
            entity.Property(e => e.Apaterno)
                .HasMaxLength(25)
                .HasColumnName("APaterno");
            entity.Property(e => e.Cp).HasColumnName("CP");
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.EsDocente).HasColumnType("bit(1)");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.Foto).HasColumnType("mediumblob");
            entity.Property(e => e.Nombre).HasMaxLength(25);
            entity.Property(e => e.Sexo).HasMaxLength(1);

            entity.HasOne(d => d.IdLocalidadNavigation).WithMany(p => p.Datosgeneralestrabajadores)
                .HasForeignKey(d => d.IdLocalidad)
                .HasConstraintName("fk_dgt_loc");
        });

        modelBuilder.Entity<Docentes>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("docentes");

            entity.HasIndex(e => e.IdCarrera, "fk_doc_carr");

            entity.Property(e => e.Pwd).HasMaxLength(50);
            entity.Property(e => e.Rfc)
                .HasMaxLength(13)
                .HasColumnName("RFC");
            entity.Property(e => e.Usuario).HasMaxLength(20);

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.Docentes)
                .HasForeignKey(d => d.IdCarrera)
                .HasConstraintName("fk_doc_carr");
        });

        modelBuilder.Entity<Documentos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("documentos");

            entity.HasIndex(e => e.IdAlumno, "IdAlumno").IsUnique();

            entity.Property(e => e.ActaNacimiento).HasColumnType("mediumblob");
            entity.Property(e => e.CertificadoSecundaria).HasColumnType("mediumblob");
            entity.Property(e => e.ComprobanteDomicilio).HasColumnType("mediumblob");
            entity.Property(e => e.IdAlumno).HasMaxLength(10);

            entity.HasOne(d => d.IdAlumnoNavigation).WithOne(p => p.Documento)
                .HasForeignKey<Documentos>(d => d.IdAlumno)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_doc_alum");
        });

        modelBuilder.Entity<Especialidades>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("especialidades");

            entity.HasIndex(e => e.IdCarrera, "fk_esp_carr");

            entity.Property(e => e.Especialidad).HasMaxLength(50);

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.Especialidades)
                .HasForeignKey(d => d.IdCarrera)
                .HasConstraintName("fk_esp_carr");
        });

        modelBuilder.Entity<Estados>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("estados")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Pais, "index_pais");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("nombre")
                .UseCollation("utf8mb3_unicode_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Pais).HasColumnName("pais");

            entity.HasOne(d => d.PaisNavigation).WithMany(p => p.Estados)
                .HasForeignKey(d => d.Pais)
                .HasConstraintName("fk_pais");
        });

        modelBuilder.Entity<Estatusalumno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("estatusalumno");

            entity.Property(e => e.Id).HasMaxLength(2);
            entity.Property(e => e.Estatus).HasMaxLength(30);
        });

        modelBuilder.Entity<Grupos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("grupos");

            entity.HasIndex(e => e.IdAula, "fk_gru_aul");

            entity.HasIndex(e => e.IdDocente, "fk_gru_doc");

            entity.HasIndex(e => e.IdMateria, "fk_gru_mat");

            entity.HasIndex(e => e.IdModalidad, "fk_gru_mod");

            entity.Property(e => e.Id).HasMaxLength(4);
            entity.Property(e => e.Grupo1)
                .HasMaxLength(1)
                .HasColumnName("Grupo");
            entity.Property(e => e.IdMateria).HasMaxLength(8);
            entity.Property(e => e.LimiteAlumnos).HasColumnName("Limite_Alumnos");

            entity.HasOne(d => d.IdAulaNavigation).WithMany(p => p.Grupos)
                .HasForeignKey(d => d.IdAula)
                .HasConstraintName("fk_gru_aul");

            entity.HasOne(d => d.IdDocenteNavigation).WithMany(p => p.Grupos)
                .HasForeignKey(d => d.IdDocente)
                .HasConstraintName("fk_gru_doc");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.Grupos)
                .HasForeignKey(d => d.IdMateria)
                .HasConstraintName("fk_gru_mat");

            entity.HasOne(d => d.IdModalidadNavigation).WithMany(p => p.Grupos)
                .HasForeignKey(d => d.IdModalidad)
                .HasConstraintName("fk_gru_mod");
        });

        modelBuilder.Entity<Kardex>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("kardex");

            entity.HasIndex(e => e.NoControl, "fk_kr_alu");

            entity.HasIndex(e => e.IdMateria, "fk_kr_mat");

            entity.HasIndex(e => e.IdPeriodo, "fk_kr_per");

            entity.HasIndex(e => e.IdTipoAcreditado, "fk_kr_ta");

            entity.Property(e => e.IdMateria).HasMaxLength(8);
            entity.Property(e => e.NoControl).HasMaxLength(10);

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.Kardices)
                .HasForeignKey(d => d.IdMateria)
                .HasConstraintName("fk_kr_mat");

            entity.HasOne(d => d.IdPeriodoNavigation).WithMany(p => p.Kardices)
                .HasForeignKey(d => d.IdPeriodo)
                .HasConstraintName("fk_kr_per");

            entity.HasOne(d => d.IdTipoAcreditadoNavigation).WithMany(p => p.Kardices)
                .HasForeignKey(d => d.IdTipoAcreditado)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_kr_ta");

            entity.HasOne(d => d.NoControlNavigation).WithMany(p => p.Kardices)
                .HasForeignKey(d => d.NoControl)
                .HasConstraintName("fk_kr_alu");
        });

        modelBuilder.Entity<Lista>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("listas");

            entity.HasIndex(e => e.IdGrupo, "fk_lis_gru");

            entity.HasIndex(e => e.IdPeriodo, "fk_lis_per");

            entity.Property(e => e.IdGrupo).HasMaxLength(4);
            entity.Property(e => e.NoControl).HasMaxLength(10);

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.Lista)
                .HasForeignKey(d => d.IdGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lis_gru");

            entity.HasOne(d => d.IdPeriodoNavigation).WithMany(p => p.Lista)
                .HasForeignKey(d => d.IdPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lis_per");
        });

        modelBuilder.Entity<Materias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("materias");

            entity.HasIndex(e => e.IdCarrera, "fk_mat_carr");

            entity.Property(e => e.Id).HasMaxLength(8);
            entity.Property(e => e.Materia1)
                .HasMaxLength(60)
                .HasColumnName("Materia");

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdCarrera)
                .HasConstraintName("fk_mat_carr");
        });

        modelBuilder.Entity<Modalidades>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("modalidades");

            entity.Property(e => e.Modalidad).HasMaxLength(40);
        });

        modelBuilder.Entity<Municipios>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("municipios")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Estado, "index_estado");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("nombre")
                .UseCollation("utf8mb3_unicode_ci")
                .HasCharSet("utf8mb3");

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.Municipios)
                .HasForeignKey(d => d.Estado)
                .HasConstraintName("fk_estado");
        });

        modelBuilder.Entity<Paises>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("paises")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("nombre")
                .UseCollation("utf8mb3_unicode_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<Periodos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("periodos");

            entity.Property(e => e.Activo).HasColumnType("bit(1)");
            entity.Property(e => e.Periodo1)
                .HasMaxLength(35)
                .HasColumnName("Periodo");
        });

        modelBuilder.Entity<Roles>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("roles");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Rol).HasMaxLength(35);
        });

        modelBuilder.Entity<Tipoacreditado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipoacreditado");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Tipo).HasMaxLength(35);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
