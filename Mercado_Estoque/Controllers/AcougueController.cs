using Mercado_Estoque.Model.Models;
using Mercado_Estoque.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Mercado_Estoque.Controllers
{
    public class AcougueController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var db = new MercadoestoqueContext();
            var acougues = await db.Acougues.ToListAsync();
            var acouguesVM = acougues.Select(acougue => new AcougueVM
            {
                ProdutoId = acougue.ProdutoId,
                MarcaId = acougue.MarcaId,
                Nome = acougue.Nome,
                Preco = acougue.Preco,
                Condicao = acougue.Condicao,
                DataFabricacao = (DateTime)(acougue?.DataFabricacao),
                DataValidade = acougue.DataValidade
            });

            return View(acouguesVM);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Acougue acougue)
        {
            var db = new MercadoestoqueContext();
            if (!ModelState.IsValid)
            {
                //db.Entry<Unidade>(unidade);
                db.Entry(acougue).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                await db.SaveChangesAsync();
                ViewData["Mensagem"] = "Dados Salvos com Sucesso =)";
            }
            else
            {
                ViewData["MensagemErro"] = "Dados NÃO foram Salvos =(";
            }
            return View(acougue);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var db = new MercadoestoqueContext();
            var acougue = await db.Acougues.FindAsync(id);
            return View(acougue);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Acougue acougue)
        {
            var db = new MercadoestoqueContext();
            if (!ModelState.IsValid)
            {
                db.Entry(acougue).State = EntityState.Modified;
                await db.SaveChangesAsync();
                ViewData["Mensagem"] = "Dados Salvos com Sucesso =)";
            }
            else
            {
                ViewData["MensagemErro"] = "Dados NÃO foram Salvos =(";
            }
            return View(acougue);
        }
        public async Task<IActionResult> Details(int id)
        {
            var db = new MercadoestoqueContext();
            var acougue = await db.Acougues.FirstOrDefaultAsync(x => x.ProdutoId == id);
            return View(acougue);
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
