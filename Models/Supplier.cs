using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace simple_stock_manager.Models
{
    public class Supplier : Entity
    {
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }

        [DisplayName("Documento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Document { get; set; }

        [DisplayName("Tipo")]
        public TypeOfPerson SupplierType { get; set; }

        public SupplierAddress SupplierAddress { get; set; }

        [DisplayName("Ativo?")]
        public bool Active { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
