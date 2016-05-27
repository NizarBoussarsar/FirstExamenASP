using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamenASP.Domain.Entities
{
    public class Appartement : Domicile
    {
        [StringLength(50)]
        public string Immeuble { get; set; }
    }
}
