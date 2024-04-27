using Mercado_Estoque.Model.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mercado_Estoque.Model.Models;
using Mercado_Estoque.Model.ViewModel;

namespace Mercado_Estoque.Controllers
{
    public class BebidasAdegaController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var db = new MercadoestoqueContext();
            var bebidas = await db.BebidasAdegas.ToListAsync();
            var bebidasVM = bebidas.Select(bebida => new BebidasAdegaVM
            {
                ProdutoId = bebida.ProdutoId,
                MarcaId = bebida.MarcaId,
                Nome = bebida.Nome,
                Preco = bebida.Preco,
                Condicao = bebida.Condicao,
                DataFabricacao = (DateTime)(bebida?.DataFabricacao),
                DataValidade = bebida.DataValidade
            });

            return View(bebidasVM);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BebidasAdega adega)
        {
            var db = new MercadoestoqueContext();
            if (!ModelState.IsValid)
            {
                //db.Entry<Unidade>(unidade);
                db.Entry(adega).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                await db.SaveChangesAsync();
                ViewData["Mensagem"] = "Dados Salvos com Sucesso =)";
            }
            else
            {
                ViewData["MensagemErro"] = "Dados NÃO foram Salvos =(";
            }
            return View(adega);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var db = new MercadoestoqueContext();
            var adega = await db.BebidasAdegas.FindAsync(id);
            return View(adega);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BebidasAdega adega)
        {
            var db = new MercadoestoqueContext();
            if (!ModelState.IsValid)
            {
                db.Entry(adega).State = EntityState.Modified;
                await db.SaveChangesAsync();
                ViewData["Mensagem"] = "Dados Salvos com Sucesso =)";
            }
            else
            {
                ViewData["MensagemErro"] = "Dados NÃO foram Salvos =(";
            }
            return View(adega);
        }
        public async Task<IActionResult> Details(int id)
        {
            var db = new MercadoestoqueContext();
            var adega = await db.BebidasAdegas.FirstOrDefaultAsync(x => x.ProdutoId == id);
            return View(adega);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var db = new MercadoestoqueContext();
            var adega = await db.BebidasAdegas.FirstOrDefaultAsync(x => x.ProdutoId == id);
            return View(adega);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(BebidasAdega adega)
        {
            var db = new MercadoestoqueContext();
            db.Entry(adega).State = EntityState.Deleted;
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

