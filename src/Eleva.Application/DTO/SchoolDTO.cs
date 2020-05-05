using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eleva.Application.DTO
{
    public class SchoolDTO
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [Range(3, 100, ErrorMessage = "O campo nome deve ter entre 3 e 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo documento é obrigatório")]
        [Range(3, 100, ErrorMessage = "O campo nome deve ter entre 3 e 100 caracteres")]
        public string Document { get; set; }

        [Required(ErrorMessage = "Os dados de endereço são obrigatórios")]
        public AddressDTO Address { get; set; }

        public IEnumerable<StudentClassDTO> StudentClasses { get; set; }
    }
}
