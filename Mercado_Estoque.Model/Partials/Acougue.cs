using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace Mercado_Estoque.Model.Models
{
    [ModelMetadataType(typeof(MD_Acougue))]
    public partial class Acougue
    {
        class MD_Acougue
        {
            [Display(Name = "ID")]
            public int ProdutoId { get; set; }
            [Display(Name = "ID da Marca")]
            public int MarcaId { get; set; }
            [Display(Name = "Condição")]
            public string Condicao { get; set; } = null!;
            [Display(Name = "Preço")]
            public decimal Preco { get; set; }
            [Display(Name = "Fabricado em")]
            public DateTime DataFabricacao { get; set; }
            [Display(Name = "Válido até")]
            public DateTime DataValidade { get; set; }
        }

    }
}
