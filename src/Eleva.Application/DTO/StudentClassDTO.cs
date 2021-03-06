﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eleva.Application.DTO
{
    public class StudentClassDTO
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo número da turma é obrigatório")]
        [MinLength(1)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "O campo número da turma só aceita valores numéricos")]
        public string NumberClass { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [MinLength(3, ErrorMessage = "O campo nome deve ter no mínimo 3 caracteres")]
        [MaxLength(100, ErrorMessage = "O campo nome deve ter no máximo 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo carga horária é obrigatório")]
        public int Workload { get; set; }

        [ScaffoldColumn(false)]
        public DateTime InitialDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime FinalDate { get; set; }

        public Guid SchoolId { get; set; }

        [ScaffoldColumn(false)]
        public string SchoolName { get; set; }
    }
}
