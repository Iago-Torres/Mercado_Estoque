using System;
using System.Collections.Generic;

namespace Mercado_Estoque.Model.Models;

public partial class FriosELaticinio
{
    public int ProdutoId { get; set; }

    public string Nome { get; set; } = null!;

    public int MarcaId { get; set; }

    public string Condicao { get; set; } = null!;

    public decimal Preco { get; set; }

    public DateTime DataFabricacao { get; set; }

    public DateTime DataValidade { get; set; }

    public int? Quantidade { get; set; }

    public virtual MarcaFornecedor Marca { get; set; } = null!;
}
