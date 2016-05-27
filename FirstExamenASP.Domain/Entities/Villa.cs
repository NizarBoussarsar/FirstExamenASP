using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamenASP.Domain.Entities
{
    public class Villa : Domicile
    {
        public bool? APiscine { get; set; }

        public bool? AGarahe { get; set; }
    }
}
