using Mercado_Estoque.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Estoque.Model.Repositories
{
    public class RepositoryBiscoitos : RepositoryBase<Biscoito>
    {
        public RepositoryBiscoitos(MercadoestoqueContext context, bool saveChanges = true) : base(context, saveChanges)
        {

        }
    }
}
