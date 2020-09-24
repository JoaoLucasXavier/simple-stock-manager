using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace simple_stock_manager.Models
{
    public class Shopping : Entity
    {
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DisplayName("Quantidade")]
        public int Amount { get; set; }

        [DisplayName("Valor compra")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal PurchasePrice { get; set; }

        [DisplayName("Data compra")]
        public DateTime PurchaseDate { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
