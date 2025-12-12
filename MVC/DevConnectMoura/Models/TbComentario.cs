using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Models;

[Table("tb_comentario")]
public partial class TbComentario
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_usuario")]
    public int? IdUsuario { get; set; }

    [Column("id_publicacao")]
    public int? IdPublicacao { get; set; }

    [Column("texto")]
    [StringLength(255)]
    public string Texto { get; set; } = null!;

    public DateOnly DataComentario { get; set; }

    [ForeignKey("IdPublicacao")]
    [InverseProperty("TbComentario")]
    public virtual TbPublicacao? IdPublicacaoNavigation { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("TbComentario")]
    public virtual TbUsuario? IdUsuarioNavigation { get; set; }
}
