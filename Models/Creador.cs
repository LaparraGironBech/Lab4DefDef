using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4DefDef.Models
{
    public class Creador
    {
        [Required]
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

    }
}
