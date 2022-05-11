using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("Produtos")]
    public class Produto : Notifies
    {
        [Column("COD_PRODUTO")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("NOME")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("DESCRICAO")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Column("IMAGEM")]
        [Display(Name = "Descrição")]
        public byte[] Imagem { get; set; }

        [Column("VALOR")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

    }
}
