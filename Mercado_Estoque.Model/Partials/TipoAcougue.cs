using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace Mercado_Estoque.Model.Partials
{
    [ModelMetadataType(typeof(MD_Acougue))]
    public partial class Acougue
    {
        public class MD_Acougue
        {
            [Display(Name = "ID da Marca")]
            public int MarcaID { get; set; }
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
