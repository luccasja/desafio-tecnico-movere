using AvTecMovere.Models;
using AvTecMovere.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AvTecMovere.Controllers
{
    public class SalesController : Controller
    {
        private RepositoryHelper repository;

        public SalesController()
        {
            repository = new RepositoryHelper();
        }

        public IActionResult Index()
        {
            return View(repository.FindAll()
                .OrderByDescending(sale => sale.DataVenda)
                .ToList());
        }

        public IActionResult UpperSale()
        {
            return View(repository.FindAll()
                .OrderByDescending(sale => sale.Valor)
                .ToList());
        }

        public IActionResult UpperRevenues()
        {
            List<Sale> sales = repository.FindAll()
                .OrderBy(sale => sale.DataVenda).ToList();
            List<Sale> groupSales = new List<Sale>();

            foreach (Sale sale in sales)
            {
                if (groupSales.Exists(x => x.NomeCliente == sale.NomeCliente))
                {
                    var indice = groupSales.FindIndex(x => x.NomeCliente == sale.NomeCliente);
                    groupSales[indice].Valor += sale.Valor;
                    groupSales[indice].DataVenda = sale.DataVenda;
                }
                else
                {
                    groupSales.Add(sale);
                }
            }

            return View(groupSales.OrderByDescending(sale => sale.Valor).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Sale sale)
        {
            repository.Create(sale);

            TempData["msg"] = "Venda registrada com sucesso!";
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult Edit(Guid id)
        {
            return View(repository.FindAll()
                .Find(sale => sale.Id == id));
        }

        [HttpPost]
        public IActionResult Update(Sale sale)
        {
            repository.Update(sale);

            TempData["msg"] = "Venda alterada com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            repository.Destroy(id);

            TempData["msg"] = "Venda apagada com sucesso!";
            return RedirectToAction("Index");
        }
    }
}
