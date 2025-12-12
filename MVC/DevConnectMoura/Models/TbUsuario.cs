using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Models;

[Table("tb_usuario")]
[Index("Email", Name = "UQ__tb_usuar__AB6E616469F54303", IsUnique = true)]
[Index("NomeUsuario", Name = "UQ__tb_usuar__CCB80B0A0BFCA64C", IsUnique = true)]
public partial class TbUsuario
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nome_completo")]
    [StringLength(255)]
    public string NomeCompleto { get; set; } = null!;

    [Column("nome_usuario")]
    [StringLength(50)]
    public string NomeUsuario { get; set; } = null!;

    [Column("email")]
    [StringLength(255)]
    public string Email { get; set; } = null!;

    [Column("senha")]
    [StringLength(50)]
    public string Senha { get; set; } = null!;

    [Column("foto_perfil_url")]
    [StringLength(50)]
    public string? FotoPerfilUrl { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbComentario> TbComentario { get; set; } = new List<TbComentario>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbCurtidas> TbCurtidas { get; set; } = new List<TbCurtidas>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbPublicacao> TbPublicacao { get; set; } = new List<TbPublicacao>();

    [ForeignKey("IdUsuarioSeguir")]
    [InverseProperty("IdUsuarioSeguir")]
    public virtual ICollection<TbUsuario> IdUsuarioSeguido { get; set; } = new List<TbUsuario>();

    [ForeignKey("IdUsuarioSeguido")]
    [InverseProperty("IdUsuarioSeguido")]
    public virtual ICollection<TbUsuario> IdUsuarioSeguir { get; set; } = new List<TbUsuario>();
}
