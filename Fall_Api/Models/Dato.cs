using System;
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

        [Required]
        [MaxLength(100)]
        public string oc { get; set; }

        [Required]
        [MaxLength(100)]
        public string f12 { get; set; }

        [Required]
        [MaxLength(100)]
        public string sku { get; set; }

        [Required]
        [MaxLength(100)]
        public string cc { get; set; }

        public string estado { get; set; }
    }
}
