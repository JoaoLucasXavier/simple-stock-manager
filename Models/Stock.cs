using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace simple_stock_manager.Models
{
    public class Stock : Entity
    {
        public Guid ProductId { get; set; }

        [DisplayName("Quantidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int Amount { get; set; }

        public Product Product { get; set; }
    }
}
