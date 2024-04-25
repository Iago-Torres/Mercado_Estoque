using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercado_Estoque.Model.Interfaces;
using Mercado_Estoque.Model.Models;

namespace Mercado_Estoque.Model.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T>, IDisposable where T : class
    {
        public MercadoestoqueContext _context;
        public bool _saveChanges = true;

        public RepositoryBase(MercadoestoqueContext context, bool saveChanges) 
        {
            _context = context;
            _saveChanges = saveChanges;
        } 
        public T Alterar(T obj)
        {
            _context.Entry<T>(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            if (_saveChanges) 
            { 
                _context.SaveChanges(); 
            }
            return obj;
        }

        public async Task<T> AlterarAsync(T obj)
        {
            _context.Entry<T>(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            if (_saveChanges)
            {
                await _context.SaveChangesAsync();
            }
            return obj;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Excluir(T obj)
        {
            _context.Set<T>().Remove(obj);
            if (_saveChanges) 
            {
                _context.SaveChanges(); 
            }
        }

        public void Excluir(params object[] variavel)
        {
            throw new NotImplementedException();
        }

        public async Task ExcluirAsync(T obj)
        {
            _context.Set<T>().Remove(obj);
            if (_saveChanges)
            {
              await _context.SaveChangesAsync();
            }
        }

        public Task ExcluirAsync(params object[] variavel)
        {
            throw new NotImplementedException();
        }

        public T Incluir(T obj)
        {
            _context.Set<T>().Add(obj);
            if(_saveChanges) 
            {
                _context.SaveChanges(); 
            }
            return obj;
        }

        public Task<T> IncluirAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public T SelecionarChave(params object[] variavel)
        {
            throw new NotImplementedException();
        }

        public List<T> SelecionarChave()
        {
            throw new NotImplementedException();
        }

        public Task<T> SelecionarChaveAsync(params object[] variavel)
        {
            throw new NotImplementedException();
        }

        public Task<T> SelecionarTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
