using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Models;

[Table("tb_publicacao")]
public partial class TbPublicacao
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_usuario")]
    public int? IdUsuario { get; set; }

    [Column("descricao")]
    [StringLength(255)]
    public string Descricao { get; set; } = null!;

    [Column("imagem_url")]
    [StringLength(50)]
    public string? ImagemUrl { get; set; }

    public DateOnly DataPublicacao { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("TbPublicacao")]
    public virtual TbUsuario? IdUsuarioNavigation { get; set; }

    [InverseProperty("IdPublicacaoNavigation")]
    public virtual ICollection<TbComentario> TbComentario { get; set; } = new List<TbComentario>();

    [InverseProperty("IdPublicacaoNavigation")]
    public virtual ICollection<TbCurtidas> TbCurtidas { get; set; } = new List<TbCurtidas>();
}
