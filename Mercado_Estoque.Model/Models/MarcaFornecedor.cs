using System;
using System.Collections.Generic;

namespace Mercado_Estoque.Model.Models;

public partial class MarcaFornecedor
{
    public int MarcaId { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Acougue> Acougues { get; set; } = new List<Acougue>();

    public virtual ICollection<BebidasAdega> BebidasAdegas { get; set; } = new List<BebidasAdega>();

    public virtual ICollection<Biscoito> Biscoitos { get; set; } = new List<Biscoito>();

    public virtual ICollection<Congelado> Congelados { get; set; } = new List<Congelado>();

    public virtual ICollection<Enlatado> Enlatados { get; set; } = new List<Enlatado>();

    public virtual ICollection<FriosELaticinio> FriosELaticinios { get; set; } = new List<FriosELaticinio>();

    public virtual ICollection<Higiene> Higienes { get; set; } = new List<Higiene>();

    public virtual ICollection<Limpeza> Limpezas { get; set; } = new List<Limpeza>();

    public virtual ICollection<Padarium> Padaria { get; set; } = new List<Padarium>();
}
