using System.ComponentModel.DataAnnotations;

namespace Mercado_Estoque.ViewModel
{
    public class CongeladoVM
    {
        [Display(Name = "ID")]
        public int ProdutoId { get; set; }

        [Display(Name = "ID da Marca")]
        public int MarcaId { get; set; }

        [Display(Name = "Condição")]
        public string Condicao { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Fabricado em")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataFabricacao { get; set; }

        [Display(Name = "Válido até")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataValidade { get; set; }

        public CongeladoVM()
        {

        }
    }
}
