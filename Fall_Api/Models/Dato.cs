﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fall_Api.Models
{
    public class Dato
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string oc { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string f12 { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string sku { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string cc { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string estado { get; set; }
    }
}
