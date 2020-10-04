using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace simple_stock_manager.Models
{
    public class Product : Entity
    {
        public Guid SupplierId { get; set; }

        [DisplayName("Produto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Description { get; set; }

        [DisplayName("Imagem")]
        [NotMapped]
        public IFormFile ImageUpload { get; set; }

        public string Image { get; set; }

        [DisplayName("Valor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Price { get; set; }

        [DisplayName("Data cadastro")]
        public DateTime DateRegister { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Ativo?")]
        public bool Active { get; set; }

        public Supplier Supplier { get; set; }
    }
}
