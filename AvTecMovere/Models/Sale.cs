using System;
using System.ComponentModel.DataAnnotations;

namespace AvTecMovere.Models
{
    public class Sale
    {
        public Guid Id { get; set; }
        
        [Display(Name = "Nome do Cliente")]
        public string NomeCliente { get; set; }
        
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Display(Name = "Data da Venda")]
        public DateTime DataVenda { get; set; }


        public Sale()
        {
            Id = Guid.NewGuid();
        }

    }
}
