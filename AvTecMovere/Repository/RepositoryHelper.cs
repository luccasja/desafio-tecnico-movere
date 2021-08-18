using AvTecMovere.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AvTecMovere.Repository
{
    public class RepositoryHelper
    {
        private readonly string fileName = @"Data\Sales.json";

        private List<Sale> Read()
        {
            Directory.CreateDirectory("Data");

            try
            {
                string jsonSales = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<List<Sale>>(jsonSales);
            }
            catch (FileNotFoundException)
            {
                return new List<Sale>();
            }
        }

        private bool Write(List<Sale> sales)
        {
            Directory.CreateDirectory("Data");
            
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonSales = JsonSerializer.Serialize(sales, options);
            
            File.WriteAllText(fileName, jsonSales);

            return true;
        }
        
        public List<Sale> FindAll(Predicate<Sale> match = null)
        {
            if(match != null)
            {
                return Read().FindAll(match);
            }

            return Read();
        } 
            
        public bool Create(Sale sale)
        {
            List<Sale> sales = Read();
            sales.Add(sale);
            Write(sales);
            return true;
        }

        public bool Destroy(Guid id)
        {
            List<Sale> sales = Read();
            List<Sale> novaLista = sales.FindAll(x => x.Id != id);
            Write(novaLista);
            return true;
        }

        public bool Update(Sale sale)
        {
            List<Sale> newList = FindAll();
            int indice = newList.FindIndex(x => x.Id == sale.Id);
            newList[indice].NomeCliente = sale.NomeCliente;
            newList[indice].Valor = sale.Valor;
            newList[indice].DataVenda = sale.DataVenda;
            
            Write(newList);
            return true;
        }
    }
}
