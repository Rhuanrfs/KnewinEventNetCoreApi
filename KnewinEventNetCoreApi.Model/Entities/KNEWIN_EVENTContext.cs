using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace KnewinEventNetCoreApi.Model.Entities
{
    public partial class KNEWIN_EVENTContext : DbContext
    {
        public KNEWIN_EVENTContext()
        {
        }

        public KNEWIN_EVENTContext(DbContextOptions<KNEWIN_EVENTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Calendario> Calendarios { get; set; }
        public virtual DbSet<Equipe> Equipes { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=KNEWIN_EVENT;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Calendario>(entity =>
            {
                entity.HasKey(e => e.CodCalendario)
                    .HasName("PK__CALENDAR__572E09A0A3920111");

                entity.ToTable("CALENDARIO");

                entity.Property(e => e.CodCalendario)
                    .ValueGeneratedNever()
                    .HasColumnName("COD_CALENDARIO");

                entity.Property(e => e.Ativo)
                    .HasColumnName("ATIVO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CodEquipe).HasColumnName("COD_EQUIPE");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.HasOne(d => d.CodEquipeNavigation)
                    .WithMany(p => p.Calendarios)
                    .HasForeignKey(d => d.CodEquipe)
                    .HasConstraintName("FK_CALENDARIO_EQUIPE");
            });

            modelBuilder.Entity<Equipe>(entity =>
            {
                entity.HasKey(e => e.CodEquipe)
                    .HasName("PK__EQUIPE__3391814CEF9ED3BB");

                entity.ToTable("EQUIPE");

                entity.Property(e => e.CodEquipe)
                    .ValueGeneratedNever()
                    .HasColumnName("COD_EQUIPE");

                entity.Property(e => e.Ativo)
                    .HasColumnName("ATIVO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NOME");
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasKey(e => e.CodEvento)
                    .HasName("PK__EVENTO__54855C176A86720D");

                entity.ToTable("EVENTO");

                entity.Property(e => e.CodEvento)
                    .ValueGeneratedNever()
                    .HasColumnName("COD_EVENTO");

                entity.Property(e => e.Ativo)
                    .HasColumnName("ATIVO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CodCalendario).HasColumnName("COD_CALENDARIO");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.HasOne(d => d.CodCalendarioNavigation)
                    .WithMany(p => p.Eventos)
                    .HasForeignKey(d => d.CodCalendario)
                    .HasConstraintName("FK_EVENTO_CALENDARIO");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.CodUsuario)
                    .HasName("PK__USUARIO__386804232AB68F3A");

                entity.ToTable("USUARIO");

                entity.Property(e => e.CodUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("COD_USUARIO");

                entity.Property(e => e.Apelido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APELIDO");

                entity.Property(e => e.CodEquipe).HasColumnName("COD_EQUIPE");

                entity.Property(e => e.Ddd)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DDD");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.Setor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SETOR");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE");

                entity.HasOne(d => d.CodEquipeNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.CodEquipe)
                    .HasConstraintName("FK_USUARIO_EQUIPE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
