using System;
using System.Collections.Generic;
using DevConnectMoura.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Contexts;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbComentario> TbComentario { get; set; }

    public virtual DbSet<TbCurtidas> TbCurtidas { get; set; }

    public virtual DbSet<TbPublicacao> TbPublicacao { get; set; }

    public virtual DbSet<TbUsuario> TbUsuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevCon_SA");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbComentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_comen__3213E83FB7260D08");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbComentario).HasConstraintName("FK__tb_coment__id_pu__5629CD9C");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbComentario).HasConstraintName("FK__tb_coment__DataC__5535A963");
        });

        modelBuilder.Entity<TbCurtidas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_curti__3213E83F0AC4374C");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbCurtidas).HasConstraintName("FK__tb_curtid__id_pu__52593CB8");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbCurtidas).HasConstraintName("FK__tb_curtid__id_pu__5165187F");
        });

        modelBuilder.Entity<TbPublicacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_publi__3213E83F6645EBED");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbPublicacao).HasConstraintName("FK__tb_public__DataP__4D94879B");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_usuar__3213E83F29DF4583");

            entity.HasMany(d => d.IdUsuarioSeguido).WithMany(p => p.IdUsuarioSeguir)
                .UsingEntity<Dictionary<string, object>>(
                    "Seguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguido")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Seguidor__id_Usu__59FA5E80"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguir")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Seguidor__id_Usu__59063A47"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguir", "IdUsuarioSeguido").HasName("PK__Seguidor__134B0CB3DD7D24F6");
                        j.IndexerProperty<int>("IdUsuarioSeguir").HasColumnName("id_Usuario_Seguir");
                        j.IndexerProperty<int>("IdUsuarioSeguido").HasColumnName("id_Usuario_Seguido");
                    });

            entity.HasMany(d => d.IdUsuarioSeguir).WithMany(p => p.IdUsuarioSeguido)
                .UsingEntity<Dictionary<string, object>>(
                    "Seguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguir")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Seguidor__id_Usu__59063A47"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguido")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Seguidor__id_Usu__59FA5E80"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguir", "IdUsuarioSeguido").HasName("PK__Seguidor__134B0CB3DD7D24F6");
                        j.IndexerProperty<int>("IdUsuarioSeguir").HasColumnName("id_Usuario_Seguir");
                        j.IndexerProperty<int>("IdUsuarioSeguido").HasColumnName("id_Usuario_Seguido");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
