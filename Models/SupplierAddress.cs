using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace simple_stock_manager.Models
{
    public class SupplierAddress : Entity
    {
        public Guid SupplierId { get; set; }

        [DisplayName("Logradouro")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string PublicPlace { get; set; }

        [DisplayName("Número")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(25, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Number { get; set; }

        [DisplayName("Complemento")]
        public string Complement { get; set; }

        [DisplayName("CEP")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(8, ErrorMessage = "O campo {0} precisa ter {1} caracteres.", MinimumLength = 8)]
        public string PostalCode { get; set; }

        [DisplayName("Bairro")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter {1} caracteres.", MinimumLength = 2)]
        public string Neighborhood { get; set; }

        [DisplayName("Cidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(25, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string City { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(25, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string State { get; set; }

        public Supplier Supplier { get; set; }
    }
}
