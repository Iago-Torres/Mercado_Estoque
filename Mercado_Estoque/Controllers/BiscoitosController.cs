using Mercado_Estoque.Model.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using Mercado_Estoque.Model.Models;
using Mercado_Estoque.Model.ViewModel;

namespace Mercado_Estoque.Controllers
{
    public class BiscoitosController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var db = new MercadoestoqueContext();
            var biscoitos = await db.Biscoitos.ToListAsync();
            var biscoitosVM = biscoitos.Select(biscoito => new BiscoitoVM
            {

                ProdutoId = biscoito.ProdutoId,
                Nome = biscoito.Nome,
                MarcaId = biscoito.MarcaId,
                Preco = biscoito.Preco,
                Condicao = biscoito.Condicao,
                DataFabricacao = (DateTime)(biscoito?.DataFabricacao),
                DataValidade = biscoito.DataValidade
            });

            return View(biscoitosVM);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Biscoito biscoito)
        {
            var db = new MercadoestoqueContext();
            if (!ModelState.IsValid)
            {
                //db.Entry<Unidade>(unidade);
                db.Entry(biscoito).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                await db.SaveChangesAsync();
                ViewData["Mensagem"] = "Dados Salvos com Sucesso =)";
            }
            else
            {
                ViewData["MensagemErro"] = "Dados NÃO foram Salvos =(";
            }
            return View(biscoito);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var db = new MercadoestoqueContext();
            var biscoito = await db.Biscoitos.FindAsync(id);
            return View(biscoito);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Biscoito biscoito)
        {
            var db = new MercadoestoqueContext();
            if (!ModelState.IsValid)
            {
                db.Entry(biscoito).State = EntityState.Modified;
                await db.SaveChangesAsync();
                ViewData["Mensagem"] = "Dados Salvos com Sucesso =)";
            }
            else
            {
                ViewData["MensagemErro"] = "Dados NÃO foram Salvos =(";
            }
            return View(biscoito);
        }
        public async Task<IActionResult> Details(int id)
        {
            var db = new MercadoestoqueContext();
            var biscoito = await db.Biscoitos.FirstOrDefaultAsync(x => x.ProdutoId == id);
            return View(biscoito);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var db = new MercadoestoqueContext();
            var biscoito = await db.Biscoitos.FirstOrDefaultAsync(x => x.ProdutoId == id);
            return View(biscoito);
        }
        
        [HttpPost]
        public async Task<IActionResult> Delete(Biscoito biscoito)
        {
            var db = new MercadoestoqueContext();
            db.Entry(biscoito).State = EntityState.Deleted;
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
