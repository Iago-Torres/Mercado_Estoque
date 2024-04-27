using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mercado_Estoque.Model.Models;

namespace Mercado_Estoque.Model.Repositories
{
    public class RepositoryAcougue : RepositoryBase<Acougue>
    {
        public RepositoryAcougue(MercadoestoqueContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}
