using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eleva.Application.DTO
{
    public class AddressDTO
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo endereço é obrigatório")]
        [Range(3, 100, ErrorMessage = "O campo endereço deve ter entre 3 e 100 caracteres")]
        public string PublicPlace { get; set; }

        public string Complement { get; set; }

        [Required(ErrorMessage = "O campo número é obrigatório")]
        [MinLength(1)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "O campo número só aceita valores numéricos")]
        public string Number { get; set; }

        [Required(ErrorMessage = "O campo cep é obrigatório")]
        [Range(8, 8, ErrorMessage = "O campo cep deve conter 8 números")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "O campo cep só aceita valores numéricos")]
        public string Zipcode { get; set; }

        [Required(ErrorMessage = "O campo bairro é obrigatório")]
        [Range(3, 100, ErrorMessage = "O campo bairro deve ter entre 3 e 100 caracteres")]
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "O campo cidade é obrigatório")]
        [Range(3, 100, ErrorMessage = "O campo cidade deve ter entre 3 e 100 caracteres")]
        public string City { get; set; }

        [Required(ErrorMessage = "O campo estado é obrigatório")]
        [Range(2, 100, ErrorMessage = "O campo estado deve ter entre 2 e 100 caracteres")]
        public string State { get; set; }

        public Guid SchoolId { get; set; }
    }
}
