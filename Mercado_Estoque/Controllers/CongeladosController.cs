﻿using Mercado_Estoque.Model.Models;
using Mercado_Estoque.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mercado_Estoque.Controllers
{
    public class CongeladosController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var db = new MercadoestoqueContext();
            var congelados = await db.Congelados.ToListAsync();
            var congeladosVM = congelados.Select(congelado => new CongeladoVM
            {

                ProdutoId = congelado.ProdutoId,
                MarcaId = congelado.MarcaId,
                Nome = congelado.Nome,
                Preco = congelado.Preco,
                Condicao = congelado.Condicao,
                DataFabricacao = (DateTime)(congelado?.DataFabricacao),
                DataValidade = congelado.DataValidade
            });

            return View(congeladosVM);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Congelado congelados)
        {
            var db = new MercadoestoqueContext();
            if (!ModelState.IsValid)
            {
                db.Entry(congelados).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                await db.SaveChangesAsync();
                ViewData["Mensagem"] = "Dados Salvos com Sucesso =)";
            }
            else
            {
                ViewData["MensagemErro"] = "Dados NÃO foram Salvos =(";
            }
            return View(congelados);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var db = new MercadoestoqueContext();
            var congelados = await db.Congelados.FindAsync(id);
            return View(congelados);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Congelado congelados)
        {
            var db = new MercadoestoqueContext();
            if (!ModelState.IsValid)
            {
                db.Entry(congelados).State = EntityState.Modified;
                await db.SaveChangesAsync();
                ViewData["Mensagem"] = "Dados Salvos com Sucesso =)";
            }
            else
            {
                ViewData["MensagemErro"] = "Dados NÃO foram Salvos =(";
            }
            return View(congelados);
        }
        public async Task<IActionResult> Details(int id)
        {
            var db = new MercadoestoqueContext();
            var congelados = await db.Congelados.FirstOrDefaultAsync(x => x.ProdutoId == id);
            return View(congelados);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var db = new MercadoestoqueContext();
            var congelados = await db.Congelados.FirstOrDefaultAsync(x => x.ProdutoId == id);
            return View(congelados);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Congelado congelados)
        {
            var db = new MercadoestoqueContext();
            db.Entry(congelados).State = EntityState.Deleted;
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
